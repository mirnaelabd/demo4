using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4.Interface
{
    internal class Airplane : Vehicle, IMoveable, IFlyable
    {
        void IMoveable.backward()
        {
            Console.WriteLine("MOVING backward on ground "); 

        }

        void IFlyable.backward()
        {
            Console.WriteLine("MOVING backward on sky ");
        }

        void IMoveable.forward()
        {
            Console.WriteLine("MOVING forward on ground ");
        }

        void IFlyable.forward()
        {
            Console.WriteLine("MOVING forward on sky ");
        }

        void IMoveable.left()
        {
            Console.WriteLine("MOVING left on ground ");
        }

        void IFlyable.left()
        {
            Console.WriteLine("MOVING left on sky ");
        }

        void IMoveable.right()
        {
            Console.WriteLine("MOVING right on ground ");
        }

        void IFlyable.right()
        {
            Console.WriteLine("MOVING right on sky ");
        }
    }
}
