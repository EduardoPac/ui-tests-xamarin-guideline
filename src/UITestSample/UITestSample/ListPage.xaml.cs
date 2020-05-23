using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UITestSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ObservableCollection<ItemList> Items { get; set; }

        ItemList _selected;

        public ItemList SelectedItem
        {
            get => _selected;
            set
            {
                _selected = value;
                if (value != null)
                    SelectedItemExecute(value);
            }
        }

        public ListPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadItens();
        }

        void LoadItens()
        {
            var items = new List<ItemList>
            {
                ItemList.New().SetItem("Item 1", "item de listagem 1", isFirst: true),
                ItemList.New().SetItem("Item 2", "item de listagem 2"),
                ItemList.New().SetItem("Item 3", "item de listagem 3"),
                ItemList.New().SetItem("Item 4", "item de listagem 4"),
                ItemList.New().SetItem("Item 5", "item de listagem 5"),
                ItemList.New().SetItem("Item 6", "item de listagem 6", isFirst: false, isLast: true)
            };

            Items = new ObservableCollection<ItemList>(items);
            OnPropertyChanged(nameof(Items));
        }

        async void SelectedItemExecute(ItemList value)
        {
            await DisplayAlert("Item", value.Title, "Ok");
            SelectedItem = null;
            OnPropertyChanged(nameof(SelectedItem));
        }
    }

    public class ItemList
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsFirst { get; set; }
        public bool IsLast { get; set; }

        public static ItemList New() => new ItemList();

        public ItemList SetItem(string title, string description, bool isFirst = false, bool isLast = false)
        {
            Title = title;
            Description = description;
            IsFirst = isFirst;
            IsLast = isLast;

            return this;
        }
    }
}