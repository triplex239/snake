using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1, y1 = 3;
            char symb1 = '*';

            Draw(x1, y1, symb1);

            int x2 = 4, y2 = 5;
            char symb2 = '#';

            Draw(x2, y2, symb2);
        }

        static void Draw(int x, int y, char symb)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
    }
}
