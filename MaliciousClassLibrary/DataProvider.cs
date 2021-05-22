using System;

namespace LegitClassLibrary
{
    public class DataProvider
    {
        public DataProvider()
        {
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("|  The malicious data provider  |");
            Console.WriteLine("+-------------------------------+");
        }
        public static string getUniquePersonalId()
        {
            return "you are hacked !";
        }
    }
}
