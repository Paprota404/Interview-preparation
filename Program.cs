using Delegate;

//New gear
//Stack and heap and JIT
//Clang, GCC etc.
//DDD and web servers
//Transfer protocols and browsers
//Composition
//Tasks

class Program
{
    static void Main(string[] args)
    {
        Delegates.action("message");

        Delegates delegatesInstance = new Delegates();

        delegatesInstance.del(2, 3);

        Console.WriteLine(delegatesInstance.add(4,3));
    }
}
