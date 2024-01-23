namespace FizzBuzz.Rules
{
    public class BuzzRule : IFizzBuzzRule
    {
        public bool IsApplicable(int number) => number % 5 == 0;
        public string GetResult() => "Buzz";
    }
}
