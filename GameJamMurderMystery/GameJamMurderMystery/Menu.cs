using GameJamMurderMystery.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJamMurderMystery
{
    public class Menu
    {
        private Event[] events;

        public Menu(params Event[] events)
        {
            this.events = events;
        }

        public Event Choose()
        {
            if(events.Length > 0)
            {
                if(events.Length == 1)
                {
                    Console.WriteLine("Press any button to " + events[0].Prompt);
                    Console.ReadKey(true);
                    return events[0];
                }
                else
                {
                    for(int i = 0; i < events.Length; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + events[i].Prompt);
                    }
                    int selection;
                    if (events.Length <= 9)
                    {
                        Console.WriteLine("Press a number from 1 to " + events.Length + ".");
                        while (!int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out selection) && selection >= 1 && selection <= events.Length) ;
                    }
                    else
                    {
                        Console.Write("Write in a number from 1 to " + events.Length + " and press ENTER: ");
                        while (!int.TryParse(Console.ReadLine().ToString(), out selection) && selection >= 1 && selection <= events.Length) ;
                    }
                    return events[selection - 1];
                }
            }
            else
            {
                return null;
            }
        }
    }
}
