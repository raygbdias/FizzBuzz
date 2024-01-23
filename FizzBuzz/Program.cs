using FizzBuzz.Processor;
using FizzBuzz.Rules;

List<IFizzBuzzRule> rules = new()
{
    new FizzBuzzRule(),
    new FizzRule(),
    new BuzzRule() 
};
FizzBuzzProcessor processor = new(rules);

for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(processor.Process(i));
}
