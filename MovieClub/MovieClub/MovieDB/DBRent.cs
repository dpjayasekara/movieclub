//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieClub.MovieDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class DBRent
    {
        public int RentId { get; set; }
        public Nullable<int> MovieId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<System.DateTime> BorrowedDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public int Returned { get; set; }
        public Nullable<System.DateTime> ReturnedDate { get; set; }
    }
}
