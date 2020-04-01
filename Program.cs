using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.Write("Please enter a number:");
            int len = int.Parse(Console.ReadLine());
            int[] x = new int[len];
            for (int e = 0; e < len; e++)
            {
                x[e] = new Random().Next(0, 100);
                Console.Write(x[e] + " ");
            }
            int min = x[0], max = x[0], sum = 0, mid = 0;
            System.Console.WriteLine("\nNot muchs numbers:");
            foreach (var a in x)
            {
                min = a < min ? a : min;
                max = a > max ? a : max;
                sum += a;
                mid += a;
                if (a % 2 != 0)
                {
                    Console.Write(a + " ");
                }
            }
            mid /= len;
            Console.WriteLine($"\nmin: {min}");
            Console.WriteLine($"max {max}");
            Console.WriteLine($"sum {sum}");
            Console.WriteLine($"mid {mid}");
            //2
            Console.Write("Enter length of array:");
            len = int.Parse(Console.ReadLine());
            int[] o = new int[len];
            for (int z = 0; z < len; z++)
            {
                Console.Write("Enter some number:");
                o[z] = int.Parse(Console.ReadLine());
            }
            int t = 0;
            for (int z = (len - 1); z >= (len / 2); z--)
            {
                int h = o[z];
                o[z] = o[t];
                o[t] = h;
                t++;
            }
            foreach (var item in o)
            {
                Console.Write(item + " ");
            }
            //3
            Console.WriteLine("Enter value for length:");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter value for index:");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for count:");
            int ln = int.Parse(Console.ReadLine());
            int[] arr = new int[count];
            for (int e = 0; e < count; e++)
            {
                arr[e] = new Random().Next(0, 100);
                Console.Write(arr[e] + " ");
            }
            System.Console.WriteLine();
            int[] narr = new int[ln];
            int r = 0;
            for (int w = index; w < count; w++)
            {
                narr[r] = arr[w];
                r++;
            }
            for (int w = 0; w < narr.Length; w++)
            {
                Console.Write(narr[w]+" ");
            }
            Console.ReadKey();
        }
    }
}
