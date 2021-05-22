using System;

namespace LegitClassLibrary
{
    public class DataProvider
    {
        private static int? _uid = 99;
        public static string getUniquePersonalId()
        {
            _uid++;
            return "PIuid"+_uid+":"+"random_stuff";
        }
    }
}
