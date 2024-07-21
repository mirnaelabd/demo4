using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4.Interface
{
    public class Car : Vehicle, IMoveable
    {
        public void backward()
        {
            Console.WriteLine("move backward on ground ");
        }

        public void forward()
        {
            throw new NotImplementedException();
        }

        public void left()
        {
            throw new NotImplementedException();
        }

        public void right()
        {
            throw new NotImplementedException();
        }
    }

}
