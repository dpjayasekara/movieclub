﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MovieClubDBE : DbContext
    {
        public MovieClubDBE()
            : base("name=MovieClubDBE")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<DBCategory> DBCategories { get; set; }
        public DbSet<DBFavorite> DBFavorites { get; set; }
        public DbSet<DBMovieSuggestion> DBMovieSuggestions { get; set; }
        public DbSet<DBMovieToCategory> DBMovieToCategories { get; set; }
        public DbSet<DBRent> DBRents { get; set; }
        public DbSet<DBReservation> DBReservations { get; set; }
        public DbSet<DBAdmin> DBAdmins { get; set; }
        public DbSet<DBMovie> DBMovies { get; set; }
        public DbSet<DBUser> DBUsers { get; set; }
        public DbSet<DBRating> DBRatings { get; set; }
        public DbSet<DBWatchList> DBWatchLists { get; set; }
        public DbSet<DBRecommendation> DBRecommendations { get; set; }
    }
}
