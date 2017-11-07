using System;

namespace @delegate
{
    class Program
    {
        static public bool CheckIsInt32(int pars)//被封装的方法
        {
            return pars == 5;
        }

        static void Main(string[] args)
        {

            Func<int, bool> myFunc = null;
            myFunc = x => CheckIsInt32(x);
            bool liz = myFunc(5);
            Console.WriteLine(liz);
            Console.ReadKey();

        }
    }
}