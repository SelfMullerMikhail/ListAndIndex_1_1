using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;

namespace INKQ
{
    public static class MyExtentionMethod
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> enumerable, Func<T, bool> predicte)
        {
            foreach (var i in enumerable)
            {
                if (predicte(i))
                {
                    yield return i;
                }
            }
        }

    }
}


public class Student
{
    public string LastName { get; set; }
    public string Group { get; set; }
}

internal class Program
{
    static void Main(string[] args)
    {
        var students = new Student[]
        {
            new Student{LastName = "Jone", Group = "FT-1"},
            new Student { LastName = "Adam", Group = "FT-1" },
            new Student { LastName = "Wiliams", Group = "KN-1" },
            new Student { LastName = "Brown", Group = "KN-1" }
    };
        var result = new List<string>();
        foreach (var student in students)
        {
            if (student.Group == "FT-1")
            {
                result.Add(student.LastName);
            }

        }
        var result1 = students
                .Where(z => (z.Group == "FT-1"))
                .Select(z => z.LastName).ToList();

        foreach (var i in result) { Console.WriteLine(i); }
        foreach (var i in result1) { Console.WriteLine(i); }

        var result3 = students.Where(z => (z.Group == "KN-1"));
        Console.WriteLine("---------");
        foreach (var i in result3) { Console.WriteLine(i.LastName); }
    }
}

