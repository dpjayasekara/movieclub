﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieClub.Models
{
    public class UserDetails
    {
        public int UserId { get; set; }
        [MaxLength(80)]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RetypePassword { get; set; }
        [Url]
        public string PhotoURL { get; set; }
        public int EmployeeId { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime JoinedDate { get; set; }

    }
}