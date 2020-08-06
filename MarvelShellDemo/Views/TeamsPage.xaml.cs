using MarvelShellDemo.ViewModel;
using Xamarin.Forms;

namespace MarvelShellDemo.Views
{
    public partial class TeamsPage : ContentPage
    {
        private readonly TeamsViewModel viewModel;

        public TeamsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new TeamsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Teams.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
