namespace DAL.Entities
{
    public class Catigory
    {
        public int CatigoryId { get; set; }
        public string CatigoryName { get; set; }
        //navigate all post of one Catigory
        public IQueryable <Post> Posts { get; set; }
    }
}
