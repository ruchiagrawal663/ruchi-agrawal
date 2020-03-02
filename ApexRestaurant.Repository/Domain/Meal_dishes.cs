using System;
using System.ComponentModel.DataAnnotations;
namespace ApexRestaurant.Repository.Domain
 { 
     public class Meal_Dishes 
     { 
         [Key]
         public int Meal_Dishes_Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}