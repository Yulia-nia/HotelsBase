using System;
using System.Collections.Generic;
using System.Text;


using System.Diagnostics;
using System.Globalization;
using System.Linq;
using Urho;
using Urho.Actions;
using Urho.Gui;
using Urho.Shapes;

namespace HotelsBase.Services
{
    public class Charts : Application
    {
        bool movementsEnabled;
        Scene scene;
        Node plotNode;
        Camera camera;
        Octree octree;
        List<Bar> bars;

        public Bar SelectedBar { get; private set; }

        public IEnumerable<Bar> Bars => bars;

        [Preserve]
        public Charts(ApplicationOptions options = null) : base(options) { }

        static Charts()
        {
            UnhandledException += (s, e) =>
            {
                if (Debugger.IsAttached)
                    Debugger.Break();
                e.Handled = true;
            };
        }

        protected override void Start()
        {
            base.Start();
            CreateScene();
            SetupViewport();
        }

        async void CreateScene()
        {
            Input.SubscribeToTouchEnd(OnTouched);

            scene = new Scene();
            octree = scene.CreateComponent<Octree>();

            plotNode = scene.CreateChild();
            var baseNode = plotNode.CreateChild().CreateChild();
            var plane = baseNode.CreateComponent<StaticModel>();
            plane.Model = CoreAssets.Models.Plane;

            var cameraNode = scene.CreateChild();
            camera = cameraNode.CreateComponent<Camera>();
            cameraNode.Position = new Vector3(25, 30, 25) / 1.5f;
            cameraNode.Rotation = new Quaternion(-0.121f, 0.878f, -0.305f, -0.35f);

            Node lightNode = cameraNode.CreateChild();
            var light = lightNode.CreateComponent<Light>();
            light.LightType = LightType.Point;
            light.Range = 100;
            light.Brightness = 1.1f;

            int size = 3;
            baseNode.Scale = new Vector3(size * 4f, 2, size * 4f);
            bars = new List<Bar>(size * size);
            //тут поменять все и присвоить значенияяяяя


            var boxNode = plotNode.CreateChild();
            boxNode.Position = new Vector3(3 / 2.5f - 0f, 0, 3 / 2.5f - 0f);
            var box = new Bar(new Color(RandomHelper.NextRandom(), RandomHelper.NextRandom(), RandomHelper.NextRandom(), 0.7f));
            boxNode.AddComponent(box);
            box.SetValueWithAnimation(9.1f);///(Math.Abs(i) + Math.Abs(j) + 1) / 2f);
            bars.Add(box);


            var boxNode1 = plotNode.CreateChild();
            boxNode1.Position = new Vector3(3 / 2.5f - 0f, 0, 3 / 2.5f - 2.5f);
            var box1 = new Bar(new Color(RandomHelper.NextRandom(), RandomHelper.NextRandom(), RandomHelper.NextRandom(), 0.7f));
            boxNode1.AddComponent(box1);
            box1.SetValueWithAnimation(8.4f);///(Math.Abs(i) + Math.Abs(j) + 1) / 2f);
            bars.Add(box1);


            //for (var i = 0f; i < size * 2.5f; i += 2.5f)
            //{
            //    for (var j = 0f; j < size * 2.5f; j += 2.5f)
            //    {
            //        var boxNode = plotNode.CreateChild();
            //        boxNode.Position = new Vector3(size / 2.5f - i, 0, size / 2.5f - j);                    
            //        var box = new Bar(new Color(RandomHelper.NextRandom(), RandomHelper.NextRandom(), RandomHelper.NextRandom(), 0.7f));
            //        boxNode.AddComponent(box);                 
            //        box.SetValueWithAnimation(3);///(Math.Abs(i) + Math.Abs(j) + 1) / 2f);
            //        bars.Add(box);
            //    }
            //}

            SelectedBar = bars.First();
            SelectedBar.Select();



            try
            {
                await plotNode.RunActionsAsync(new EaseBackOut(new RotateBy(2f, 0, 360, 0)));
            }
            catch (OperationCanceledException) { }
            movementsEnabled = true;
        }

        void OnTouched(TouchEndEventArgs e)
        {
            Ray cameraRay = camera.GetScreenRay((float)e.X / Graphics.Width, (float)e.Y / Graphics.Height);
            var results = octree.RaycastSingle(cameraRay, RayQueryLevel.Triangle, 100, DrawableFlags.Geometry);
            if (results != null)
            {
                var bar = results.Value.Node?.Parent?.GetComponent<Bar>();
                if (SelectedBar != bar)
                {
                    SelectedBar?.Deselect();
                    SelectedBar = bar;
                    SelectedBar?.Select();
                }
            }
        }

        protected override void OnUpdate(float timeStep)
        {
            if (Input.NumTouches >= 1 && movementsEnabled)
            {
                var touch = Input.GetTouch(0);
                plotNode.Rotate(new Quaternion(0, -touch.Delta.X, 0), TransformSpace.Local);
            }
            base.OnUpdate(timeStep);
        }

        public void Rotate(float toValue)
        {
            plotNode.Rotate(new Quaternion(0, toValue, 0), TransformSpace.Local);
        }

        void SetupViewport()
        {
            var renderer = Renderer;
            var vp = new Viewport(Context, scene, camera, null);
            renderer.SetViewport(0, vp);
        }
    }

    
}
