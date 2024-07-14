using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneYonelimliProgramOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Otomobil oto = new Otomobil(); //Nesne
            oto.marka = "Toyota";
            oto.model = "Corolla AE 86";
            oto.fiyat = 50000000;
            Console.WriteLine(oto.marka + " " + oto.model + " "+ oto.fiyat + " TL");

            Otomobil oto2 = new Otomobil(); //Nesne
            oto2.marka = "Toyota";
            oto2.model = "Hilux Invincible";
            oto2.fiyat = 29000000;
            Console.WriteLine(oto2.marka + " " + oto2.model + " " + oto2.fiyat + " TL");

            Insan ins = new Insan();
            ins.isim = "Samet";
            ins.soyisim = "Kapar";
            ins.yas = 45;

            Console.WriteLine($"isim={ins.isim}\nSoyisim={ins.soyisim}\nYaş={ins.yas}");
        }
    }
    class Otomobil//Sınıf
    {
        public string marka; //fielad
        public string model;
        public double fiyat;
        double alisFiyat; //Sadece ait olduğu sınıfta erişilebilir
        //privet double alisFiyat;
    }

}
