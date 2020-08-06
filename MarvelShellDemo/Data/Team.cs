using System;
namespace MarvelShellDemo.Data
{
    public class Team
    {
        public string aliases { get; set; }
        public string api_detail_url { get; set; }
        public int count_of_isssue_appearances { get; set; }
        public int count_of_team_members { get; set; }
        public string date_added { get; set; }
        public string date_last_updated { get; set; }
        public string deck { get; set; }
        public string description { get; set; }
        public Issue first_appeared_in_issue { get; set; }
        public int id { get; set; }
        public Image image { get; set; }
        public string name { get; set; }
        public Publisher publisher { get; set; }
        public string site_detail_url { get; set; }
    }
}
