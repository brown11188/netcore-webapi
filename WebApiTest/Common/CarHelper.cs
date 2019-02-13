using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApiTest.Models;

namespace WebApiTest.Common
{
    public class CarHelper
    {
        public static List<Car> Cars = new List<Car>();
        public static void GetMockCar()
        {
            using (StreamReader sr = new StreamReader("./Data/cars.json"))
            {
                // Read the stream to a string, and write the string to the console.
                var carText = sr.ReadToEnd();
                Cars = JsonConvert.DeserializeObject<List<Car>>(carText);
            }
        }
    }
}
