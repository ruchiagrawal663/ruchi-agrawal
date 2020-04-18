using ApexRestaurant.Repository.Domain;
 using ApexRestaurant.Services.SMeal_Dish; 
 using Microsoft.AspNetCore.Mvc;
namespace ApexRestaurant.Api.Controller
 { 
     [Route("api/meal_dish")]
      public class Meal_DishController : ControllerBase 
      {
        private readonly IMeal_DishService _Meal_DishService;
        public Meal_DishController(IMeal_DishService Meal_DishService)
         { 
             _Meal_DishService = Meal_DishService; 
         }
         [HttpGet] [Route("{id}")]
          public IActionResult Get([FromRoute] int id) 
         { 
             var Meal_Dish = _Meal_DishService.GetById(id);
             if (Meal_Dish == null) return NotFound();
             return Ok(Meal_Dish);
         }
            [HttpGet] [Route("")] public IActionResult GetAll() 
            { 
                var Meal_Dishs = _Meal_DishService.GetAll(); 
                return Ok(Meal_Dishs);
             }
            [HttpPost] 
            [Route("")]
             public IActionResult Post([FromBody] Meal_Dishes model)
              {
                   _Meal_DishService.Insert(model);
            return Ok();
}
            [HttpPut]
             [Route("")] 
             public IActionResult Put([FromBody] Meal_Dishes model) 
             {
                  _Meal_DishService.Update(model); 
                 return Ok();
              }
              [HttpDelete] 
              [Route("")]
               public IActionResult Delete([FromBody] Meal_Dishes model)
                { 
                    _Meal_DishService.Delete(model);
                     return Ok(); }
                }
} 