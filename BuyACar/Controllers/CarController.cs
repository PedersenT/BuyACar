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


        [HttpGet("{id}")]
        public async Task<Results<Ok<CarRecord>, NotFound>> GetCarById(int id)
        {
            var carRec = await _carService.GetCarByIdAsync(id);
            return carRec == null ? TypedResults.NotFound() : TypedResults.Ok(carRec);
        }

        [HttpGet("/{name}")]
        public async Task<Results<Ok<CarRecord>, NotFound>> GetCarByName(string name)
        {
            var carRec = await _carService.GetCarByNameAsync(name);
            return carRec == null ? TypedResults.NotFound() : TypedResults.Ok(carRec);
        }




        [HttpPost]
        public async Task<ActionResult<CarRecord>> PostCarAsync([FromBody] Car car)
        {
            if (car == null)
            {
                return BadRequest("Car cannot be null");
            }

            var createdCar = await _carService.PostCarAsync(car);

            if (createdCar == null)
            {
                return BadRequest("A problem happened while handling your request.");
            }

            return CreatedAtAction(
                nameof(GetCarByName),
                new { createdCar.Name },
                createdCar
            );


        }
    }
}
