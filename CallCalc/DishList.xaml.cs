﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CallCalc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DishList : ContentPage
    {
        public DishList()
        {
            InitializeComponent();
            Title = "Список блюд";
        }
        private async void FriedEggClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            await Navigation.PushAsync(new DishesPage.DishesPage());
        }
    }
}