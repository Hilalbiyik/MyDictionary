using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dersler = new MyDictionary<int, string>();
            dersler.Add(223, "Sayısal Bilgisayar Tasarımı");
            dersler.Add(311, "Bilgisayar Mimarisi");
            dersler.Add(323, "Web Tabanlı Programlama");

            Console.Write("Seçilen dersler : ");

            Console.WriteLine(dersler.Count);
            dersler.Show();
            Console.ReadLine();
        }
    }
}