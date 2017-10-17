using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;
using ToDoLibrary.Models;


namespace ToDoLibrary
{


    public interface IPathHelper
    {
        string GetDatabasePath();
    }

    public class DatabaseManager
    {
        readonly SQLiteAsyncConnection database;
        readonly SQLiteConnection dcon;
        public DatabaseManager(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            dcon = new SQLiteConnection(dbPath, false);
            try {
                //dcon.CreateTable<TodoItem>(CreateFlags.None);
                database.CreateTableAsync<TodoItem>().Wait();
            } catch(Exception e){
                
                System.Diagnostics.Debug.WriteLine(e);
            }

        }

        public Task<List<TodoItem>> getItemList()
        {
            return  database.Table<TodoItem>().ToListAsync();
        }

        public Task<int> SaveItemAsync(TodoItem item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }
    }
}
