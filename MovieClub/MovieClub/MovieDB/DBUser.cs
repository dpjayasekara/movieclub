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
    
    public partial class DBUser
    {
        public DBUser()
        {
            this.DBEmployeePendingPayments = new HashSet<DBEmployeePendingPayment>();
            this.DBFavorites = new HashSet<DBFavorite>();
            this.DBInboxMessages = new HashSet<DBInboxMessage>();
            this.DBMovieSuggestions = new HashSet<DBMovieSuggestion>();
            this.DBPaymentHistories = new HashSet<DBPaymentHistory>();
            this.DBPaymentsDues = new HashSet<DBPaymentsDue>();
            this.DBRatings = new HashSet<DBRating>();
            this.DBRents = new HashSet<DBRent>();
            this.DBReservations = new HashSet<DBReservation>();
            this.DBWatchLists = new HashSet<DBWatchList>();
            this.DBSuggestions = new HashSet<DBSuggestion>();
        }
    
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PhotoURL { get; set; }
        public Nullable<System.DateTime> AccountCreatedDate { get; set; }
        public int EmpId { get; set; }
        public string Email { get; set; }
    
        public virtual DBAdmin DBAdmin { get; set; }
        public virtual ICollection<DBEmployeePendingPayment> DBEmployeePendingPayments { get; set; }
        public virtual ICollection<DBFavorite> DBFavorites { get; set; }
        public virtual ICollection<DBInboxMessage> DBInboxMessages { get; set; }
        public virtual ICollection<DBMovieSuggestion> DBMovieSuggestions { get; set; }
        public virtual ICollection<DBPaymentHistory> DBPaymentHistories { get; set; }
        public virtual ICollection<DBPaymentsDue> DBPaymentsDues { get; set; }
        public virtual ICollection<DBRating> DBRatings { get; set; }
        public virtual ICollection<DBRent> DBRents { get; set; }
        public virtual ICollection<DBReservation> DBReservations { get; set; }
        public virtual DBUser DBUsers1 { get; set; }
        public virtual DBUser DBUser1 { get; set; }
        public virtual ICollection<DBWatchList> DBWatchLists { get; set; }
        public virtual ICollection<DBSuggestion> DBSuggestions { get; set; }
    }
}
