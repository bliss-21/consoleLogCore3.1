using System;

namespace ConsolaLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Log log = new Log(@"C:\Users\elias\source\repos\log");
            log.Add("Hola Mundo");
        }
    }
}
