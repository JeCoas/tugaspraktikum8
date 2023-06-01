using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Orang
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Orang(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public Orang()
        {

        }

        // Method
        public void InfoOrang()
        {
            Console.WriteLine("Nama saya {0} dan umur saya {1} tahun.", this.Name, this.Age);
        }
    }

    // Anak Kelas
    public class Karyawan : Orang
    {
        // Properties
        public string KaryawanID { get; set; }
        public string Subject { get; set; }

        // Constructor
        public Karyawan(string KaryawanID, string Subject)
        {
            this.KaryawanID = KaryawanID;
            this.Subject = Subject;
        }
        public Karyawan()
        {

        }

        // Override Method
        public void InfoOrang(string Subject, string KaryawanID)
        {
            this.Subject = Subject;
            this.KaryawanID = KaryawanID;
            Console.WriteLine("Saya disini menjabat sebagai {0} dengan ID Karyawan {1}.", this.Subject, this.KaryawanID);
        }
    }
}