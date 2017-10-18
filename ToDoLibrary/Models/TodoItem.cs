using System;
using System.Threading.Tasks;
using System.Windows.Input;
using SQLite;
using Xamarin.Forms;
using System.ComponentModel;


namespace ToDoLibrary.Models
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool Done { get; set; }

        /// <summary>
        /// Ignore below mentioned properties for database storing
        /// </summary>
        /// <value>The delete command.</value>
        [Ignore]
        public ICommand DeleteCommand { get; private set; }
       

        public TodoItem(){
            DeleteCommand = new Command (DeleteImageTapped);
        }

        async void DeleteImageTapped()
        {
            var todo = this;
            var name = todo.Name;
            await App.DBManager.DeleteItemAsync(todo);
            MessagingCenter.Send<TodoItem>(this,"");
        }
    }
}
