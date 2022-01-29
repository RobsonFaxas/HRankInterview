using HRankInterview.Exercises.Logics;
using System.Configuration;
using System.IO;
using System.Text;
using Xunit;

namespace HRankInterview.Exercises.Tests.Logics
{
    public class SampleTest
    {
        private readonly string _baseOutputFolder;
        public SampleTest()
        {
            _baseOutputFolder = $"{ConfigurationManager.AppSettings["baseOutputFolder"]}/{nameof(FizzBuzzLogic)}";
        }

        [Fact]
        public void CheckTestCase0()
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader Reader = new StreamReader($"{_baseOutputFolder}/output-sample0.txt"))
            {
                sb.Append(Reader.ReadToEnd());
                sb.AppendLine();
            }
            Assert.Equal(FizzBuzzLogic.Executor(15).ToString().Trim(),sb.ToString().Trim());
        }

        [Fact]
        public void CheckTestCase1()
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader Reader = new StreamReader($"{_baseOutputFolder}/output-sample1.txt"))
            {
                sb.Append(Reader.ReadToEnd());
                sb.AppendLine();
            }
            Assert.Equal(FizzBuzzLogic.Executor(65).ToString().Trim(), sb.ToString().Trim());
        }

        [Fact]
        public void CheckTestCase2()
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader Reader = new StreamReader($"{_baseOutputFolder}/output-sample2.txt"))
            {
                sb.Append(Reader.ReadToEnd());
                sb.AppendLine();
            }
            Assert.Equal(FizzBuzzLogic.Executor(12).ToString().Trim(), sb.ToString().Trim());
        }
    }
}
