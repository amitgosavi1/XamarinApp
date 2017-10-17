using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;
using ToDoLibrary.Models;
using System.Collections.ObjectModel;
using ToDoLibrary.Views;


namespace ToDoLibrary.Views
{
    public partial class ToDoList : ContentPage
    {
        ObservableCollection<TodoItem> items = new ObservableCollection<TodoItem>();

        public ToDoList() {

            InitializeComponent();

        }


        /// <summary>
        /// Get the list items and refresh list.
        /// </summary>
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            items.Clear();

            listItems.ItemsSource = await App.DBManager.getItemList();


        } 

        /// <summary>
        /// Navigate user to details screen to add new entry
        /// </summary>
        async void AddNewItem() 
        {
            await Navigation.PushAsync(new ToDoDetails
            {
                BindingContext = new TodoItem()
            });
        }

    }




}
