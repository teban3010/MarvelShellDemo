using System;
using System.Collections.Generic;
using MarvelShellDemo.ViewModel;
using Xamarin.Forms;

namespace MarvelShellDemo.Views
{
    public partial class MoviesPage : ContentPage
    {
        private readonly MoviesViewModel viewModel;

        public MoviesPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new MoviesViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Movies.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }

        void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            CV.ScrollTo((int)Math.Floor(e.NewValue));
        }
    }
}
