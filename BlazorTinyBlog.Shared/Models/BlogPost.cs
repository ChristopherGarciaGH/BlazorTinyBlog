﻿namespace BlazorTinyBlog.Shared.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime? PublisedDate { get; set; }
        public bool IsPublished { get; set; }
    }
}
