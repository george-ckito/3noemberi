using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3noemberi
{
    internal class Car : ITurn, IControl
    {
        public void left()
        {
            Console.WriteLine("Car is turning left");
        }

        public void right()
        {
            Console.WriteLine("Car is turning right");
        }

        public void start()
        {
            Console.WriteLine("Car is starting");
        }

        public void stop()
        {
            Console.WriteLine("Car is stopping");
        }
    }
}
