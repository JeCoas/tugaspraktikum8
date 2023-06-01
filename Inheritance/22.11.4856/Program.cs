using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Orang Orang1 = new Orang();
            Orang1.Name = "Ecanto Rusdy Hassan";
            Orang1.Age = 19;
            Orang1.InfoOrang();
            Console.WriteLine();

            // Inheritance
            Karyawan Karyawan1 = new Karyawan();
            Karyawan1.Name = "Jose Husein";
            Karyawan1.Age = 34;
            Karyawan1.InfoOrang();
            Karyawan1.InfoOrang("Dekan", "DKN119923");

            Console.ReadLine();
        }
    }
}