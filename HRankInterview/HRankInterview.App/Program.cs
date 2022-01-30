using HRankInterview.Exercises;
using HRankInterview.Exercises.Logics;
using System;

namespace HRankInterview.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Runner runner = new Runner(new FizzBuzzCaller());
            runner.Run();
            Console.ReadKey();
        }
    }
}
