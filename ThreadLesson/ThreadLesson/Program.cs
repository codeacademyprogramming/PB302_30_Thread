
Thread t1 = new Thread(PrintNum1);
Thread t2 = new Thread(PrintNum2);
    
t1.Start();
t1.Join();
t2.Start();
Console.WriteLine("finished");


void PrintNum1()
{
	for (int i = 0; i < 2000; i++)
	{
        Console.Write(i + " ");
    }
}

void PrintNum2()
{
    for (int i = 2000; i < 4000; i++)
    {
        Console.Write(i+" ");
    }
}

