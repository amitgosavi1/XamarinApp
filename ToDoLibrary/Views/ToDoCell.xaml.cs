using Xamarin.Forms;


namespace ToDoLibrary.Views
{

    public interface IToDoInterface
    {
        void DeleteItem();
    }

    public partial class ToDoCell : ViewCell
    {
        public ToDoCell()
        {
            InitializeComponent();
        }

    }
}
