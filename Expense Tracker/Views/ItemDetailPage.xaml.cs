using Expense_Tracker.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Expense_Tracker.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}