using ApexRestaurant.Repository.Domain;
 using ApexRestaurant.Services.SMenu; 
 using Microsoft.AspNetCore.Mvc;
namespace ApexRestaurant.Api.Controller
 { 
     [Route("api/Menu")]
      public class MenuController : ControllerBase 
      {
        private readonly IMenuService _MenuService;
        public MenuController(IMenuService MenuService)
         { 
             _MenuService = MenuService;
         }
         [HttpGet] [Route("{id}")]
          public IActionResult Get([FromRoute] int id) 
         { 
             var Menu = _MenuService.GetById(id);
             if (Menu == null) return NotFound();
             return Ok(Menu);
         }
            [HttpGet] [Route("")] public IActionResult GetAll() 
            { 
                var Menus = _MenuService.GetAll(); 
                return Ok(Menus);
             }
            [HttpPost] 
            [Route("")]
             public IActionResult Post([FromBody] Menus model)
              {
                   _MenuService.Insert(model);
            return Ok();
}
            [HttpPut]
             [Route("")] 
             public IActionResult Put([FromBody] Menus model) 
             {
                  _MenuService.Update(model); 
                 return Ok();
              }
              [HttpDelete] 
              [Route("")]
               public IActionResult Delete([FromBody] Menus model)
                { 
                    _MenuService.Delete(model);
                     return Ok(); }
                }
} 