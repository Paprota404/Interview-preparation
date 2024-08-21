namespace Delegate;

public class Delegates
{
    public static Action<string> action = message => Console.WriteLine(message);

    public Func<int, int, int> add;

    public delegate void MyDelegate(int a, int b);
    public MyDelegate del;
    public Delegates()
    {
        add = (int a, int b) => a + b;
        del = new MyDelegate(PrintNumbers);
        del += MultiplyNumbers;
    }
    public void PrintNumbers(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    public void MultiplyNumbers(int a, int b)
    {
        Console.WriteLine(a * b);
    }
}