using System;
using System.ComponentModel.DataAnnotations;
namespace ApexRestaurant.Repository.Domain
 { 
     public class Ref_Staff_Roles 
     { 
         [Key]
         public int Staff_Roles_Code_Id { get; set; }
        public string Staff_Role_Description { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}