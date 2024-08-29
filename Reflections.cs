

namespace Reflections;

public class Reflection
{

    public static void PrintType()
    {
        int i = 2;
        System.Type type = i.GetType();
        Console.WriteLine(type);
    }
}