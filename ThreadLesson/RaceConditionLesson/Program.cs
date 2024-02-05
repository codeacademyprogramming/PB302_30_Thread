
using RaceConditionLesson;

Account account = new Account();

Thread[] pool = new Thread[2];

pool[0] = new Thread(account.Add);
pool[1] = new Thread(account.Draw);

for (int i = 0; i < pool.Length; i++)
{
    pool[i].Start();
}

for (int i = 0; i < pool.Length; i++)
{
    pool[i].Join();
}


Console.WriteLine(account.Balance);

