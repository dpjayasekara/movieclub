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
    
    public partial class DBFeatured
    {
        public int FeaturedId { get; set; }
        public int MovieId { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual DBMovie DBMovy { get; set; }
    }
}
