using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehaMarket
{
    public class Depo
    {
        public Urun[] UrunEkle()
        {
            Urun[] u = new Urun[9];
            u[0] = new Urun()
            {
                ad = "Domates",
                birim = "KG",
                fiyat = 14.50,
                stok = 48,
                kdv = 1
            };
            u[1] = new Urun()
            {
                ad = "Biber",
                birim = "KG",
                fiyat = 13.25,
                stok = 30,
                kdv = 1
            };
            u[2] = new Urun()
            {
                ad = "Patlıcan",
                birim = "KG",
                fiyat = 21,
                stok = 51,
                kdv = 1
            };
            u[3] = new Urun()
            {
                ad = "Sigara",
                birim = "Paket",
                fiyat = 33,
                stok = 126,
                kdv = 18
            };
            u[4] = new Urun()
            {
                ad = "Cips",
                birim = "Paket",
                fiyat = 9,
                stok = 211,
                kdv = 8
            };
            u[5] = new Urun()
            {
                ad = "Kahve",
                birim = "Paket",
                fiyat = 3,
                stok = 41,
                kdv = 18
            };
            u[6] = new Urun()
            {
                ad = "Süt  ",
                birim = "LT",
                fiyat = 14,
                stok = 9,
                kdv = 18
            };
            u[7] = new Urun()
            {
                ad = "Kola ",
                birim = "LT",
                fiyat = 25,
                stok = 42,
                kdv = 18
            };
            u[8] = new Urun()
            {
                ad = "su   ",
                birim = "LT",
                fiyat = 3,
                stok = 145,
                kdv = 8,
            };


            return u;
        }
        public Urun[] UrunEkle(Urun urun)
        {
            Urun[] u = new Urun[1];
            u[0] = new Urun()
            {
                ad = urun.ad,
                birim = urun.birim,
                fiyat = urun.fiyat,
                stok = urun.stok,
                kdv = urun.kdv
            };
            return u;
        }
    }
}
