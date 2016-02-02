using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Teh05
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            bool switchBot;

            Radio radio = new Radio();
            radio.IsOn = false;
            radio.Volume = 4;
            radio.Freq = 1000.0;
            
            do
            {
                Console.WriteLine("0. Leave the radio off");
                Console.WriteLine("1. Turn the radio on");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        switchBot == false;
                        Console.WriteLine("Radio is off");
                        break;
                    case 1:
                        switchBot == true;
                        Console.WriteLine("Radio is on");
                        Console.WriteLine("Frequency: " + radio.Freq + " Volume: " + radio.Volume);
                        Console.WriteLine("Set the frequency & Volume to the favorite");
                        break;
                }
                

            } while (radio.IsOn == false);


        }
    }
}
