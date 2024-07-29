using BuyACar.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using BuyACar.Models;


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
        public Results<Ok<Car>, NotFound> GetCarById(int id)
        {
            var car = _carService.GetCarById(id);
            return car == null ? TypedResults.NotFound() : TypedResults.Ok(car);
        }


    }
}
