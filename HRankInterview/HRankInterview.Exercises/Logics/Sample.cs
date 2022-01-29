using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HRankInterview.Exercises.Logics
{
    public class FizzBuzzLogic
    {
        public static StringBuilder Executor(int n)
        {
            StringBuilder sb = new StringBuilder();
            for (var i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    sb.AppendLine("FizzBuzz");
                else if (i % 3 == 0)
                    sb.AppendLine("Fizz");
                else if (i % 5 == 0)
                    sb.AppendLine("Buzz");
                else
                    sb.AppendLine(i.ToString());
            }
            return sb;
        }
        

        public static void RunResult(int n)
        {
           Console.Write(Executor(n));
        }

    }

    public class FizzBuzzCaller : IRunner
    {
        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            FizzBuzzLogic.RunResult(n);
        }
    }
}
