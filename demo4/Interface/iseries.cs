using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4.Interface
{
    public interface iseries
    {
        public int current {  get; set; }
        public void getnext();
        public void reset()
        {
            current = 0;
        }
    }
}
