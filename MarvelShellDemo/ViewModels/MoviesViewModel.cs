using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Input;
using MarvelShellDemo.Data;
using MvvmHelpers;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace MarvelShellDemo.ViewModel
{
    public class MoviesViewModel : BaseViewModel
    {
        private ObservableCollection<Movie> movies;

        public MoviesViewModel()
        {
            Title = "Movies";

            Movies = new ObservableCollection<Movie>();
        }

        public ICommand LoadItemsCommand => new Command(ExecuteLoadItemsCommand);

        public ObservableCollection<Movie> Movies
        {
            get { return movies; }
            set { this.SetProperty(ref movies, value); }
        }

        private void ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Movies.Clear();

                var jsonFileName = "movies.json";
                var teamsList = new List<Movie>();

                var assembly = typeof(Views.TeamsPage).GetTypeInfo().Assembly;
                var stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");

                using (var reader = new System.IO.StreamReader(stream))
                {
                    teamsList = JsonConvert.DeserializeObject<List<Movie>>(reader.ReadToEnd());
                }

                teamsList.ForEach(movie =>
                {
                    Movies.Add(movie);
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
