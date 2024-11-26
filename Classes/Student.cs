using System;
using System.Collections.Generic;
using System.Linq;
using Task10;
public class Student
{
    public Student(){}
    public Guid Id { get; set; }
    public string? UserName { get; set; }
    public string? Surname { get; set; }
    public int Class { get; set; }
    public Score Score1 { get; set; }

    
    private static List<Student> students = new List<Student>
           {
            new Student {Id = Guid.NewGuid(), UserName = "Nietbay", Surname = "Muratbaev", Class = 9, Score1 = Score.E},
                new Student {Id = Guid.NewGuid(), UserName = "Alpamis", Surname = "Joldasov", Class = 8, Score1 = Score.D},
                new Student {Id = Guid.NewGuid(), UserName = "Ali", Surname = "Barlikov", Class = 7, Score1 = Score.A},
                new Student {Id = Guid.NewGuid(), UserName = "Vali", Surname = "Shakirov", Class = 5, Score1 = Score.B},
                new Student {Id = Guid.NewGuid(), UserName = "Barliqbay", Surname = "Qidirbaev", Class = 8, Score1 = Score.C},
                new Student {Id = Guid.NewGuid(), UserName = "Baxit", Surname = "Qalqurazov", Class = 11, Score1 = Score.D},
                new Student {Id = Guid.NewGuid(), UserName = "Xasan", Surname = "Sarsenbaev", Class = 9, Score1 = Score.B},
                new Student {Id = Guid.NewGuid(), UserName = "Xusan", Surname = "Satibaldiev", Class = 7, Score1 = Score.C},
                new Student {Id = Guid.NewGuid(), UserName = "Musa", Surname = "Aytmuratov", Class = 6, Score1 = Score.A},
                new Student {Id = Guid.NewGuid(), UserName = "Sarsen", Surname = "Barliqbaev", Class = 5, Score1 = Score.D},
           };
    public void GetInfoStudent(string score)
    {
        if(Enum.TryParse(score, true, out Score result))
        {
            var mosStudents = students.Where(s => s.Score1 == result).ToList();
            if(mosStudents.Any())
            {
                System.Console.WriteLine($"Studenlar olgan bahosi{score}");
                foreach(var student in mosStudents)
                {
                    System.Console.WriteLine($"ID:{student.Id}, Name:{student.UserName}, Last Name:{student.Surname}, Class:{student.Class}");
                }
            }
            else
            {
                System.Console.WriteLine("Siz kiritgan baho boyicha oquvchilar royhati topilmadi!");
            }   
        }
        else
        {
            System.Console.WriteLine("Notog'ri baho kiritildi! ");
        }
    }

}

