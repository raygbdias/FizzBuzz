namespace FizzBuzz.Rules
{
    public class FizzBuzzRule : IFizzBuzzRule
    {
        public bool IsApplicable(int number) => number % 3 == 0 && number % 5 == 0;
        public string GetResult() => "FizzBuzz";
    }
}
