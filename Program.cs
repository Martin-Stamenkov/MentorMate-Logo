using System;
using System.Text;

namespace MM_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var engine = new Engine(n);
            engine.Draw(n);               
        }
    }
}
