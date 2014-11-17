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
    
    public partial class Player
    {
        public Player()
        {
            this.Goals = new HashSet<Goal>();
        }

        public int PlayerId { get; set; }
        [Required]
        public string PlayerName { get; set; }
        [Required]
        public string PlayerSurname { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> BirthdayDate { get; set; }
        public int TeamId { get; set; }
        public Nullable<int> AddressId { get; set; }
        public string PlayerPhone { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<Goal> Goals { get; set; }
        public virtual Team Team { get; set; }
        public override string ToString()
        {
            return this.PlayerName + " " + this.PlayerSurname;
        }
    }
}
