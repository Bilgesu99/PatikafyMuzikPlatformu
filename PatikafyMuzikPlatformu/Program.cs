// Program.cs
using PatikafyMuzikPlatformu;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Şarkıcı nesnelerinden oluşan liste oluşturuyoruz.
        var sarkicilar = new List<Sarki>
        {
            new Sarki { AdiSoyadi = "Ajda Pekkan", MuzikTuru = "Pop", CikisYili = 1968, AlbümSatislari = 20 }, // 20 milyon
            new Sarki { AdiSoyadi = "Sezen Aksu", MuzikTuru = "Türk halk müziği/pop", CikisYili = 1971, AlbümSatislari = 10 }, // 10 milyon
            new Sarki { AdiSoyadi = "Funda Arar", MuzikTuru = "Pop", CikisYili = 1999, AlbümSatislari = 3 }, // 3 milyon
            new Sarki { AdiSoyadi = "Sertab Erener", MuzikTuru = "Pop", CikisYili = 1994, AlbümSatislari = 5 }, // 5 milyon
            new Sarki { AdiSoyadi = "Sıla", MuzikTuru = "Pop", CikisYili = 2009, AlbümSatislari = 3 }, // 3 milyon
            new Sarki { AdiSoyadi = "Serdar Ortaç", MuzikTuru = "Pop", CikisYili = 1994, AlbümSatislari = 10 }, // 10 milyon
            new Sarki { AdiSoyadi = "Tarkan", MuzikTuru = "Pop", CikisYili = 1992, AlbümSatislari = 40 }, // 40 milyon
            new Sarki { AdiSoyadi = "Hande Yener", MuzikTuru = "Pop", CikisYili = 1999, AlbümSatislari = 7 }, // 7 milyon
            new Sarki { AdiSoyadi = "Hadise", MuzikTuru = "Pop", CikisYili = 2005, AlbümSatislari = 5 }, // 5 milyon
            new Sarki { AdiSoyadi = "Gülben Ergen", MuzikTuru = "Pop", CikisYili = 1997, AlbümSatislari = 10 }, // 10 milyon
            new Sarki { AdiSoyadi = "Neşet Ertaş", MuzikTuru = "Türk halk müziği/Türk sanat müziği", CikisYili = 1960, AlbümSatislari = 2 } // 2 milyon
        };

        // Adı 'S' ile başlayan şarkıcılar
        var sIleBaslayanlar = sarkicilar.Where(s => s.AdiSoyadi.StartsWith("S"));
        Console.WriteLine("Adı 'S' ile başlayan şarkıcılar:");
        foreach (var sarki in sIleBaslayanlar)
        {
            Console.WriteLine(sarki.AdiSoyadi);
        }
        Console.WriteLine();

        // Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
        var onMilyonUzeriSatislar = sarkicilar.Where(s => s.AlbümSatislari > 10).ToList();
        Console.WriteLine("Albüm satışları 10 milyon'un üzerinde olan şarkıcılar:");
        foreach (var sarki in onMilyonUzeriSatislar)
        {
            Console.WriteLine(sarki.AdiSoyadi);
        }
        Console.WriteLine();

        // 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar (Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırıyoruz)
        var popSarkicilar = sarkicilar.Where(s => s.CikisYili < 2000 && s.MuzikTuru.Contains ("Pop"))
                                      .OrderBy(s => s.CikisYili)
                                      .ThenBy(s => s.AdiSoyadi)
                                      .ToList();
        Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar:");
        foreach (var sarki in popSarkicilar)
        {
            Console.WriteLine($"{sarki.CikisYili}: {sarki.AdiSoyadi}");
        }
        Console.WriteLine();

        // En çok albüm satan şarkıcı
        var enCokSatan = sarkicilar.OrderByDescending(s => s.AlbümSatislari).First();
        Console.WriteLine("En çok albüm satan şarkıcı:");
        Console.WriteLine(enCokSatan.AdiSoyadi);
        Console.WriteLine();

        // En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı
        var enYeniSarkici = sarkicilar.OrderByDescending(s => s.CikisYili).First();
        var enEskiSarkici = sarkicilar.OrderBy(s => s.CikisYili).First();
        Console.WriteLine("En yeni çıkış yapan şarkıcı:");
        Console.WriteLine(enYeniSarkici.AdiSoyadi);
        Console.WriteLine("En eski çıkış yapan şarkıcı:");
        Console.WriteLine(enEskiSarkici.AdiSoyadi);
    }
}
