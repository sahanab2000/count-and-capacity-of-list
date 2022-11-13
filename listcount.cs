using System;
using System.Collections.Generic;
class program
{
    public static void Main()
    {

        
        List<int> firstlist = new List<int>();

        for (int i = 1; i < 10; i++)
        {
            firstlist.Add(i * 2);
        }


        Console.WriteLine(firstlist.Count);
    }
}
