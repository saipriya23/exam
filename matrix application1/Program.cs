using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_application1
{
    class Program
    {
       public static void Main(string[] args)
            
        {
            int n, m,i,j;
            int r;
           // var s=0;
            Console.WriteLine("enter the values for n");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the values for m");

            m = int.Parse(Console.ReadLine());


            Console.WriteLine("VALUES FOR THE MATRIX ARE");

            int[,] matrix = new int[n, m];
            for(i=0; i<n;i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.WriteLine("Enter the vale for matrix [ "+ i.ToString() + j.ToString() + "]");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }

            }
            
           
             Console.WriteLine("repetition count from user");
             r= int.Parse(Console.ReadLine());

            //flatten here

            var inputList = new List<int>();

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    inputList.Add(matrix[i, j]);
                }
            }

            var count1 = 0;
            var result1 = new List<int>();

            for (int key = 0; key < inputList.Count; key++)
            {
                var initialValue = inputList[key];
                if (!result1.Contains(initialValue))
                {
                    for (int innerKey = 0; innerKey < inputList.Count; innerKey++)
                    {
                        if (key != innerKey)
                        {
                            if (initialValue == inputList[innerKey])
                            {
                                count1 = count1 + 1;
                                if (count1 == r - 1)
                                {
                                    if (!result1.Contains(initialValue))
                                    {
                                        result1.Add(initialValue);
                                    }
                                }
                            }
                        }
                    }
                }
                count1 = 0;
            }


            foreach(var el in result1)
            {
                Console.WriteLine("output {0}", el.ToString());
                Console.ReadLine();
                Console.WriteLine("{0} is repeated {1} times in the matrix", el.ToString(),r);
                Console.ReadLine();
            }
        }
    }
}
