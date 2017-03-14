using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Teh1_Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            int times;
            int diceFace;

            Console.WriteLine("How many times do you throw dice? >");
            times = int.Parse(Console.ReadLine());
            
            Dice dice = new Dice();
            List<int> dicefaces = new List<int>();

            for (int i=0; i< times; i++)
            {
                diceFace = dice.Throw(); // 1-6
                dicefaces.Add(diceFace);
                
                    
            }
            Console.WriteLine("Dice is now thrown {0} times, Average is : {1}", times, dicefaces.Average());

            /*foreach (int d in dicefaces)
            {
                Console.WriteLine(d + ",");
            }*/

        }
    }
}
