using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UITestSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReturnPage : ContentPage
    {
        public ReturnPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BtnReturn.Clicked += ReturnExecute;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            BtnReturn.Clicked -= ReturnExecute;
        }

        void ReturnExecute(object sender, EventArgs e) => Navigation.PopAsync();
    }
}