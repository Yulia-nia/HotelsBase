using System;
using System.Collections.Generic;
using System.Text;

using HotelsBase.Models;
using System.Linq;
using SQLite;
using Xamarin.Forms;

namespace HotelsBase.ViewModels
{
    public class FriendRepository
    {
        static object locker = new object();
        SQLiteConnection database;
        public FriendRepository(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Offers>();
        }
        public IEnumerable<Offers> GetItems()
        {
            return (from i in database.Table<Offers>() select i).ToList();
        }
        public Offers GetItem(int id)
        {
            return database.Get<Offers>(id);
        }
        public int DeleteItem(int id)
        {
            lock (locker)
            {
                return database.Delete<Offers>(id);
            }
        }
        public int SaveItem(Offers item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
