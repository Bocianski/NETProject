namespace Forum.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? PostTitle { get; set; }
        public string? PostMessage { get; set; }
        public DateTime? PostedDate { get; set; }
    }
}
