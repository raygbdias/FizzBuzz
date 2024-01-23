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
            Assert.That(_fizzRule.IsApplicable(number), Is.True);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void FizzRule_ShouldNotApplyToNonFizzNumbers(int number)
        {
            Assert.That(_fizzRule.IsApplicable(number), Is.False);
        }

        [Test]
        public void FizzRule_ShouldReturnFizz()
        {
            Assert.That(_fizzRule.GetResult(), Is.EqualTo("Fizz"));
        }
    }
}