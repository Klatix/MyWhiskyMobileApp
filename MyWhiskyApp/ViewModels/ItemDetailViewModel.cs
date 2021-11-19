using MvvmHelpers.Commands;
using MyWhiskyApp.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyWhiskyApp.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string text;
        private string description;
        private string imageName;

        public string Id { get; set; }



        public string ImageName
        {
            get => imageName;
            set => SetProperty(ref imageName, value);
        }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var items = await WhiskyService.GetWhiskyItems();
                var item = items.Where(i => i.Id.ToString() == itemId).First();
                Id = item.Id.ToString();
                Text = item.Name;
                Description = item.Description;
                ImageName = item.ImageName;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
