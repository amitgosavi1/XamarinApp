using System;
using System.IO;
using Xamarin.Forms;
using ToDoLibrary;
using ToDoList;

[assembly: Dependency(typeof(PathHelper))]
namespace ToDoList
{
    public class PathHelper :IPathHelper
    {
        public string GetDatabasePath(){
            string dbFolder = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Personal))
                                          .Parent.FullName + "/databases";

            if (!Directory.Exists(dbFolder))
            {
                Directory.CreateDirectory(dbFolder);
            }
            dbFolder = dbFolder + "/dBase.db3";
              
            return dbFolder;
        }
    }
}
