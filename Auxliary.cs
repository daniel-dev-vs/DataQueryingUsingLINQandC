using System;

namespace LinqApp
{
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         var writer = new Writer
    //         {
    //             Name = "Timothy",
    //             Scope = ".NET Core",
    //             YearsOfExperience = 15
    //         };

    //         writer.Introduce1();
    //         writer.Introduce2();
    //         writer.Introduce3();
    //     }
    // }

    public interface IWorker
    {
        string Name { get; set; }
        int YearsOfExperience { get; set; }
        string Scope { get; set; }
    }

    public class Writer : IWorker
    {
        public string Name { get; set; }
        public int YearsOfExperience { get; set; }
        public string Scope { get; set; }
        public void Write() { /*...*/ }
    }

    public class Teacher : IWorker
    {
        public string Name { get; set; }
        public int YearsOfExperience { get; set; }
        public string Scope { get; set; }
        public void Teach() { /*...*/ }
    }

    public static class IWorkerExtension
    {
        public static void Introduce1(this IWorker worker)
        {
            Console.WriteLine($"Hi, my name is {worker.Name}.");
        }

        public static void Introduce2(this IWorker worker)
        {
            Console.WriteLine($"My major scope is {worker.Scope}.");
        }

        public static void Introduce3(this IWorker worker)
        {
            Console.WriteLine($"I have {worker.YearsOfExperience} years experience.");
        }
    }
}