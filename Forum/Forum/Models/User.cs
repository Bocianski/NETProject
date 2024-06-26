﻿namespace Forum.Models
{
    public class User
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
        public virtual ICollection<Post>? Posts { get; set;}

    }
}
