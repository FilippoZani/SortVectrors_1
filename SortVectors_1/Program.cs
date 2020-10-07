using System;

namespace SortVectors_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];
            for(int i = 0; i < vector.Length; i++)
            {
                Random r = new Random();
                vector[i] = r.Next(0, 3);
                Console.WriteLine(vector[i]);
            }
        }
    }
}
