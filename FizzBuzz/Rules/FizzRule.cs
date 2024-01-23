namespace FizzBuzz.Rules
{
    public class FizzRule : IFizzBuzzRule
    {
        public bool IsApplicable(int number) => number % 3 == 0;
        public string GetResult() => "Fizz";
    }
}
