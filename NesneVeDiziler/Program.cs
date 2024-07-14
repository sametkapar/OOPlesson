using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NesneVeDiziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dizileri Hatırlayalım

            //int[] sayilar = new int[5];
            //sayilar[0] = 15;
            //sayilar[1] = 123;
            //sayilar[2] = -5;
            //sayilar[3] = 7;
            //sayilar[4] = 23;

            //Console.WriteLine(sayilar[3]);
            #endregion

            #region ÖNEMLİ - Hersınıf aslında bir türdür


            //Urun sınıfndan türetilmiş 5 adet ürün nesnesi alabilen dizi
            Urun[] urunler = new Urun[3];

            Urun u = new Urun();
            u.isim = "Domates";
            u.birim = "KG";
            u.fiyat = 48.8;

            urunler[0] = u;

            Urun uu = new Urun();
            uu.isim = "Biber";
            uu.birim = "KG";
            uu.fiyat = 76.4;

            urunler[1] = uu;

            Urun u3 = new Urun();

            u3.isim = "Yumurta";
            u3.birim = "Adet";
            u3.fiyat = 4.25;
            urunler[2] = u3;

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].isim + " " + urunler[i].fiyat + " TL");
            }
            #endregion

            #region BAKKAL UYGULAMASINI CLASS ta YAPINIZ

            #endregion

            #region En az 10 soruluk ödev yapacaz. çoktan seçmeli


            #endregion



        }
    }
}
