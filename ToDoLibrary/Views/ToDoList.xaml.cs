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
        public List<TodoItem> allItems;  
        ListItemModel items;  

        public ToDoList() {
            InitializeComponent();
           
            MessagingCenter.Subscribe<TodoItem>(this, "", (sender) => {
                ReloadList();
            });
        }

        /// <summary>
        /// Get the list items and refresh list.
        /// </summary>
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ReloadList();
        }

        private async void ReloadList(){
            items = new ListItemModel(await App.DBManager.getItemList());
            listItems.ItemsSource = items.Items;
        }
    }
}
