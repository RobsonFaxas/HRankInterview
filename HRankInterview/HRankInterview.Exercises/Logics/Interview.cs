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
