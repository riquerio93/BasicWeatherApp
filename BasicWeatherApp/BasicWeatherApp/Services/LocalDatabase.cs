using System.Collections.Generic;
using System.Threading.Tasks;
using BasicWeatherApp.Models;
using SQLite;

namespace BasicWeatherApp.Services
{
    public class LocalDatabase
    {
        readonly SQLiteAsyncConnection Database;
        
        public LocalDatabase(string dbPath)
        {
            Database = new SQLiteAsyncConnection(dbPath);
            Database.CreateTableAsync<FavoriteLocation>().Wait();
        }

        public Task<List<FavoriteLocation>> GetItemsAsync()
        {
            return Database.Table<FavoriteLocation>().ToListAsync();
        }
        
        public Task<FavoriteLocation> GetItemAsync(int id)
        {
            return Database.Table<FavoriteLocation>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }
        
        public Task<int> PostItemAsync(FavoriteLocation loc)
        {
            return Database.InsertAsync(loc);
        }
        
        public Task<int> PutItemAsync(FavoriteLocation loc)
        {
            if (loc.ID != 0)
                return Database.UpdateAsync(loc);

            return null;
        }
        
        public Task<int> DeleteItemAsync(FavoriteLocation loc)
        {
            return Database.DeleteAsync(loc);
        }
    }
}
