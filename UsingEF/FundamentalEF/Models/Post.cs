namespace UsingEF.FundamentalEF.Models
{    
    public class Post
    {
        public int Id { get; set; }
        public string CategoryId { get; set; }
        public string AuthorId { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}