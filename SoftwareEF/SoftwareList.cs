using System;
using System.ComponentModel.DataAnnotations;

namespace SoftwareEF
{
    public class SoftwareList
    {
        [Key] public int SoftwareId { get; set; } 
        public int ParentId { get; set; }
        public string Name { get; set; }   
        public string Description { get; set; } 
        public DateTime CreatedDate { get; set; } 
        public string CreatedUser { get; set; } 
        public int? IsDeleted { get; set; }
    }
}
