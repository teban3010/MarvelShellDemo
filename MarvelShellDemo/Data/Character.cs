namespace MarvelShellDemo.Data
{
    public class Character
    {
        public string aliases { get; set; }
        public string api_detail_url { get; set; }
        public string birth { get; set; }
        public int count_of_issue_appearances { get; set; }
        public string date_added { get; set; }
        public string date_last_updated { get; set; }
        public string deck { get; set; }
        public string description { get; set; }
        public FirstAppearedInIssue first_appeared_in_issue { get; set; }
        public int gender { get; set; }
        public int id { get; set; }
        public Image image { get; set; }
        public string name { get; set; }
        public Origin origin { get; set; }
        public Publisher publisher { get; set; }
        public string real_name { get; set; }
        public string site_detail_url { get; set; }
    }

    public class FirstAppearedInIssue
    {
        public string api_detail_url { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string issue_number { get; set; }
    }

    public class Image
    {
        public string icon_url { get; set; }
        public string medium_url { get; set; }
        public string screen_url { get; set; }
        public string screen_large_url { get; set; }
        public string small_url { get; set; }
        public string super_url { get; set; }
        public string thumb_url { get; set; }
        public string tiny_url { get; set; }
        public string original_url { get; set; }
        public string image_tags { get; set; }
    }

    public class Origin
    {
        public string api_detail_url { get; set; }
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Publisher
    {
        public string api_detail_url { get; set; }
        public int id { get; set; }
        public string name { get; set; }
    }
}
