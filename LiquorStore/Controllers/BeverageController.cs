using System.Security.Claims;
using DomainModels;
using DTOs.Beverage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;
using Services.Implementation;
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
            // Assume we have the current user's ID stored in the claims (e.g., in a JWT token)
            var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            //var userId = 1;
            //var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            try
            {
                //var beverage = new Beverage
                //{
                //    Name = beverageDto.Name,
                //    Type = beverageDto.Type,
                //    Quantity = beverageDto.Quantity,
                //    Price = beverageDto.Price,
                //    Description = beverageDto.Description,
                //    ImageUrl = beverageDto.ImageUrl
                //};

                // Call the service to add the beverage, passing the user ID
                _beverageService.AddBeverage(beverageDto, userId);

                return Ok("Beverage added successfully.");
            }
            catch (UnauthorizedAccessException ex)
            {
                return Forbid(ex.Message); // Return 403 Forbidden if not authorized
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); // Handle other exceptions
            }
        }
    }
}
