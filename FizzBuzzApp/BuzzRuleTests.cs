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
            Assert.IsTrue(_buzzRule.IsApplicable(number));
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void BuzzRule_ShouldNotApplyToNonBuzzNumbers(int number)
        {
            Assert.IsFalse(_buzzRule.IsApplicable(number));
        }

        [Test]
        public void BuzzRule_ShouldReturnBuzz()
        {
            Assert.AreEqual("Buzz", _buzzRule.GetResult());
        }
    }
}
