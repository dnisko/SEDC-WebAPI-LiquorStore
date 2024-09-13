using System.Security.Claims;
using DTOs.Beverage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace LiquorStore.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class BeverageController : ControllerBase
    {
        private readonly IBeverageService _beverageService;

        public BeverageController(IBeverageService beverageService)
        {
            _beverageService = beverageService;
        }
        
        [HttpPost("addBeverage")]
        [Authorize]
        public IActionResult AddBeverage(AddBeverageDto beverageDto)
        {

            var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            //var userId = 1;
            //var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            try
            {
                _beverageService.AddBeverage(beverageDto, userId);

                return Ok("Beverage added successfully.");
            }
            catch (UnauthorizedAccessException ex)
            {
                return Forbid(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
