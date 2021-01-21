using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> islemler = new MyList<string>();
            islemler.Add("engin");
            Console.WriteLine();
        }
    }
}
