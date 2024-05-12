using Microsoft.AspNetCore.Identity;
using DAL.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL.Entities
{
    public class ApplicationUser : IdentityUser // Inherite From `IdentityUser` this Contain All Proprity About Identity Like ID ,  PassWord , Email ... 
    {
        public ApplicationUser()
        {
            
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Bio {  get; set; }
        public ProfilePhoto ProfilePhoto { get; set; } // own Type
        public bool isBlocked {  get; set; }
        public DateTime CreateDate { get; set; }

        //navigation Propriry for his Sociel Media Links
        public ICollection<SocielMediaUser> Links { get; set; } = new List<SocielMediaUser>();

        // navigation to reprisent the all User Reviews 
        public ICollection<UserReview> Reviews { get; set; } = new List<UserReview>();

        // navigattion of User Messeges
        public ICollection<Messege> Messeges { get; set; } = new List<Messege>();
        // navigate User POSTS
        public ICollection<Post> Posts { get; set; } = new List<Post>();

        //navigate Users Commenrs
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
            
        // navigate User Likes
        public ICollection<Like> Likes { get; set; } = new List<Like>();

        // navigate User Request to be Admin 
        //public IQueryable <Request> Requests { get; set; }

        // navigate Admin Accepets for Request Users
        //public IQueryable <Request> Accepts { get; set; }


        public string getFullName()
        {
            return Firstname; 
        }

    }

    public class ProfilePhoto
    {
        public string ImageName {  get; set; }
        public string URL { get; set; }
    }

    
}
