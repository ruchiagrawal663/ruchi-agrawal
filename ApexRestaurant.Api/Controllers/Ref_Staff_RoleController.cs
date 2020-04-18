using ApexRestaurant.Repository.Domain;
 using ApexRestaurant.Services.SRef_Staff_Role; 
 using Microsoft.AspNetCore.Mvc;
namespace ApexRestaurant.Api.Controller
 { 
     [Route("api/ref_staff_role")]
      public class Ref_Staff_RoleController : ControllerBase 
      {
        private readonly IRef_Staff_RoleService _Ref_Staff_RoleService;
        public Ref_Staff_RoleController(IRef_Staff_RoleService Ref_Staff_RoleService)
         { 
             _Ref_Staff_RoleService = Ref_Staff_RoleService; 
         }
         [HttpGet] [Route("{id}")]
          public IActionResult Get([FromRoute] int id) 
         { 
             var Ref_Staff_Role = _Ref_Staff_RoleService.GetById(id);
             if (Ref_Staff_Role == null) return NotFound();
             return Ok(Ref_Staff_Role);
         }
            [HttpGet] [Route("")] public IActionResult GetAll() 
            { 
                var Ref_Staff_Roles = _Ref_Staff_RoleService.GetAll(); 
                return Ok(Ref_Staff_Roles);
             }
            [HttpPost] 
            [Route("")]
             public IActionResult Post([FromBody] Ref_Staff_Roles model)
              {
                   _Ref_Staff_RoleService.Insert(model);
            return Ok();
}
            [HttpPut]
             [Route("")] 
             public IActionResult Put([FromBody] Ref_Staff_Roles model) 
             {
                  _Ref_Staff_RoleService.Update(model); 
                 return Ok();
              }
              [HttpDelete] 
              [Route("")]
               public IActionResult Delete([FromBody] Ref_Staff_Roles model)
                { 
                    _Ref_Staff_RoleService.Delete(model);
                     return Ok(); }
                }
} 