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
    
    public partial class DBCategory
    {
        public DBCategory()
        {
            this.DBMovieToCategories = new HashSet<DBMovieToCategory>();
        }
    
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    
        public virtual ICollection<DBMovieToCategory> DBMovieToCategories { get; set; }
    }
}
