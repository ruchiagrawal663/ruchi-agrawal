using ApexRestaurant.Repository.Domain;
 using ApexRestaurant.Repository.RMenu_Item;

namespace ApexRestaurant.Services.SMenu_Item 
{ 
    public class Menu_ItemService : GenericService<Menu_items>, IMenu_ItemService 
    { 
        public Menu_ItemService(IMenu_ItemRepository menu_itemRepository) : base(menu_itemRepository) 
        {
        }
    }
} 