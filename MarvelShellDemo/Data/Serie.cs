using System;
namespace MarvelShellDemo.Data
{
    public class Serie
    {
        public string aliases { get; set; }
        public string api_detail_url { get; set; }
        public int count_of_episodes { get; set; }
        public string date_added { get; set; }
        public string date_last_updated { get; set; }
        public string deck { get; set; }
        public string description { get; set; }
        public Episode first_episode { get; set; }
        public int id { get; set; }
        public Image image { get; set; }
        public Episode last_episode { get; set; }
        public string name { get; set; }
        public Publisher publisher { get; set; }
        public string site_detail_url { get; set; }
        public string start_year { get; set; }
    }

    public class Episode
    {
        public string api_detail_url { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string episode_number { get; set; }
    }
}
