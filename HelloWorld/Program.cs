using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetCursorPosition(10, 10);
            Console.Write("Hello,World!!!");
            Console.SetCursorPosition(10, 11);
            Console.Write("С# DotNet FrameWork Platform!!!");
            Console.ReadKey();
        }
    }
}
