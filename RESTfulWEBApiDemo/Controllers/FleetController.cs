using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTfulWEBApiDemo.Model;

namespace RESTfulWEBApiDemo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        public static List<Car> cars = new List<Car>()
        {
            new Car(1, "Ford", "Diesel", 4, 231000, new Location("Killmotor Hill", "555 405", "Duckburg", "555-moneybath"))
        };

        [HttpGet]
        public IEnumerable<Car> GetAll()
        {
            // Call dao for data
            throw new NotImplementedException();    
        }

        [HttpGet("{id}")]
        public Car? GetById(int id)
        {
            return cars.SingleOrDefault(c => c.Id == id);
        }

        [HttpGet("{id}/location")]
        public Location? GetLocation(int id)
        {
            return cars.Single(c => c.Id == id).Location;
        }

        [HttpPost]
        public void Post(Car car)
        {
            // call dao to create data
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Car car)
        {
            // call dao to update date
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            // call dao to delete
        }
    }
}
