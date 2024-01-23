using FizzBuzz.Rules;

namespace FizzBuzzApp.Tests
{
    [TestFixture]
    public class BuzzRuleTests
    {
        private BuzzRule _buzzRule;

        [SetUp]
        public void Setup()
        {
            _buzzRule = new BuzzRule();
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void BuzzRule_ShouldApplyToBuzzNumbers(int number)
        {
            Assert.That(_buzzRule.IsApplicable(number), Is.True);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void BuzzRule_ShouldNotApplyToNonBuzzNumbers(int number)
        {
            Assert.That(_buzzRule.IsApplicable(number), Is.False);
        }

        [Test]
        public void BuzzRule_ShouldReturnBuzz()
        {
            Assert.That(_buzzRule.GetResult(), Is.EqualTo("Buzz"));
        }
    }
}
