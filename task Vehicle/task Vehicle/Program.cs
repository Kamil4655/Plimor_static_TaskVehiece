using task_Vehicle.Models;

namespace task_Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new(4, true, "BMW", "Mercedes", "black", 5, 310);
            car.GetInfo();
            
            car.AverageSpeed();
            car.ToString();

            Bicycle bicycle = new Bicycle("dag", "stels", "bmw","blue", 30, 200);
            Bicycle bicycle1 = new Bicycle("yaris", "stels", "merc","red", 10, 100);
            Bicycle bicycle2 = new Bicycle("seheer", "nimh", "brave","yellow", 30, 150);
            Bicycle[] bicycles = {bicycle, bicycle1,bicycle2};
            foreach ( var item in bicycles) 
            {
                item.GetInfo();
                item.AverageSpeed();
                item.ToString();
            }
           
        }
    }
}
