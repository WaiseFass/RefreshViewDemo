using System.ComponentModel;
using Xamarin.Forms;

namespace RefreshView
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class GridRightMargin : ContentPage
    {
        private readonly ViewModel _viewModel;
        public GridRightMargin()
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
}
