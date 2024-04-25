using Microsoft.AspNetCore.Identity;
using DAL.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ApplicationUser : IdentityUser // Inherite From `IdentityUser` this Contain All Proprity About Identity Like ID ,  PassWord , Email ... 
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Bio {  get; set; }
        public string ProfilePhoto { get; set; }
        public bool isBlocked {  get; set; }

        //navigation Propriry for his Sociel Media Links
        public IQueryable <SocielMediaUser> Links { get; set; }

        // navigation to reprisent the all User Reviews 
        public IQueryable <UserReview> Reviews { get; set; } 


    }
}
