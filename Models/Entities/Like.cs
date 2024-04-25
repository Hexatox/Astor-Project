namespace DAL.Entities
{
    public class Like
    {
        // those are Primary key and Foriegn key
        public int PostId { get; set; }
        public Post Post { get; set; }  
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }   
    }
}
