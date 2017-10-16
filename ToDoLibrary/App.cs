using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;
using ToDoLibrary.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace ToDoLibrary
{
    public class App : Application
    {
        public App()
        {
            var nav = new NavigationPage(new ToDoList());
            MainPage = nav;
        }
    }
}
