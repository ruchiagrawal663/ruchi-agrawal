using ApexRestaurant.Repository.Domain;
 using ApexRestaurant.Repository.RMenu;

namespace ApexRestaurant.Services.SMenu
{ 
    public class MenuService : GenericService<Menus>, IMenuService 
    { 
        public MenuService(IMenuRepository menuRepository) : base(menuRepository) 
        {
        }
    }
} 