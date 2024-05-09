using DAL.Entities;

namespace views_practice.Models
{
    public class HomePageMV
    {
        public int PageNumber { get; set; }
        public IEnumerable<Post> Posts { get; set; }
    }
}
