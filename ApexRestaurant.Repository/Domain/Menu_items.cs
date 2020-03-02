using System;
using System.ComponentModel.DataAnnotations;
namespace ApexRestaurant.Repository.Domain
 { 
     
     public class Menu_items 
     { 
         [Key]
         public int Menu_Item_Id { get; set; }
        public string Menu_Item_Name { get; set; }
        public string Other_Details { get; set; }
         public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}