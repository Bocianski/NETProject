namespace Forum.Models
{
    public class Thread
    {
        public int Id { get; set; }
        public virtual required ICollection<Post> Posts { get; set;}
    }
}
