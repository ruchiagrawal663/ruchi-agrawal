using System;
using System.ComponentModel.DataAnnotations;
namespace ApexRestaurant.Mvc.Models
 { 
     public class MealsViewModel
     { 
         [Key]
         [ScaffoldColumn(false)]
         public int Meal_Id { get; set; }
         [Required]
         [StringLength(100)]
         public DateTime Date_of_Meal { get; set; } 
         public string Cost_of_Meal { get; set; }
        public string CreatedBy { get; set; }
        [ScaffoldColumn(false)]
        public DateTime CreatedOn { get; set; }
        [ScaffoldColumn(false)]
        public string UpdatedBy { get; set; }
        [ScaffoldColumn(false)]
        public DateTime UpdatedOn { get; set; }
    }
}