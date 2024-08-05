using BuyACar.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using BuyACar.Models.Car;


namespace BuyACar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;
        private readonly ICarService _carService;

        public CarController(ILogger<CarController> logger, ICarService carService)
        {
            _logger = logger;
            _carService = carService;
        }

        [HttpGet(Name = "GetCar")]
        public async Task<Results<Ok<Car>, NotFound>> GetCarById(int id)
        {
            var car = await _carService.GetCarByIdAsync(id);
            return car == null ? TypedResults.NotFound() : TypedResults.Ok(car);
        }

        [HttpPost]
        public async Task<ActionResult<Car>> PostCarAsync([FromBody] CarPostDTO carPostDTO)
        {
            if (carPostDTO == null)
            {
                return BadRequest("Car cannot be null");
            }

            var createdCar = await _carService.PostCarAsync(carPostDTO);

            if (createdCar == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "A problem happened while handling your request.");
            }

            return CreatedAtAction(
                nameof(GetCarById),
                new { id = createdCar.Id },
                createdCar
            );


        }
    }
}
