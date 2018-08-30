using System;
using System.Collections.Generic;

namespace Lab1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value");
            String input1 = Console.ReadLine();
            int num1;
            int.TryParse(input1, out num1);

            //validation is used so exceptions are through

            while (!int.TryParse(input1, out num1))
            {
                Console.WriteLine("Invalid! Please enter a value");
                input1 = Console.ReadLine();
                int.TryParse(input1, out num1);
            }
            num1 = Convert.ToInt16(input1);

            Console.WriteLine("Please enter a value");
            String input2 = Console.ReadLine();
            int num2;
            int.TryParse(input2, out num2);

            //validation is used so exceptions are through

            while (!int.TryParse(input2, out num2))
            {
                Console.WriteLine("Invalid! Please enter a value");
                input2 = Console.ReadLine();
                int.TryParse(input2, out num2);
            }
            num2 = Convert.ToInt16(input2);

            List<int> listNum1 = new List<int>();
            while (num1 > 0)
            {
                listNum1.Add(num1 % 10);
                num1 = num1 / 10;
            }

            List<int> listNum2 = new List<int>();
            while (num2 > 0)
            {
                listNum2.Add(num2 % 10);
                num2 = num2 / 10;
            }

            //Array used to compare the two lists
             
            int[] listArray = new int[listNum1.Count];
            for (int i = 0; i < listNum1.Count; i++)
            {
                listArray[i] = listNum1[i] + listNum2[i];

            }
            string result = "";
            for (int i = 0; i < listArray.Length - 1; i++)
            {
                if (listArray[i] == listArray[i + 1])
                {
                    result = "True";
                }
                else
                {
                    result = "False";
                }
            }
            Console.WriteLine(result);
        }
    }
}
