using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehaMarket
{
    public class Program
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
                        Console.Clear();
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
                        Console.WriteLine();
                        Console.WriteLine("ÜRÜN EKLEME İŞLEMİNE DEVAM ETMEK İSTER MİSİNİZ? E/H ");
                        secim = Console.ReadLine();
                        secim.ToLower();

                    }

                }
                else if (secenek == "2")
                {
                    Console.Clear();

                    Urun urun = new Urun();

                    Console.WriteLine(urun.FiyatGuncelle());
                    Console.Clear();
                }
                else if (secenek == "3")
                {
                    Console.Clear();

                    Urun urun = new Urun();

                    Console.WriteLine(urun.StokGuncelle());
                    Console.Clear();
                }
            }
            else if (secenek == "2")
            {
                Depo s = new Depo();
                Urun[] u = s.UrunEkle();
                string urunTopla = "";
                double toplam = 0;
                while (secim == "e")
                {
                    for (int i = 0; i < u.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}-) {u[i].ad}({u[i].birim})   \t = {u[i].fiyat}TL\t   \t Kalan Stok Miktarı {u[i].stok}");
                    }
                    Console.WriteLine("ALMAK İSTEDİĞİNİZ ÜRÜNÜ TUŞLAYINIZ");
                    int uruno = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Kaç {u[uruno - 1].birim} {u[uruno - 1].ad} Almak İstersiniz?");
                    int kacBirim = Convert.ToInt32(Console.ReadLine());
                    if (u[uruno - 1].stok >= kacBirim)
                    {
                        double fiyatTopla = u[uruno - 1].fiyat * kacBirim;
                        u[uruno - 1].stok = u[uruno - 1].stok - kacBirim;
                        urunTopla = ($"{kacBirim} {u[uruno - 1].birim} ") + (u[uruno - 1].ad) + "\n" + urunTopla;
                        toplam = (u[uruno-1].fiyat * kacBirim) + toplam;
                        Console.WriteLine($"{kacBirim} {u[uruno - 1].birim} {u[uruno - 1].ad} Ürünü {fiyatTopla} TL. \n Başka Ürün Almnak İster misiniz? E/H");
                        secim = Console.ReadLine();
                        Console.Clear();
                    }
                    else if (u[uruno - 1].stok < kacBirim)
                    {
                        Console.WriteLine("Seçilen Üründe İstediğiniz Miktarda Ürün Bulunamamaktadır. ALışverişe Devam Etmek İster misiniz? E/H ");
                        secim = Console.ReadLine();
                        Console.Clear();
                    }
                }
                Console.WriteLine($"ALDIĞINIZ ÜRÜNLER\n{urunTopla} {toplam} TL\nBizi Tercih Ettiğiniz İçin Teşekkürler :)");
            }
            else
            {
                Console.WriteLine("YANLIŞ TUŞLAMA YAPTINIZ \n TEKRAR GİRİŞ EKRANINA DÖNMEK İSTER MİSİNİZ ? e/h ");
                secim = Console.ReadLine();
            }
        }
    }
}
