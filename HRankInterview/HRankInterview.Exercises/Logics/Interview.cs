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
    public class InterviewLogic
    {
        public static StringBuilder Executor()
        {
            StringBuilder sb = new StringBuilder();
            
            return sb;
        }
        

        public static void RunResult()
        {
           Console.Write(Executor());
        }

    }

    public class InterviewCaller : IRunner
    {
        public void Run()
        {
            InterviewLogic.RunResult();
        }
    }
}
