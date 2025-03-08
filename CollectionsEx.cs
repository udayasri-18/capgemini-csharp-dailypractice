using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace M1Prep
{
    class CollectionsEx
    {
        public void arrayEx()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("we are");
            arrayList.Add("learning");
            arrayList.Add(true);

            bool isTrue = (bool)arrayList[2];
            //List<int> list = new List<int>();
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
        }
        public void Display()
        {
            int[] numbers = new int[5];
            int length = numbers.Length;
            int min = 0;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Enter the value for numbers[{i}]");
                numbers[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    min = numbers[0];
                }
            }
        }
        //public static void Main(string[] args)
        //{
        //    CollectionsEx collections = new CollectionsEx();
        //    //collections.Display();
        //    collections.arrayEx();
        //}
    }
}
