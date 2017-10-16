using System;
using System.Diagnostics;
using Xamarin.Forms;
using ToDoLibrary.Models;


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
            await Navigation.PopAsync();
        }
    }
}
