﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;
using MovieClub.CustomAttributes;

namespace MovieClub.Operations
{
    public class UserOperations
    {

        public static bool IsAuthenticated(string solusername)
        {
            MovieDB.MovieClubDBE db = new MovieDB.MovieClubDBE();
            int isauth = db.DBUsers.Count(u => u.UserName == solusername);
            if (isauth == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        public static Models.UserDetails GetCurrentUser()
        {
            string username = HttpContext.Current.User.Identity.Name;
            MovieDB.MovieClubDBE db = new MovieDB.MovieClubDBE();

            var dbuser = db.DBUsers.Where(u => u.UserName == username).First();
            var dbadmin = db.DBAdmins.Count(a => a.UserId == dbuser.UserId);
            Models.UserDetails currentuser = new Models.UserDetails();

            currentuser.UserId = dbuser.UserId;
            if (dbadmin == 1)
            {
                currentuser.IsAdmin = true;
            }
            else
            {
                currentuser.IsAdmin = false;
            }
            currentuser.UserName = username;
            currentuser.PhotoURL = dbuser.PhotoURL;

            return currentuser;
        }

        public static bool IsAdmin()
        {
            return MovieClub.Operations.UserOperations.GetCurrentUser().IsAdmin;
        }
    }
}