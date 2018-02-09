using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "Tomato",
                "Potato",
                "ToMato",
                "Potato",
                "Red Tomato",
                "Tomato Catchup",
                "Grapes",
                "grapes",
                "potato"
            };
            var check = list.ConvertAll(ar => ar.ToUpper());

            int c = 0;

            foreach (string word in check)
            {
                if (word == "TOMATO")

                    c++;
            }
            Console.WriteLine("The Number of Tomato : " + c);

            for (int i = 0; i < list.Count; i++)
            {

                if (list[i] == "Potato")

                    Console.WriteLine("The index of Potato is " + i);
           }
            Console.ReadKey();
        }

        
       
    }
}
