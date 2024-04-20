using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Bio {  get; set; }
        public string ProfilePhoto { get; set; }

        //navigation Propriry for his Sociel Media Links
        public IQueryable <SocielMediaUser> Links { get; set; }
        

    }
    

}
