﻿namespace Blog.Data.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public Post Post { get; set; }
        public ApplicationUser Author { get; set; }
        public string Content { get; set; }
        public Comment Parent { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}
