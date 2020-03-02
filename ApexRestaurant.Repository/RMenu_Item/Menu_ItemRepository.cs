using ApexRestaurant.Repository.Domain;
namespace ApexRestaurant.Repository.RMenu_Item 
{ 
    public class Menu_ItemRepository : GenericRepository<Menu_items>, IMenu_ItemRepository
     {
          public  Menu_ItemRepository(RestaurantContext dbContext) 
          {
               DbContext = dbContext;
          } 
     } 
} 