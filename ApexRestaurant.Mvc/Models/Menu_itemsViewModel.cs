using System;
using System.ComponentModel.DataAnnotations;
namespace ApexRestaurant.Mvc.Models
 { 
     
     public class Menu_itemsViewModel
     { 
         [Key]
         [ScaffoldColumn(false)]
         public int Menu_Item_Id { get; set; }
         [Required]
         [StringLength(100)]
        public string Menu_Item_Name { get; set; }
        public string Other_Details { get; set; }
         public string CreatedBy { get; set; }
         [ScaffoldColumn(false)]
        public DateTime CreatedOn { get; set; }
        [ScaffoldColumn(false)]
        public string UpdatedBy { get; set; }
        [ScaffoldColumn(false)]
        public DateTime UpdatedOn { get; set; }
    }
}