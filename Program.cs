using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp90
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            Player player = new Player(10, 10);

            renderer.DrawPlayer(player.X, player.Y);
        }
    }
    
    class Renderer
    {
        public void DrawPlayer(int x,int y, char player = '$') 
        {
            Console.SetCursorPosition(x,y);
            Console.Write(player);
        }
    }

    class Player 
    {
        private int _x;
        private int _y;

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }

        public int Y { get; private set; }
    }
}
