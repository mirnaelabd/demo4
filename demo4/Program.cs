
using demo4.ICloneable_interface;
using demo4.ICloneable_interface;
using demo4.Interface;

namespace demo4
{
    internal class Program
    {
        public static void print10NumberformSeries(iseries series)
        {
            if (series != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{series.current} ");
                    series.getnext();
                }
                series.reset();
            }
        }
        static void Main()
        {
            #region interfac 

            /*
                        Mytype mytype=new Mytype();
                        mytype.id = 30;
                        mytype.Myfun(100);
                        // mytype.print(); /// invalid -> default impelemented method 
                        ////////////////////////////////////////
                        IMytype type = new Mytype();
                        type.id = 60; 
                        type.Myfun(100);
                        type.print();   */
            #endregion

            #region example 1 
            // 0 2 4 6 8 10
            /*     Seriesby2 seriesby2 = new Seriesby2();
                 print10NumberformSeries(seriesby2);
                 Console.WriteLine("/////////////////////////////////////"); 
                 seriesby3 seriesby3 = new seriesby3();
                 print10NumberformSeries(seriesby3);
                 Console.WriteLine("/////////////////////////////////////");
     */


            #endregion

            #region example 2 
            /*   Car car = new Car();
               car.backward();
               Console.WriteLine("///////////////////////////////////"); 
              Airplane airplane = new Airplane();
               //  airplane.forward();
               IMoveable moveable = new Airplane();
               moveable.forward();
               IFlyable flyable =new Airplane();
               flyable.forward();*/
            #endregion

            #region shallow copy & depp copy 

            /*          int[] arr1 = { 1, 2, 3, 4, 5 };
                      int[] arr2 = new int[5];
          */

            #region shallow copy 
            /* Console.WriteLine($"  of arr 1 :{arr1.GetHashCode()}");
             Console.WriteLine($" of arr 2 : {arr2.GetHashCode()} ");

             arr2 = arr1;
             Console.WriteLine($"{arr1[0]}");
             Console.WriteLine($"{arr2[0]}");
             arr1[0] = 100;
             Console.WriteLine("after set arr1 = 100");
             Console.WriteLine($"{arr1[0]}");
             Console.WriteLine($"{arr2[0]}");*/
            #endregion
            #region deep copy 
            /*     arr2 = (int[])arr1.Clone();
                 Console.WriteLine($"  of arr 1 :{arr1.GetHashCode()}");
                 Console.WriteLine($" of arr 2 : {arr2.GetHashCode()} ");
                 Console.WriteLine($"{arr1[0]}");
                 Console.WriteLine($"{arr2[0]}");
                 arr1[0] = 100;
                 Console.WriteLine("after set arr1 = 100");
                 Console.WriteLine($" arr 1 : {arr1[0]}");
                 Console.WriteLine($" arr 2 : {arr2[0]}");*/


            #endregion
            #endregion

            #region 1,2,3 user defiend (shallow , deep copy)
          /*  employee employee1 = new employee() { id = 233, name = "ahmed ", age = 23 };

            employee employee2 = new employee() { id = 234, name = "mirna ", age = 22 };*/
         /*   Console.WriteLine($"the hash code of emp 1 {employee1.GetHashCode()} ");
            Console.WriteLine($"emp 1 : {employee1}");
            Console.WriteLine($"the hash code of emp 2 {employee2.GetHashCode()} ");
            Console.WriteLine($"emp 2 : {employee2}");*/

            #region shallow copy 
            /*     employee2 = employee1; // id = 233, name = "ahmed ", age = 23 
                 Console.WriteLine("after /////");
                 Console.WriteLine($"the hash code of emp 1 {employee1.GetHashCode()} ");
                 Console.WriteLine($"emp 1 : {employee1}");
                 Console.WriteLine($"the hash code of emp 2 {employee2.GetHashCode()} ");
                 Console.WriteLine($"emp 2 : {employee2}");*/

            #endregion

            #region deep_copy 
            /*employee2 =(employee) employee1.Clone();

            Console.WriteLine("after deep copy ");
            Console.WriteLine($"the hash code of emp 1 {employee1.GetHashCode()} ");
            Console.WriteLine($"emp 1 : {employee1}");
            Console.WriteLine($"the hash code of emp 2 {employee2.GetHashCode()} ");
            Console.WriteLine($"emp 2 : {employee2}");
            employee1.age = 23;
            employee1.name = "omar";
            employee1.id = 9;

            Console.WriteLine("after edit");
            Console.WriteLine($"the hash code of emp 1 {employee1.GetHashCode()} ");
            Console.WriteLine($"emp 1 : {employee1}");
            Console.WriteLine($"the hash code of emp 2 {employee2.GetHashCode()} ");
            Console.WriteLine($"emp 2 : {employee2}");*/


            #endregion

            #region construtor

/*            employee2 = new employee(employee1);
            Console.WriteLine("after deep copy ");
            Console.WriteLine($"the hash code of emp 1 {employee1.GetHashCode()} ");
            Console.WriteLine($"emp 1 : {employee1}");
            Console.WriteLine($"the hash code of emp 2 {employee2.GetHashCode()} ");
            Console.WriteLine($"emp 2 : {employee2}");*/

            #endregion
            #endregion



        }
    }
}
