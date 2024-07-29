using BuyACar.Data;
using BuyACar.Models;
using Microsoft.EntityFrameworkCore;


namespace BuyACar.Repositories
{
    public interface ICarRepository
    {
        Car? GetCarById(int id);
    }
}
