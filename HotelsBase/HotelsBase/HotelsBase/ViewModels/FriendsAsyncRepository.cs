using System;
using System.Collections.Generic;
using System.Text;


using HotelsBase.Models;
using System.Linq;
using SQLite;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace HotelsBase.ViewModels
{
    public class FriendAsyncRepository
    {
        SQLiteAsyncConnection database;

        public FriendAsyncRepository(string filename)
        {            
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename);
            database = new SQLiteAsyncConnection(databasePath);
        }

        public async Task CreateTable()
        {
            await database.CreateTableAsync<Offers>();
        }
        public async Task<List<Offers>> GetItemsAsync()
        {
            return await database.Table<Offers>().ToListAsync();
        }
        public Task<List<Offers>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Offers>("SELECT * FROM [Friend] WHERE [Done] = 0");
        }
        public async Task<Offers> GetItemAsync(int id)
        {
            //var friends = await database.Table<Offers>().ToListAsync().ConfigureAwait(false);
            //// Операции продолжают выполняться в фоновом потоке, а не в UI-потоке
           // foreach(var friend in friends) {
            return await database.GetAsync<Offers>(id); 
        }
        public async Task<int> DeleteItemAsync(Offers item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(Offers item)
        {
            if (item.Id != 0)
            {
                await database.UpdateAsync(item);
                return item.Id;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }
    }
}
