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

        protected override async void OnAppearing()
        {
            base.OnAppearing();
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
                Name = "Item 2",
                Notes = "Hello World",
                Done = false

            };

            items.Add(item2);
            listItems.ItemsSource = items;


        } 
    }




}
