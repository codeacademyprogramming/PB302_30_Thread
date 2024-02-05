using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceConditionLesson
{
    internal class Account
    {
        public int Balance = 0;
        private object _balanceLock = new object();

        public void Add()
        {
            lock (_balanceLock)
            {
                for (int i = 0; i < 10000000; i++)
                {
                    Balance++;
                }
            }
        }

        public void Draw()
        {
            lock (_balanceLock)
            {
                for (int i = 0; i < 10000000; i++)
                {
                    Balance--;
                }
            }
        }
    }
}
