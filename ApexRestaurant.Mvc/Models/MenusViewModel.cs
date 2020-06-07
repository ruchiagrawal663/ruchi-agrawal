using System;
using System.ComponentModel.DataAnnotations;
namespace ApexRestaurant.Mvc.Models
 { 
     public class MenusViewModel 
     { 
         [Key]
         [ScaffoldColumn(false)]
         public int Id { get; set; }
         [Required]
         [StringLength(100)]
        public string Menu_Name { get; set; }
        public DateTime Available_Date_From { get; set; }
        public DateTime Available_Date_To { get; set; }
         public bool IsActive { get; set; }
         [ScaffoldColumn(false)]
        public string CreatedBy { get; set; }
        [ScaffoldColumn(false)]
        public DateTime CreatedOn { get; set; }
        [ScaffoldColumn(false)]
        public string UpdatedBy { get; set; }
        [ScaffoldColumn(false)]
        public DateTime UpdatedOn { get; set; }
    }
}