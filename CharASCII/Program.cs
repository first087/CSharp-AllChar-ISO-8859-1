using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharASCII {
    class Program {
        static void Main(string[] args) {
            Encoding iso_8859_1 = Encoding.GetEncoding(1252);
            Encoding utf8       = Encoding.UTF8;

            for (int i = 0; i < byte.MaxValue + 1; i++) {
                byte[] byteISO = new byte[] { (byte)i };
                string strISO = iso_8859_1.GetString(byteISO);
                byte[] byteUTF8 = Encoding.Convert(iso_8859_1, utf8, byteISO);
                string strUTF8 = utf8.GetString(byteUTF8);
                Console.WriteLine("i = {0}, ISO-8859-1 = {1}, UTF8 = {2}", i, strISO, strUTF8);
            }

            Console.ReadKey();
        }
    }
}
