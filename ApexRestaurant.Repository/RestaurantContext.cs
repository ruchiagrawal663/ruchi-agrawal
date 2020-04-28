using Microsoft.EntityFrameworkCore; 
using ApexRestaurant.Repository.Domain;
namespace ApexRestaurant.Repository 
{
     public class RestaurantContext : DbContext 
     {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
            { 

            }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Meals> Meals { get; set; }
        public DbSet<Meal_Dishes> MealDishes { get; set; }
        public DbSet<Menus> Menus { get; set; }       
        public DbSet<Menu_items> MenuItems { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Ref_Staff_Roles> StaffRoles { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
             base.OnModelCreating(modelBuilder); 

        }
    }   
}