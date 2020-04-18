using ApexRestaurant.Repository.Domain;
 using ApexRestaurant.Services.SMenu_Item; 
 using Microsoft.AspNetCore.Mvc;
namespace ApexRestaurant.Api.Controller
 { 
     [Route("api/Menu_Item")]
      public class Menu_ItemController : ControllerBase 
      {
        private readonly IMenu_ItemService _Menu_ItemService;
        public Menu_ItemController(IMenu_ItemService Menu_ItemService)
         { 
             _Menu_ItemService = Menu_ItemService; 
         }
         [HttpGet] [Route("{id}")]
          public IActionResult Get([FromRoute] int id) 
         { 
             var Menu_Item = _Menu_ItemService.GetById(id);
             if (Menu_Item == null) return NotFound();
             return Ok(Menu_Item);
         }
            [HttpGet] [Route("")] public IActionResult GetAll() 
            { 
                var Menu_Items = _Menu_ItemService.GetAll(); 
                return Ok(Menu_Items);
             }
            [HttpPost] 
            [Route("")]
             public IActionResult Post([FromBody] Menu_items model)
              {
                   _Menu_ItemService.Insert(model);
            return Ok();
}
            [HttpPut]
             [Route("")] 
             public IActionResult Put([FromBody] Menu_items model) 
             {
                  _Menu_ItemService.Update(model); 
                 return Ok();
              }
              [HttpDelete] 
              
              [Route("")]
               public IActionResult Delete([FromBody] Menu_items model)
                { 
                    _Menu_ItemService.Delete(model);
                     return Ok(); }
                }
} 