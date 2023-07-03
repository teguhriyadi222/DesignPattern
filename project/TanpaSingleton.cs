public class CarManager
{
    private List<Car> cars;

    public CarManager()
    {
        cars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public List<Car> GetAllCars()
    {
        return cars;
    }
}
public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }

    public Car(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }
}


class Program
{
    static void Main(string[] args)
    {
        CarManager carManager = new CarManager();

        Car car1 = new Car("Toyota", "Corolla");
        Car car2 = new Car("Honda", "Civic");

        carManager.AddCar(car1);
        carManager.AddCar(car2);

        List<Car> allCars = carManager.GetAllCars();
        foreach (Car car in allCars)
        {
            Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}");
        }
    }
}
