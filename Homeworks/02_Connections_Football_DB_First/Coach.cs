//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _02_Connections_Football_DB_First
{
    using System;
    using System.Collections.Generic;
    
    public partial class Coach
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Team_Id { get; set; }
    
        public virtual Team Team { get; set; }
    }
}
