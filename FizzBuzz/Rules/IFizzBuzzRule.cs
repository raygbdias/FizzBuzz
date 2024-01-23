namespace FizzBuzz.Rules
{
    public interface IFizzBuzzRule
    {
        bool IsApplicable(int number);
        string GetResult();
    }
}
