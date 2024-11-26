namespace Task10
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1-Task
            Student student = new Student();
            Console.Write("Ballni (A,B,C,D,E) ko'rinishda kiriting:");
            string? score = Console.ReadLine(); 
            if(!string.IsNullOrEmpty(score))
            {
                student.GetInfoStudent(score);
            }
            else
            {
                Console.Write("Kiritgan qiymatingiz Null yoki bosh");
            }
            // 2-Task
            Car car = new Car();
            System.Console.Write("Price1:");
            int price1 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Price2:");
            int price2 = Convert.ToInt32(Console.ReadLine());
            car.ShowMeCarsPrisedBetween(price1,price2);
            //3-Task
            Boxer boxer = new Boxer();
            System.Console.WriteLine("Qaysi vazndagi bokschilarni chop etish kerak.Pastda vazinni kiriting.");
            System.Console.Write("Vazn1:");
            int weight1 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Vazn2:");
            int weight2 = Convert.ToInt32(Console.ReadLine());
            boxer.GetBoxerInfo(weight1, weight2);


        }
    }
}