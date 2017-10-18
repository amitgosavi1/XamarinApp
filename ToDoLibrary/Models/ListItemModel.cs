using System.Collections.Generic;
using ToDoLibrary.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ToDoLibrary.Views
{
    public class ListItemModel :  INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;  
        public ObservableCollection<TodoItem> _items;


        //#commands
        public ICommand AddItemCommand { get; private set; }
        public ICommand UpdateItemCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }

        public ObservableCollection<TodoItem> Items  
        {  
             get { return _items; }  
            set { _items = value; OnPropertyChanged("Items"); }  
        }


        protected virtual void OnPropertyChanged(string propertyName)  
        {  
            if (PropertyChanged == null)  
                return;  
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));  
        }  

        public ListItemModel(List<TodoItem> itemList)
        {
            Items = new ObservableCollection<TodoItem>();  
            foreach (TodoItem itm in itemList)  
            {  
                Items.Add(itm);  
            }  

           
        }

        public ListItemModel(){

            InitializeModel();
            AddItemCommand = new Command(AddNewItem);
            UpdateItemCommand = new Command<TodoItem>(UpdateItem);
            DeleteCommand = new Command<TodoItem>(DeleteImageTapped);

        }

         private async void  InitializeModel()
        {
            List<TodoItem> objs = await App.DBManager.getItemList();
            Items = new ObservableCollection<TodoItem>();  


            foreach (TodoItem itm in objs)  
            {  
                Items.Add(itm);  
            }  
           
        }

        /// <summary>
        /// Navigate user to details screen to add new entry
        /// </summary>
        async void AddNewItem()
        {
            
            await Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new ToDoDetails
            {
                BindingContext = new TodoItem()
            });
        }

        /// <summary>
        /// Updates the item.
        /// </summary>
        async void UpdateItem(TodoItem item)
        {

            await Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new ToDoDetails
            {
                BindingContext = item
            });
        }

        void DeleteImageTapped(TodoItem todo)
        {
            App.DBManager.DeleteItemAsync(todo);
        }


    }
}
