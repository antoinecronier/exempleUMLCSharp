using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Voiture : Roulant, Vehicule
    {
        public void MooveTo(int[] coordinate)
        {
            throw new NotImplementedException();
        }

        public override void Park()
        {
            throw new NotImplementedException();
        }

        public void Speed(int speed)
        {
            throw new NotImplementedException();
        }

        public override void Unpark()
        {
            throw new NotImplementedException();
        }

        public override void Do1()
        {
            base.Do1();
            Console.WriteLine("Hello world");
        }
    }
}
