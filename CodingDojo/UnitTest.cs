using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojo
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(3, "Fizz")]
        [DataRow(4, "4")]
        [DataRow(5, "Buzz")]
        [DataRow(6, "Fizz")]
        [DataRow(15, "FizzBuzz")]
        public void TestFizzBuzz(int input, string output)
        {
            Assert.AreEqual(output, ProgramT.FizzBuzz(input));
        }

        //[TestMethod]
        //public void TestOneOutputPrintFizzBuzz()
        //{
        //    ProgramT.PrintFizzBuzz();
        //    TextW Console.Out;
        //    using StreamReader reader = new StreamReader(stream);

        //    // run program

        //    var line = reader.ReadLine();

        //    Assert.AreEqual("1", line);


        //}
    }
}
