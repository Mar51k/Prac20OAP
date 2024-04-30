using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac20
{
    class Program
    {
        static void Main(string[] args)
        {

            PC pc1 = new PC(3.4, 25.9, 21.4, 16);

            pc1.Print();

            pc1.Change(5.8, 64);

            pc1.Change(28);

            pc1.Diagonal_Change(23.8);

            Server server1 = new Server(10.2, 2048.9, 48.2, 128, 25);

            server1.Print();

            server1.Change(256);

            server1.Diagonal_Change(69.2);

            server1.Change(20.3, 512);

            server1.DisksChange(50);


            Console.ReadKey();
        }
    }
}
