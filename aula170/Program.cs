﻿using System.Linq;

namespace aula170;

class Program
{
    static void Main(string[] args)
    {
        //specify the data source
        int[] numbers = new int[] { 2, 3, 4, 5};

        //Define the query expression
        var result = numbers.Where(x => x%2 == 0).Select(x => x * 10);

        //Execute the query

        foreach (int x in result)
        {
            System.Console.WriteLine(x);
        }
        
    }
}
