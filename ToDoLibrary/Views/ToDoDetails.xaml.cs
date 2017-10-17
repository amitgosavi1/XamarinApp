using System;
using System.Diagnostics;
using Xamarin.Forms;
using ToDoLibrary.Models;
using ToDoLibrary.Views;


namespace ToDoLibrary.Views
{
    public partial class ToDoDetails : ContentPage
    {
        public ToDoDetails()
        {
            InitializeComponent();
        }

        async void ToDoSaved(object sender, System.EventArgs e)
        {
            var todoItem = (TodoItem)BindingContext;
            await App.DBManager.SaveItemAsync(todoItem);
            await Navigation.PopAsync();
        }

    }
}
