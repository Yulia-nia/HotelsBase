using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelsBase.Models;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using HotelsBase.Droid;
using System.IO;
using Xamarin.Forms;

namespace HotelsBase.Droid
{
    public class SQLite_Android : ISQLite
    {
        //public SQLite_Android() { }
        //public string GetDatabasePath(string sqliteFilename)
        //{
        //    string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        //    var path = Path.Combine(documentsPath, sqliteFilename);
        //    return path;
        //}
        public SQLite_Android() { }
        public string GetDatabasePath(string sqliteFilename)
        {
            // определяем путь к бд
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // папка библиотеки
            var path = Path.Combine(libraryPath, sqliteFilename);

            return path;
        }
        //public string GetDatabasePath(string sqliteFilename)
        //{
        //    string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        //    var path = Path.Combine(documentsPath, sqliteFilename);
        //    // копирование файла из папки Assets по пути path
        //    if (!File.Exists(path))
        //    {
        //        // получаем контекст приложения
        //        Context context = Android.App.Application.Context;
        //        var dbAssetStream = context.Assets.Open(sqliteFilename);

        //        var dbFileStream = new System.IO.FileStream(path, System.IO.FileMode.OpenOrCreate);
        //        var buffer = new byte[1024];

        //        int b = buffer.Length;
        //        int length;

        //        while ((length = dbAssetStream.Read(buffer, 0, b)) > 0)
        //        {
        //            dbFileStream.Write(buffer, 0, length);
        //        }

        //        dbFileStream.Flush();
        //        dbFileStream.Close();
        //        dbAssetStream.Close();
        //    }

        //    return path;
        //}
    }
}