using MyDictionaryClass;
using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> sehirler = new MyDictionary<string, string>();

            sehirler.Add("06", "Ankara");
            sehirler.Add("34", "İstanbul");
            sehirler.Add("35", "İzmir");

            sehirler.sehirler();
            
        }
    }
}
