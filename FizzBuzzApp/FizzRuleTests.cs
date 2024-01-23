using FizzBuzz.Rules;

namespace FizzBuzzApp
{
    [TestFixture]
    public class FizzRuleTests
    {
        private FizzRule _fizzRule;

        [SetUp]
        public void Setup()
        {
            _fizzRule = new FizzRule();
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void FizzRule_ShouldApplyToFizzNumbers(int number)
        {
            Assert.IsTrue(_fizzRule.IsApplicable(number));
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void FizzRule_ShouldNotApplyToNonFizzNumbers(int number)
        {
            Assert.IsFalse(_fizzRule.IsApplicable(number));
        }

        [Test]
        public void FizzRule_ShouldReturnFizz()
        {
            Assert.AreEqual("Fizz", _fizzRule.GetResult());
        }
    }
}