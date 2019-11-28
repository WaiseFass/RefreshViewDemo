using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace RefreshView
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class GridWrongMargin 
    {
        private readonly ViewModel _viewModel;
        public GridWrongMargin()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _viewModel.InitializeAsync();
        }
    }

    public class ViewModel
    {

        public ViewModel()
        {
            Items = new ObservableCollection<string>();
        }
        public ObservableCollection<string> Items { get; set; }

        public async Task InitializeAsync()
        {
            
            await Task.Delay(TimeSpan.FromSeconds(2));
            Items.Clear();
            Items.Add("Item 1");
            Items.Add("Item 2");
            Items.Add("Item 3");
            Items.Add("Item 4");
            Items.Add("Item 5");
            Items.Add("Item 6");
            Items.Add("Item 7");
        }

    }
}
