using HRankInterview.Exercises;
using HRankInterview.Exercises.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
