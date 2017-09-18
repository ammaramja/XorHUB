//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XorHub
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Solution
    {
        [Required]
        public decimal SolutionId { get; set; }

        public Nullable<decimal> AssignmentId { get; set; }
        public string Username { get; set; }
        public string Stat { get; set; }
        public System.DateTime UploadedOn { get; set; }
        public string Document { get; set; }
        public string Comment { get; set; }
    
        public virtual Assignment Assignment { get; set; }
        public virtual LoginInfo LoginInfo { get; set; }
    }
}