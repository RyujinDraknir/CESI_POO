namespace CESI_POO_Ex6.Model.VideoRessource
{
    public class Video
    {
        public string Title { get; set; }
        public int Views { get; set; }
        public string Uri { get; set; }

        public Video(string title, int views, string uri)
        {
            Title = title;
            Views = views;
            Uri = uri;
        }

        public override string ToString()
        {
            return "Video :"
                + "\n\t" + "Title : " + Title
                + "\n\t" + "Views : " + Views
                + "\n\t" + "Uri : " + Uri;
        }
    }
}