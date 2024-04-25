using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Messege
    {
        public int MessegeID { get; set; }
        public string UserID { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime Date { get; set; }
        public string Fullname {  get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
