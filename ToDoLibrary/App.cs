using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;
using ToDoLibrary.Views;
using ToDoLibrary;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace ToDoLibrary
{
    public class App : Application
    {
        static DatabaseManager database;
        public App()
        {
            Xamarin.Forms.DependencyService.Register<ToDoList>();
            var nav = new NavigationPage(new ToDoList());
            nav.BarBackgroundColor = Color.DarkBlue;
            nav.BarTextColor = Color.White;
            MainPage = nav;
        }

        public static DatabaseManager DBManager
        {
            get{

                if(database == null)
                {
                    database = new DatabaseManager(DependencyService.Get<IPathHelper>().GetDatabasePath());
                }
                return database;
            }
        }
    }
}
