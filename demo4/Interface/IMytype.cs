using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4.Interface
{
     interface IMytype
    {
       //1-signature of property 
       public int id { get; set; }
        //2-signature of method 
        public void Myfun(int X);
        //3-default implemented  [ C# 8.0 ] 
        public void print()
        {
            Console.WriteLine("hello default value ");
        }
    }
}
