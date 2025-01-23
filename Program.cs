using Microsoft.Extensions.DependencyInjection;
using CalcCLICSharp.Services;
using CalcCLICSharp.Runner;
using CalcCLICSharp.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<ICalculator, CalculatorService>()
            .AddSingleton<InputParserService>()
            .AddSingleton<DisplayService>()
            .AddSingleton<CalculatorRunner>()
            .BuildServiceProvider();

        var runner = serviceProvider.GetService<CalculatorRunner>();
        runner.Run();
    }
}