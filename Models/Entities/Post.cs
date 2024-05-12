using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Enum;

namespace DAL.Entities
{
    public class Post
    {
        public PostType PostType { get; set; }
        public int PostId { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Samary { get; set; }
        public string Content { get; set; }
        // navigate How Wrote the post
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime PostDate { get; set; }
        public int TotalLikes
        {
            get { return totalLikes(); }
            set { }
        }
        public bool IsAviable {  get; set; }

        // navigate Likes
        public ICollection<Like> Likes { get; set; } = new List<Like>();

        // navigate post catigories
        public ICollection<Catigory> Catigories { get; set; } = new List<Catigory>();


        // navigate all  Comments post
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        private int totalLikes()
        {
            int count = Likes == null ? 0 : Likes.Count();
            return count;
        }
        public Post()
        {
            
        }
    }
}
