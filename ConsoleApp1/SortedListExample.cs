using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class SortedListExample
    {

        static void Main(string[] args)
        {
            SortedListMain sortedListMain = new SortedListMain();
            sortedListMain.LoadSortedList();

        }
    }

    class SortedListMain 
    {
        public SortedList LoadSortedList()
        {
            SortedList sortedList = new SortedList() { { "SA1", "Value1" }, { "SA2", "Value2" } };
            return sortedList;

        }
    
    }
}
