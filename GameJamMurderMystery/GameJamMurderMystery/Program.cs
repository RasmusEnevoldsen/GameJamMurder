using GameJamMurderMystery.Events;

namespace GameJamMurderMystery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new SampleEvent().Execute();
        }
    }
}