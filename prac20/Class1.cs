using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac20
{
    internal class PC
    {
        public double CPU;
        public double Disk_Memory;
        public int DDR;
        public double Diagonal; //задаётся в дюймах

        public PC(double CPU, double Memory, double Diagonal, int ddr)
        {
            DDR = ddr;
            this.CPU = CPU;
            Disk_Memory = Memory;
            this.Diagonal = Diagonal;
        }

        public string Print()
        {
            Console.WriteLine($"Компьютер\nТактовая частота процессорв: {CPU}\nОбъём винчестра: {Disk_Memory}\nОбъём оперативной памяти: {DDR}\nДиагональ монитора(в дюймах): {Diagonal}\n");
            return "";
        }
        public string Diagonal_Change(double diagonal)
        {
            Diagonal = diagonal;
            //Console.WriteLine($"Новая диагональ монитора: {Diagonal}");
            Print();
            return "";
        }
        public string Change(double cpu, int ddr)
        {
            DDR = ddr;
            CPU = cpu;
            //Console.WriteLine($"Новая тактовая частота процессора: {CPU}");
            Print();
            return "";
        }
        public string Change(int ddr)
        {
            DDR = ddr;
            Print();
            return "";
        }

    }
}
