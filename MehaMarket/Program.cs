using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehaMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secim = "e";
            string sifre = "15963";
            Depo d = new Depo();
            Console.WriteLine("                         0_0  MEHA MARKETE HOŞGELDİNİZ  0_0   ");
            Console.WriteLine("1-) KULLANICI EKRANI GİRİŞ\n2-) MÜŞTERİ EKRANI GİRİŞ");
            string secenek = Console.ReadLine();
            Console.Clear();
            if (secenek == "1")
            {
                Console.WriteLine("Sayın Kullanıcı, Lütfen Devam Etmek İçin Şifre Giriniz");
                sifre = Console.ReadLine();
                while (sifre != "15963")
                {
                    Console.WriteLine("Yanlış Tuşlama Yaptınız, Tekrar Deneyiniz..");
                    sifre = Console.ReadLine();
                    Console.Clear();
                }
                Console.WriteLine("GİRİŞ BAŞARILI");
                Console.Clear();
                Console.WriteLine("YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ\n1-)Ürün Ekle\n2-)Ürün Fiyat Güncelle\n3-)Ürün Stok Güncelle");
                secenek = Console.ReadLine();
                while (secenek != "1" && secenek != "2" && secenek != "3")
                {
                    Console.WriteLine("YANLIŞ TUŞLAMA YAPTINIZ TEKRAR DENEYİNİZ");
                    secenek = Console.ReadLine();
                }
                if (secenek == "1")
                {
                    while (secim == "e")
                    {
                        Urun[] u = d.UrunEkle();
                        Urun[] gecici = new Urun[u.Length + 1];
                        Array.Copy(u, gecici, u.Length);
                        Urun urun = new Urun();
                        Console.Write("Ürün Adı Giriniz : ");
                        urun.ad = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Ürün Birimini Giriniz : ");
                        urun.birim = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Ürün Fiyatını Giriniz : ");
                        urun.fiyat = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Stok Adetini Giriniz : ");
                        urun.stok = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("KDV %sini Giriniz : ");
                        urun.kdv = Convert.ToDouble(Console.ReadLine());

                    }

                }
                else if (secenek == "2")
                {

                }
                else if (secenek == "3")
                {

                }

            }
            else if (secenek == "2")
            {

            }
            else
            {
                Console.WriteLine("YANLIŞ TUŞLAMA YAPTINIZ \n TEKRAR GİRİŞ EKRANINA DÖNMEK İSTER MİSİNİZ ? e/h ");
                secim = Console.ReadLine();
            }
        }
    }
}
