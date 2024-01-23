using FizzBuzz.Rules;

namespace FizzBuzzApp.Tests
{
    [TestFixture]
    public class FizzBuzzRuleTests
    {
        private FizzBuzzRule _fizzBuzzRule;

        [SetUp]
        public void Setup()
        {
            _fizzBuzzRule = new FizzBuzzRule();
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void FizzBuzzRule_ShouldApplyToFizzBuzzNumbers(int number)
        {
            Assert.IsTrue(_fizzBuzzRule.IsApplicable(number));
        }

        [TestCase(3)]
        [TestCase(5)]
        [TestCase(14)]
        public void FizzBuzzRule_ShouldNotApplyToNonFizzBuzzNumbers(int number)
        {
            Assert.IsFalse(_fizzBuzzRule.IsApplicable(number));
        }

        [Test]
        public void FizzBuzzRule_ShouldReturnFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", _fizzBuzzRule.GetResult());
        }
    }
}
