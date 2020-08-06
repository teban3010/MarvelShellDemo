using System;
using System.Collections.Generic;
using MarvelShellDemo.ViewModel;
using Xamarin.Forms;

namespace MarvelShellDemo.Views
{
    public partial class CharacterPage : ContentPage
    {
        private readonly CharactersViewModel viewModel;

        public CharacterPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new CharactersViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Characters.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if(App.Current.MainPage is AppShell)
            {
                App.Current.MainPage = new AppShellMenu();
            }
            else
            {
                App.Current.MainPage = new AppShell();
            }
        }
    }
}
