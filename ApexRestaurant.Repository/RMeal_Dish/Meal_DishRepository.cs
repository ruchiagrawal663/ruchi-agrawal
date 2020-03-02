using ApexRestaurant.Repository.Domain;
namespace ApexRestaurant.Repository.RMeal_Dish 
{ 
    public class Meal_DishRepository : GenericRepository<Meal_Dishes>, IMeal_DishRepository
     {
          public Meal_DishRepository(RestaurantContext dbContext) 
          {
               DbContext = dbContext;
          } 
     } 
} 