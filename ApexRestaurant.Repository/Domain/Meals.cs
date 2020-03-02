using System;
using System.ComponentModel.DataAnnotations;
namespace ApexRestaurant.Repository.Domain
 { 
     public class Meals 
     { 
         [Key]
         public int Meal_Id { get; set; }
         public DateTime Date_of_Meal { get; set; } 
         public string Cost_of_Meal { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}