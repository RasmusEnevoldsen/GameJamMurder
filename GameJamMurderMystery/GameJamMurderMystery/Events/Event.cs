using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJamMurderMystery.Events
{
    public abstract class Event
    {
        public abstract string Prompt { get; }

        public abstract Event RunEvent();
        public void Execute()
        {
            RunEvent().Execute();
        }
    }
}
