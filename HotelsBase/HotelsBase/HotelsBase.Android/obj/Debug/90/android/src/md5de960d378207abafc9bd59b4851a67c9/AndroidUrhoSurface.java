package md5de960d378207abafc9bd59b4851a67c9;


public class AndroidUrhoSurface
	extends android.widget.FrameLayout
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLayout:(ZIIII)V:GetOnLayout_ZIIIIHandler\n" +
			"";
		mono.android.Runtime.register ("Urho.Forms.AndroidUrhoSurface, UrhoSharp.Forms", AndroidUrhoSurface.class, __md_methods);
	}


	public AndroidUrhoSurface (android.content.Context p0)
	{
		super (p0);
		if (getClass () == AndroidUrhoSurface.class)
			mono.android.TypeManager.Activate ("Urho.Forms.AndroidUrhoSurface, UrhoSharp.Forms", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public AndroidUrhoSurface (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == AndroidUrhoSurface.class)
			mono.android.TypeManager.Activate ("Urho.Forms.AndroidUrhoSurface, UrhoSharp.Forms", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public AndroidUrhoSurface (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == AndroidUrhoSurface.class)
			mono.android.TypeManager.Activate ("Urho.Forms.AndroidUrhoSurface, UrhoSharp.Forms", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public AndroidUrhoSurface (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == AndroidUrhoSurface.class)
			mono.android.TypeManager.Activate ("Urho.Forms.AndroidUrhoSurface, UrhoSharp.Forms", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public void onLayout (boolean p0, int p1, int p2, int p3, int p4)
	{
		n_onLayout (p0, p1, p2, p3, p4);
	}

	private native void n_onLayout (boolean p0, int p1, int p2, int p3, int p4);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
