using ApexRestaurant.Repository.Domain;
 using ApexRestaurant.Repository.RMeal_Dish;

namespace ApexRestaurant.Services.SMeal_Dish 
{ 
    public class Meal_DishService : GenericService<Meal_Dishes>, IMeal_DishService 
    { 
        public Meal_DishService(IMeal_DishRepository meal_dishRepository) : base(meal_dishRepository) 
        {
        }
    }
} 