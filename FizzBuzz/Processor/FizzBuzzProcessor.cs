using FizzBuzz.Rules;

namespace FizzBuzz.Processor
{
    public class FizzBuzzProcessor
    {
        private readonly List<IFizzBuzzRule> _rules;

        public FizzBuzzProcessor(List<IFizzBuzzRule> rules)
        {
            _rules = rules;
        }

        public string Process(int number)
        {
            foreach (IFizzBuzzRule rule in _rules)
            {
                if (rule.IsApplicable(number))
                {
                    return rule.GetResult();
                }
            }
            return number.ToString();
        }
    }
}
