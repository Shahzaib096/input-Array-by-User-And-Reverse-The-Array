using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_Array_by_User_And_Reverse_The_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input Size by User
            Console.Write("Please Enter Size of Array : ");
            int sizeOfArray = int.Parse(Console.ReadLine());
            //Declear Array
            int[] myArray = new int[sizeOfArray];
            //Input Array By User
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }
            //Display Array Size 
            Console.WriteLine("Array Size is :" + sizeOfArray);
            //Display Array Elements 
            Console.WriteLine("Array Elemnets :");
            foreach (int item in myArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //Reversed Array
            int[] reversed = new int[sizeOfArray];
            for(int i=0; i<myArray.Length;i++)
            {
                reversed[myArray.Length-i-1]= myArray[i];
            }
            Console.WriteLine("Reversed Array ");
            for(int i=0; i<myArray.Length;i++)
            {
                Console.Write(reversed[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
