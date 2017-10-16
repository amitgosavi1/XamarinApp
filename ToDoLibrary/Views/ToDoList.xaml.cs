using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;
using ToDoLibrary.Models;
using System.Collections.ObjectModel;

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
        /// ToDO: Get items from local database.
        /// </summary>
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            items.Clear();
            TodoItem item1 = new TodoItem()
            {
                ID = 1,
                 Name = "Item 1",
                Notes = "Hello",
                Done = false

            };
            items.Add(item1);
            TodoItem item2 = new TodoItem()
            {
                ID = 2,
                Name = "Item 2 Hello World Hello World Hello World Hello World Hello World",
                Notes = "Hello World",
                Done = false

            };

            items.Add(item2);
            listItems.ItemsSource = items;


        } 

        /// <summary>
        /// Navigate user to details screen to add new entry
        /// </summary>
        async void AddNewItem() 
        {
            await Navigation.PushAsync(new ToDoDetails());

        }
    }




}
