using System.Collections.Generic;

namespace MarvelShellDemo.Data
{
    public class Movie
    {
        public string api_detail_url { get; set; }
        public string box_office_revenue { get; set; }
        public string budget { get; set; }
        public string date_added { get; set; }
        public string date_last_updated { get; set; }
        public string deck { get; set; }
        public string description { get; set; }
        public object distributor { get; set; }
        public object has_staff_review { get; set; }
        public int id { get; set; }
        public Image image { get; set; }
        public string name { get; set; }
        public List<Producer> producers { get; set; }
        public string rating { get; set; }
        public string release_date { get; set; }
        public string runtime { get; set; }
        public string site_detail_url { get; set; }
        public List<Studio> studios { get; set; }
        public string total_revenue { get; set; }
        public List<Writer> writers { get; set; }
    }

    public class Producer
    {
        public string api_detail_url { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string site_detail_url { get; set; }
    }

    public class Studio
    {
        public string api_detail_url { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string site_detail_url { get; set; }
    }

    public class Writer
    {
        public string api_detail_url { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string site_detail_url { get; set; }
    }
}
