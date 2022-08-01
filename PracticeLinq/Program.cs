using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> GameNames = new List<string> { "GTA", "RDR2", "Bully", "Spongebob", "Endless Ocean" };

            var LongGameNames =
                GameNames.OrderBy(x => x.Length);

            foreach (var Length in GameNames) 

            {
                Console.WriteLine(Length);
            }


        }
        
    }
}
