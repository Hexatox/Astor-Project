namespace DAL.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        
        public int PostId { get; set; }
        public Post Post { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { set; get; }


        public DateTime CommentDate { get; set; }
        public string Content {  set; get; }
    }
}
