using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Roulant
    {
        public int Count { get; set; }
        public abstract void Park();
        public abstract void Unpark();

        public virtual void Do1()
        {
            Console.WriteLine("Do1()");
        }
    }
}
