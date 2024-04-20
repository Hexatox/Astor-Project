namespace Models.Entities
{
    public class PostCatigory
    {
        public int PostId { get; set; }
        public Post Post { get; set; }
        
        public int CatigoryId { get; set; } 
        public Catigory Catigory { get; set; }
    }
}
