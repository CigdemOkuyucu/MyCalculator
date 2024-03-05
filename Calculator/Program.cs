
using System.Data;

public static class Calculator
{
    public static int Add(int a,int b)
    {
        return 2*(a+b);
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello Calculator");
        Console.WriteLine(Calculator.Add(7,5));
    }

}