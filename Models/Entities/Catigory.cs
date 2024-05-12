using System.Collections.Generic;
using System.Linq;

namespace DAL.Entities
{
    public class Catigory
    {
        public Catigory()
        {
            
        }
        public int CatigoryId { get; set; }
        public string CatigoryName { get; set; }
        //navigate all post of one Catigory
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
