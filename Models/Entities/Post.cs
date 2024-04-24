﻿using Utility.Enum;

namespace Models.Entities
{
    public class Post
    {
        PostType PostType { get; set; }
        public int PostId { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Samary { get; set; }
        public string Content { get; set; }
        // navigate How Wrote the post
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime PostDate { get; set; }
        public int TotalLikes { get; set; }

        public bool IsAviable {  get; set; }

        // navigate Likes
        public IQueryable<Like> Likes {  get; set; } 

        // navigate post catigories
        public IQueryable <Catigory> Catigories { get; set; }


        // navigate all  Comments post
        public IQueryable <Comment> Comments { get; set; }
    }
}