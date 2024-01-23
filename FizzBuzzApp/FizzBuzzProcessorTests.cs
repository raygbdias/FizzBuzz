using FizzBuzz.Processor;
using FizzBuzz.Rules;

namespace FizzBuzzApp.Tests
{
    [TestFixture]
    public class FizzBuzzProcessorTests
    {
        private FizzBuzzProcessor _processor;

        [SetUp]
        public void Setup()
        {
            List<IFizzBuzzRule> rules = new() 
            { 
                new FizzBuzzRule(), 
                new FizzRule(), 
                new BuzzRule() 
            };
            _processor = new FizzBuzzProcessor(rules);
        }

        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(2, "2")]
        public void Processor_ShouldReturnCorrectResult(int number, string expectedResult)
        {
            Assert.That(_processor.Process(number), Is.EqualTo(expectedResult));
        }
    }
}
