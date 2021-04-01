using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface Vehicule
    {
        void MooveTo(int[] coordinate);
        void Speed(int speed);
    }
}
