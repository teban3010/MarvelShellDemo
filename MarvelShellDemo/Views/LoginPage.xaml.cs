using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MarvelShellDemo.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            App.Current.MainPage = new LoginMaterialPage();
        }
    }
}
