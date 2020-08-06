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
    public class TeamsViewModel : BaseViewModel
    {
        private ObservableCollection<Team> teams;

        public TeamsViewModel()
        {
            Title = "Teams";

            Teams = new ObservableCollection<Team>();
        }

        public ICommand LoadItemsCommand => new Command(ExecuteLoadItemsCommand);

        public ObservableCollection<Team> Teams
        {
            get { return teams; }
            set { this.SetProperty(ref teams, value); }
        }

        private void ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Teams.Clear();

                var jsonFileName = "teams.json";
                var teamsList = new List<Team>();

                var assembly = typeof(Views.TeamsPage).GetTypeInfo().Assembly;
                var stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");

                using (var reader = new System.IO.StreamReader(stream))
                {
                    teamsList = JsonConvert.DeserializeObject<List<Team>>(reader.ReadToEnd());
                }
                
                teamsList.ForEach(team =>
                {
                    Teams.Add(team);
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
