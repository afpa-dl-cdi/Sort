using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a insertion sort
            int[] tableau = { 5, 9, 4, 2, 10, 1, 7 };
            Dis.Play<int>(tableau);
            InsertionSort.Sort(tableau);
            Dis.Play<int>(tableau);
        }
    }
}
