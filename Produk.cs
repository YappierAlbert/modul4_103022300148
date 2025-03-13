using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300148
{
    internal class Produk
    {
        String[] nama = { "Laptop","Smartphone","Tablet", "Headset", "Keyboard", "Mouse", "Printer", "Monitor", "Smartwatch", "Camera" };
        String[] kode = { "E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109" };
        public String getKodeProduk(String input) {
            for (int i = 0; i < nama.Length; i++)
            {
                if (input.Equals(nama[i]))
                {
                    return kode[i];
                }
            }

            return "Tidak ditemukan";
        }
    }
}
