//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace FC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admin
    {
        public int AdminId { get; set; }
        [Required]
        public string AdminLogin { get; set; }
         [Required]
        public string Password { get; set; }
    }
}
