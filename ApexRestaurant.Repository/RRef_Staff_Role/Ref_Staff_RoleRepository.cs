using ApexRestaurant.Repository.Domain;
namespace ApexRestaurant.Repository.RRef_Staff_Role
{ 
    public class Ref_Staff_RoleRepository : GenericRepository<Ref_Staff_Roles>,IRef_Staff_RoleRepository
     {
          public Ref_Staff_RoleRepository(RestaurantContext dbContext) 
          {
               DbContext = dbContext;
          } 
     } 
} 