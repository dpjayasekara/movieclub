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
    
    public partial class DBInboxMessage
    {
        public int MessageId { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual DBUser DBUser { get; set; }
    }
}
