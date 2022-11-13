using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ConsoleApp6_NET
{
    internal class Program
    {
        
        class THrac
        {
            public int poziceX, poziceY;
            public char znak;

            int x = 0;
            int y = 0;
            void Vykresli(int x, int y, int i, char a)
            {            

                Console.SetCursorPosition(x, y);
                Console.WriteLine(a);
                Console.SetCursorPosition(x, y);
            }

            void Smaz(int x, int y)
            {                               

                Console.SetCursorPosition(x, y);
                Console.WriteLine(' ');
                Console.SetCursorPosition(x, y);
            }

            public void Prekresli(int NoveX, int NoveY, int i, char a)
            {
                Smaz(x, y);
                x = NoveX;
                y = NoveY;

                Vykresli(x, y, i, a);
                Thread.Sleep(100);
            }

        };
        
        [STAThread]
        static void Main(string[] args)
        {
            THrac Hrac = new THrac();
            Hrac.poziceX = 10;
            Hrac.poziceY = 10;
            Hrac.znak = '#';
            
            Console.SetCursorPosition(Hrac.poziceX, Hrac.poziceY);
            Console.WriteLine(Hrac.znak);
            
            
            while (true)
            {
                if (Keyboard.IsKeyDown(System.Windows.Input.Key.A))
                {
                    Hrac.Prekresli(Hrac.poziceX--, Hrac.poziceY, 1, '#');

                }
                if (Keyboard.IsKeyDown(System.Windows.Input.Key.S))
                {
                    Hrac.Prekresli(Hrac.poziceX, Hrac.poziceY++, 1, '#');
                    
                }
                if (Keyboard.IsKeyDown(System.Windows.Input.Key.W))
                {
                    Hrac.Prekresli(Hrac.poziceX, Hrac.poziceY--, 1, '#');

                }
                if (Keyboard.IsKeyDown(System.Windows.Input.Key.D))
                {
                    Hrac.Prekresli(Hrac.poziceX++, Hrac.poziceY, 1, '#');

                }
                if (Keyboard.IsKeyDown(System.Windows.Input.Key.Space))
                {
                    return;
                }
                
            }
        }
    }
}