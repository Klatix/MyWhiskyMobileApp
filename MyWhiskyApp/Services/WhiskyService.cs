using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using MyWhiskyApp.Services;
using SQLite;

namespace MyWhiskyApp.Models
{
    public class WhiskyService
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null)
                return;

            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyData.db");

            db = new SQLiteAsyncConnection(databasePath);
            await db.CreateTableAsync<WhiskyItem>();


            var items = await db.Table<WhiskyItem>().ToListAsync();
            foreach (var item in items)
            {
                if (items.Contains(item))
                {
                    return;
                }
            }
                await db.InsertAllAsync(MockDataStore.items);

        }

        public static async Task AddWhiskyItem(string name, string description, string imageName)
        {
            await Init();
            var item = new WhiskyItem
            {
                Name = name,
                Description = description,
                ImageName = imageName
            };

            await db.InsertAsync(item); 
        }

        public static async Task RemoveWhiskyItem(int Id)
        {
            await Init();
            await db.DeleteAsync<WhiskyItem>(Id);
        }

        public static async Task<IEnumerable<WhiskyItem>> GetWhiskyItems()
        {
            await Init();
            var items = await db.Table<WhiskyItem>().ToListAsync();
            return items;
        }
    }
}
