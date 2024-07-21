using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4.ICloneable_interface
{
    internal class employee : ICloneable
    {
        public int id {  get; set; }
        public string name { get; set; }
        public int age { get; set; }

        // copy constructor 
        public employee(employee employee) 
        {
            id = employee.id;
            name = employee.name;
            age = employee.age;
        } 
        public employee()
        {

        }
        public override string ToString()
        {
            return $"id = {id} , name = {name} , age = {age} "; 
        }
        public object Clone()
        {
            return new employee()
            {
                id = id,
                name = name,
                age = age
            };

        }
    }
}
