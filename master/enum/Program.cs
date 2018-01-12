using System;

namespace @enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine((int)Week.Monday);
            Array array1 = Enum.GetNames(typeof(Week));
            Array array2 = Enum.GetValues(typeof(Week));
           // Week day = array2[0];
            foreach (int i in Enum.GetValues(typeof(Week)))
                Console.WriteLine(i);
        }
    }
   public enum Week
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Sunday = 0,
        Everyday = 1　　//成员的值可以设置成一样的，但是成员不行
    }
}
//http://www.cnblogs.com/kissdodog/archive/2013/01/16/2863515.html