
object obj1 = new object();
object obj2 = new object();

Thread t1 = new Thread(Method1);
Thread t2 = new Thread(Method2);

t1.Start();
t2.Start();
Console.WriteLine("finished");


void Method1()
{
    lock (obj1)
    {
        Console.WriteLine("obj1 locked method1");
        lock (obj2)
        {
            Console.WriteLine("obj2 locked method1");
        }
    }
}

void Method2()
{
    lock (obj2)
    {
        Console.WriteLine("obj2 locked method2");
        lock (obj1)
        {
            Console.WriteLine("obj1 locked method2");
        }
    }
}