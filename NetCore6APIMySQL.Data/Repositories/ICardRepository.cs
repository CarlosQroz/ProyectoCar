using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCore6APIMySQL.Model;

namespace NetCore6APIMySQL.Data.Repositories
{
    public interface ICardRepository
    {
        Task<IEnumerable<Car>> GetallCars();
        Task<Car> GetDetails(int id);
        Task<bool> InsertCar(Car car);
        Task<bool> UpdateCar(Car car);
        Task<bool> DeleteCar(Car car);
    }
}

