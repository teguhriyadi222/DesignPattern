// public class CarManager
// {
//     private static CarManager instance;
//     private List<Car> cars;

//     private CarManager()
//     {
//         cars = new List<Car>();
//     }

//     public static CarManager Instance
//     {
//         get
//         {
//             if (instance == null)
//             {
//                 instance = new CarManager();
//             }
//             return instance;
//         }
//     }

//     public void AddCar(Car car)
//     {
//         cars.Add(car);
//     }

//     public List<Car> GetAllCars()
//     {
//         return cars;
//     }
// }

// public class Car
// {
//     public string Brand { get; set; }
//     public string Model { get; set; }

//     public Car(string brand, string model)
//     {
//         Brand = brand;
//         Model = model;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {

//         CarManager carManager = CarManager.Instance;

//         Car car1 = new Car("Toyota", "Corolla");
//         Car car2 = new Car("Honda", "Civic");

//         carManager.AddCar(car1);
//         carManager.AddCar(car2);

//         List<Car> allCars = carManager.GetAllCars();
//         foreach (Car car in allCars)
//         {
//             Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}");
//         }
//     }
// }
