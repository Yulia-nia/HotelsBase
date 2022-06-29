using HotelsBase.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelsBase.ViewModels
{
    public class OfferDatabase
    {
        readonly SQLiteAsyncConnection database;

        public OfferDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Offers>().Wait();
        }

        public Task<List<Offers>> GetItemsAsync()
        {
            return database.Table<Offers>().ToListAsync();
        }

        public Task<List<Offers>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Offers>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }

        public Task<Offers> GetItemAsync(int id)
        {
            return database.Table<Offers>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Offers item)
        {
            if (item.Id != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Offers item)
        {
            return database.DeleteAsync(item);
        }
    }
}
