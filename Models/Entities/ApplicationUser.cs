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
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Bio {  get; set; }
        public ProfilePhoto ProfilePhoto { get; set; } // own Type
        public bool isBlocked {  get; set; }

        //navigation Propriry for his Sociel Media Links
        public IQueryable <SocielMediaUser> Links { get; set; }

        // navigation to reprisent the all User Reviews 
        public IQueryable <UserReview> Reviews { get; set; } 

        // navigattion of User Messeges
        public IQueryable <Messege> Messeges {  get; set; }
        // navigate User POSTS
        public IQueryable <Post> Posts { get; set; }

        //navigate Users Commenrs
        public IQueryable <Comment> Comments { get; set; }

        // navigate User Likes
        public IQueryable <Like> Likes { get; set; }

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
