using System;
using Xamarin.Forms;

namespace UITestSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BtnSample.Clicked += SampleExecute;
            BtnReturn.Clicked += ReturnExecute;
            BtnList.Clicked += ListExecute;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            BtnSample.Clicked -= SampleExecute;
            BtnReturn.Clicked -= ReturnExecute;
            BtnList.Clicked -= ListExecute;
        }

        void ListExecute(object sender, EventArgs e) => Navigation.PushAsync(new ListPage());

        void ReturnExecute(object sender, EventArgs e) => Navigation.PushAsync(new ReturnPage());

        void SampleExecute(object sender, EventArgs e) => Navigation.PushAsync(new SimplePage());
    }
}