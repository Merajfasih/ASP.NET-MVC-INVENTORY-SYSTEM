//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PointofSale.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class USER
    {
        internal string username;
        internal string passward;

        public int User_id { get; set; }
        public string User_Name { get; set; }
        public string Pasward { get; set; }
        public string Role { get; set; }
        public Nullable<int> Status { get; set; }
        public string Username { get; internal set; }
    }
}
