using System;
using System.ComponentModel.DataAnnotations;
namespace ApexRestaurant.Mvc.Models
 { 
     public class Ref_Staff_RolesViewModel
     { 
         [Key]
         [ScaffoldColumn(false)]
         public int Staff_Roles_Code_Id { get; set; }
         [Required]
         [StringLength(100)]
        
        public string Staff_Role_Description { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        [ScaffoldColumn(false)]
        public DateTime CreatedOn { get; set; }
        [ScaffoldColumn(false)]
        public string UpdatedBy { get; set; }
        [ScaffoldColumn(false)]
        public DateTime UpdatedOn { get; set; }
    }
}