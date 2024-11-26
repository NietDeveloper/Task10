public class Car
{
    public string? Name { get; set; }
    public string? Model { get; set; }
    public int Price { get; set; }

    private static List<Car> cars = new List<Car>
    {
        new Car {Name = "Tracker", Model = "Redline", Price = 20000},
        new Car {Name = "Tracker", Model = "Primer", Price = 23000},
        new Car {Name = "Nexia", Model = "Dons", Price = 7000},
        new Car {Name = "Spark", Model = "LTZ", Price = 8000},
        new Car {Name = "Jenta", Model = "AT", Price = 15000},
        new Car {Name = "Matiz", Model = "Best", Price = 4000},
        new Car {Name = "Cobalt", Model = "LTZ", Price = 12000},
        new Car {Name = "Onix", Model = "Redline", Price = 16000},
        new Car {Name = "Onix", Model = "Primer", Price = 16520},
        new Car {Name = "Malibu", Model = "Turbo", Price = 18000},
        new Car {Name = "Kia", Model = "Soner", Price = 19000},
        new Car {Name = "Kia", Model = "SportAge", Price = 25000},
        new Car {Name = "Malibu", Model = "Malibu1", Price = 15500},
    };
    public void ShowMeCarsPrisedBetween(int price1, int price2)
    {
        var carPrice = cars.Where(s => s.Price >= price1 && s.Price <= price2).ToList();
        if(carPrice.Any())
        {
            foreach(var car in carPrice)
            {
                System.Console.WriteLine($"Avtomobil nomi:{car.Name}, Modeli:{car.Model}, Narxi:{car.Price}$");
            }
        }
        else
        {
            System.Console.WriteLine("Kiritilgan narx bo'yicha avtomobillar topilmadi!");
        }
    }
}