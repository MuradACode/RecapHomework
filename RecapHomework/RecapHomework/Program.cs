using RecapHomework.Models;
using System;
using System.Collections.Generic;

namespace RecapHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCustomList<string> customStringList = new MyCustomList<string>();
            MyCustomList<int> customIntList = new MyCustomList<int>(5);
        }
    }
}
