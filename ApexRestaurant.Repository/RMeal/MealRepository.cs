using ApexRestaurant.Repository.Domain;
namespace ApexRestaurant.Repository.RMeal 
{ 
    public class MealRepository : GenericRepository<Meals>, IMealRepository
     {
          public MealRepository(RestaurantContext dbContext) 
          {
               DbContext = dbContext;
          } 
     } 
} 