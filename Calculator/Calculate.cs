namespace Calculator;

public class Calculate
{
    public void Multiply()
    {
        Console.Write("Please enter the numbers to multiply, separated by commas: ");
        string input = Console.ReadLine();
        string[] splitList = input.Split(",");

        int total = 1;
        for (int i = 0; i < splitList.Length; i++)
        {
            int num = int.Parse(splitList[i]);
            total = total * num;
        }

        Console.WriteLine(total);
    }

    public void Square()
    {
        Console.Write("Please enter the numbers to square, separated by commas: ");
        string input = Console.ReadLine();
        string[] splitList = input.Split(",");

        List<int> squareList= new List<int>();
        for (int i = 0; i < splitList.Length; i++)
        {
            int num = int.Parse(splitList[i]);
            squareList.Add(num * num);
        }
        string squareListJoined = String.Join(",", squareList);
        Console.WriteLine(squareListJoined);
    }
}
