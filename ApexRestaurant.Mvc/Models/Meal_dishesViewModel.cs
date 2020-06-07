using System;
using System.ComponentModel.DataAnnotations;
namespace ApexRestaurant.Mvc.Models
 { 
     public class Meal_DishesViewModel
     { 
         [Key]
         [ScaffoldColumn(false)]
         public int Meal_Dishes_Id { get; set; }
         [Required]
         [StringLength(100)]
        public string CreatedBy { get; set; }
        [ScaffoldColumn(false)]
        public DateTime CreatedOn { get; set; }
        [ScaffoldColumn(false)]
        public string UpdatedBy { get; set; }
        [ScaffoldColumn(false)]
        public DateTime UpdatedOn { get; set; }
    }
}