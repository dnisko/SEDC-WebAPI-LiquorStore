using System.Diagnostics;
using System.Security.Claims;
using DTOs.Beverage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Services.Interfaces;
using Shared;
using Shared.Exceptions;

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
        [HttpGet("getAllBeverage")]
        public IActionResult Get()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            try
            {
                Log.Debug("Starting fetching beverages.");
                var beverages = _beverageService.GetAllBeverages();

                stopwatch.Stop();
                Log.Debug($"Finished fetching of movies in {stopwatch.ElapsedMilliseconds}");

                if (beverages != null && beverages.Any())
                {
                    return Ok(_beverageService.GetAllBeverages());
                }

                throw new BeverageDataException("Error while fetching beverages!");
            }
            catch (BeverageNotFoundException ex)
            {
                Log.Error("Error occurred while fetching all beverages.", ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                Log.Error("Error occurred while fetching all beverages.", ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    Log.Error($"Error occurred while fetching beverage with id: {id}.");
                    return BadRequest("Id must have positive value!");
                }

                var beverage = _beverageService.GetBeverageById(id);
                if (beverage == null)
                {
                    Log.Error($"Error occurred while fetching beverage with id: {id}.");
                    throw new BeverageNotFoundException("Beverage not found!");
                }

                return Ok(beverage);
            }
            catch (BeverageNotFoundException ex)
            {
                Log.Error($"Error occurred while fetching beverage with id: {id}.", ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            catch (Exception ex)
            {
                Log.Error($"Error occurred while fetching beverage with id: {id}.", ex);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
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
