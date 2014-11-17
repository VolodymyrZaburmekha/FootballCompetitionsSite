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
    
    public partial class Coach
    {
        public int CoachId { get; set; }
        [Required]
        public string CoachName { get; set; }
        [Required]
        public string CoachSurname { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> BirthdayDate { get; set; }
        public Nullable<int> AddressId { get; set; }
        public string CoachPhone { get; set; }
        public Nullable<int> TeamId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Team Team { get; set; }
    }
}
