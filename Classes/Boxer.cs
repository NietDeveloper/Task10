
public class Boxer
{
    public int Id { get; set; }
    public string? Surname { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public int Weight { get; set; }

    private static List<Boxer> boxers = new List<Boxer>
    {
        new Boxer {Id = 1, Name = "Xasan", Surname = "Sarsenbaev", Age = 19, Weight = 66 },
        new Boxer {Id = 2, Name = "Azamat", Surname = "Demegenov", Age = 24, Weight = 68 },
        new Boxer {Id = 3, Name = "Azamat", Surname = "Qadirimbetov", Age = 20, Weight = 69 },
        new Boxer {Id = 4, Name = "Alpamis", Surname = "Joldasov", Age = 25, Weight = 45 },
        new Boxer {Id = 5, Name = "Artur", Surname = "Aytmuratov", Age = 24, Weight = 49 },
        new Boxer {Id = 6, Name = "Islam", Surname = "Mambetaminov", Age = 23, Weight = 50 },
        new Boxer {Id = 7, Name = "Maxmudjan", Surname = "Jumamuratov", Age = 22, Weight = 44 },
        new Boxer {Id = 8, Name = "Ilxam", Surname = "Shimtemirov", Age = 18, Weight = 48 },
        new Boxer {Id = 9, Name = "Orazbek", Surname = "Qadirirmbetov", Age = 19, Weight = 51 },
        new Boxer {Id = 10, Name = "Ali", Surname = "omirbaev", Age = 20, Weight = 52 },
        new Boxer {Id = 11, Name = "Rasul", Surname = "Azatov", Age = 21, Weight = 53 },
        new Boxer {Id = 12, Name = "Alpamis", Surname = "Torebekov", Age = 22, Weight = 54 },
        new Boxer {Id = 13, Name = "Baxram", Surname = "Saparbaev", Age = 23, Weight = 57 },
        new Boxer {Id = 14, Name = "Samat", Surname = "Saparbaev", Age = 24, Weight = 60 },
        new Boxer {Id = 15, Name = "Madiyar", Surname = "Abdullaev", Age = 25, Weight = 62 },
        new Boxer {Id = 16, Name = "Baxtiyar", Surname = "Abdullaev", Age = 26, Weight = 68 },
        new Boxer {Id = 17, Name = "Musa", Surname = "Allambergenov", Age = 27, Weight = 70 },
        new Boxer {Id = 18, Name = "Ixtyar", Surname = "Dawletbaev", Age = 28, Weight = 72 },
        new Boxer {Id = 19, Name = "Bektursin", Surname = "Tursinbaev", Age = 29, Weight = 74 },
        new Boxer {Id = 20, Name = "Jandawlet", Surname = "Otarbaev", Age = 28, Weight = 76 },
        new Boxer {Id = 21, Name = "Axmet", Surname = "Sarsenbaev", Age = 25, Weight = 80 },
        new Boxer {Id = 22, Name = "Samet", Surname = "Satibaldiev", Age = 22, Weight = 85 },
        new Boxer {Id = 23, Name = "Nurlan", Surname = "Qojanasirov", Age = 22, Weight = 90 },
        new Boxer {Id = 24, Name = "Yusup", Surname = "Abdumajitov", Age = 19, Weight = 95 },
        new Boxer {Id = 25, Name = "Majit", Surname = "Aliev", Age = 18, Weight = 92 },
        new Boxer {Id = 26, Name = "Asad", Surname = "Bekmatov", Age = 29, Weight = 96 }
    };

    public void GetBoxerInfo(int weight1, int weight2)
    {
        var fitWeight = boxers.Where(s => s.Weight >= weight1 && s.Weight <= weight2);
        if(fitWeight.Any())
        {
           foreach(var user in fitWeight)
           {
            System.Console.WriteLine($"Boxer ID:{user.Id}, Name:{user.Name}, Last Name:{user.Surname}, Age:{user.Age}, Weight:{user.Weight}");
           }
        }
        else
        {
            System.Console.WriteLine("Vaznni tog'ri kiriting!");
        }
    }
}