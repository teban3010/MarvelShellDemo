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
    public class CharactersViewModel : BaseViewModel
    {
        private ObservableCollection<Character> characters;

        public CharactersViewModel()
        {
            Title = "Characters";

            Characters = new ObservableCollection<Character>();
        }

        public ICommand LoadItemsCommand => new Command(ExecuteLoadItemsCommand);

        public ObservableCollection<Character> Characters
        {
            get { return characters; }
            set { this.SetProperty(ref characters, value); }
        }

        private void ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Characters.Clear();

                var jsonFileName = "characters.json";
                var teamsList = new List<Character>();

                var assembly = typeof(Views.TeamsPage).GetTypeInfo().Assembly;
                var stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");

                using (var reader = new System.IO.StreamReader(stream))
                {
                    teamsList = JsonConvert.DeserializeObject<List<Character>>(reader.ReadToEnd());
                }

                teamsList.ForEach(character =>
                {
                    Characters.Add(character);
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
