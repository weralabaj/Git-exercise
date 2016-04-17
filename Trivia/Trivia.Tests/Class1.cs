using System;
using System.IO;
using NUnit.Framework;

namespace Trivia.Tests
{
    [TestFixture]
    public class GenerateFile
    {
        private string _currentResult = @".\CurrentOutput.txt";
        private string _expectedResult = @".\SampleOutput.txt";

        [Test]
        [Explicit]
        public void PrepareData()
        {
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                writer = new StreamWriter(_expectedResult);
                Console.SetOut(writer);
                for (int i = 0; i < 100000; i++)
                {
                    GameRunner.Main(new[]{i.ToString()});
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(oldOut);
            writer.Close();
        }

        [Test]
        public void Test()
        {
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                writer = new StreamWriter(_currentResult);
                Console.SetOut(writer);
                for (int i = 0; i < 100000; i++)
                {
                    GameRunner.Main(new[] { i.ToString() });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(oldOut);
            writer.Close();

            Assert.True(FileEquals(_expectedResult, _currentResult));
        }

        static bool FileEquals(string path1, string path2)
        {
            byte[] file1 = File.ReadAllBytes(path1);
            byte[] file2 = File.ReadAllBytes(path2);
            if (file1.Length == file2.Length)
            {
                for (int i = 0; i < file1.Length; i++)
                {
                    if (file1[i] != file2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
