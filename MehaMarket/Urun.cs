﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehaMarket
{
    public class Urun
    {
        public string ad;
        public string birim;
        public double fiyat;
        public int stok;
        public double kdv;

        public Urun[] FiyatGuncelle()
        {
            string secim = "e";
            int secenek = 0;
            Depo d = new Depo();
            Urun[] u = d.UrunEkle();
            while (secim == "e")
            {
                for (int i = 0; i < u.Length; i++)
                {
                    Urun urun = new Urun();
                    Console.WriteLine($"{i + 1}-) {u[i].ad}");

                }

                Console.WriteLine("GÜNCELLEMEK İSTEDİĞİNİZ ÜRÜNÜ SEÇİNİZ");
                secenek = Convert.ToInt32(Console.ReadLine());
                Console.Write($"{u[secenek-1].ad} Ürünü İçin Güncel Fiyat Belirleyiniz : " );
                u[secenek-1].fiyat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("GÜNCELLEMEK İSTEDİĞİNİZ BAŞKA ÜRÜN VAR MI? E/H");
                secim = Console.ReadLine();
                secim.ToLower();
                Console.Clear();
                Console.WriteLine("Teşekkürler");
            }
            return u;
        }
    }
}
