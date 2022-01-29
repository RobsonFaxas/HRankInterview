using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRankInterview.Exercises
{
    public class Runner
    {
        private readonly IRunner _runner;
        public Runner(IRunner runner)
        {
            _runner = runner;
        }

        public long Run()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            _runner.Run();
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
    }
}
