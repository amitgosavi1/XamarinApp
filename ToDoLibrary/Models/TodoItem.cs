﻿using System;
using System.Windows.Input;
using SQLite;
using Xamarin.Forms;

namespace ToDoLibrary.Models
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool Done { get; set; }

        public ICommand DeleteCommand { get; private set; }


        public TodoItem(){
            DeleteCommand = new Command (DeleteImageTapped);
        }

        void DeleteImageTapped()
        {
            var todo = this;
            App.DBManager.DeleteItemAsync(todo);
        }

    }
}
