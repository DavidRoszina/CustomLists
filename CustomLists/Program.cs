using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLists
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> testList = new CustomList<int>();

            testList.Add(5);
            testList.Add(15);
            testList.Add(25);
            testList.Add(35);
            testList.Add(45);
        }
    }
}
