using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJamMurderMystery.Events
{
    internal class SampleEvent : Event
    {
        public override string Prompt
        {
            get
            {
                return "Sample Event";
            }
        }

        public override Event RunEvent()
        {
            Console.WriteLine("Hello World.");
            Console.WriteLine("You feel you should pick some option.");
            Menu menu = new Menu(new SampleEvent());
            return menu.Choose();
        }
    }
}
