using demo4.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4.Interface
{
    public class Mytype : IMytype
    {
        public int id {  get; set; }
      

        public void Myfun(int X)
        {
            Console.WriteLine($"x={X}");
        }
    }
}
