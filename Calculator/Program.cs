using Calculator;

Calculate calculator = new Calculate();

Console.WriteLine(@"Would you like to
1. Multiply
2. Square
?");
string inputCalculate = Console.ReadLine();

if (inputCalculate == "1")
{
    calculator.Multiply();
}
else if (inputCalculate == "2")
{
    calculator.Square();
}