using MyWhiskyApp.Models;
using MyWhiskyApp.ViewModels;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyWhiskyApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            var itemDetailsContext = (ItemDetailViewModel)BindingContext;
            var whiskyItemId = int.Parse(itemDetailsContext.Id);
            await DeleteItemId(whiskyItemId);
        }

        private async Task DeleteItemId(int whiskyItemId)
        {
            await WhiskyService.RemoveWhiskyItem(whiskyItemId);
            await Shell.Current.GoToAsync($"//{nameof(ItemsPage)}");
        }
    }
}