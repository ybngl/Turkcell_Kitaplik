using System;
using System.IO;

namespace Turkcell_Kitaplik
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplamfiyat = 0;
            string secim;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine();
            Console.WriteLine(" ** Türkçe Kitaplar Katagorisi     ** Yabancı Kitaplar Katagorisi       ** ");
            Console.WriteLine();
            Console.WriteLine(" ** 1-Çalıkuşu: R.Nuri Güntekin    ** 7-Tuna Klavuzu: Jules Verne       ** ");
            Console.WriteLine(" ** 2-Yaban: Yakup Kadri           ** 8-Bir Kuzey Macerası: Jack London ** ");
            Console.WriteLine(" ** 3-Sinekli Bakkal: Halide Edip  ** 9-Altıncı Koğuş: Anton Çehov      ** ");
            Console.WriteLine(" ** 4-Tehlikeli Oyunlar: Oğuz Atay ** 10-Kumarbaz: Dostoyevski          ** ");
            Console.WriteLine(" ** 5-Geçdiğim Günlerden: H. Yüce  ** 11-İki Şehrin Hikayesi: C. Dickens** ");
            Console.WriteLine(" ** 6-Kuyucaklı Yusuf: S. Ali      ** 12-Vişne Bahçesi: Anton Çehov     ** ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("********* İşlemler Menüsü *********");
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Yeni Kitap Satın Al");
            Console.WriteLine("6-Sayı Tahmin Oyunu");
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlemin numarasını giriniz: ");
            char islem = Convert.ToChar(Console.ReadLine());

            switch (islem)
            {
                case '1':
                    Console.Write("İşlem: Lütfen öğrenmek istediğiniz kitabın numarasını giriniz: ");
                    string numara = Console.ReadLine();

                    if (numara == "1") Console.WriteLine("Çalıkuşu: 12 TL");
                    else if (numara == "2") Console.WriteLine("Yaban: 14 TL");
                    else if (numara == "3") Console.WriteLine("Sinekli Bakkal: 16 TL");
                    else if (numara == "4") Console.WriteLine("Tehlikeli Oyunlar: 11 TL");
                    else if (numara == "5") Console.WriteLine("Geçdiğim Günlerden: 8 TL");
                    else if (numara == "6") Console.WriteLine("Kuyucaklı Yusuf: 13 TL");
                    else if (numara == "7") Console.WriteLine("Tuna Klavuzu: 17 TL");
                    else if (numara == "8") Console.WriteLine("Bir Kuzey Macerası: 14 TL");
                    else if (numara == "9") Console.WriteLine("Altıncı Koğuş: 13 TL");
                    else if (numara == "10") Console.WriteLine("Kumarbaz: 13 TL");
                    else if (numara == "11") Console.WriteLine("İki Şehrin Hikayesi: 8 TL");
                    else if (numara == "12") Console.WriteLine("Vişne Bahçesi: 6 TL");
                    else Console.WriteLine("Lütfen geçerli bir kitap numarası giriniz.");
                    break;

                case '2':
                    Console.WriteLine("*************Yeni Okur Kaydı************");
                    Console.Write("Adınızı giriniz: ");
                    string ad = Console.ReadLine();
                    Console.Write("Soyadınızı giriniz: ");
                    string soyad = Console.ReadLine();
                    Console.Write("Üniversitenizi giriniz: ");
                    string uni = Console.ReadLine();
                    FileStream fs = new FileStream(@"C:\Users\CASPER\Desktop\okur.txt", FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine("Ad: " + ad);
                    sw.WriteLine("Soyad: " + soyad);
                    sw.WriteLine("Üniversite: " + uni);
                    sw.Close();
                    fs.Close();
                    break;

                case '3':
                    Console.WriteLine("*************************************");
                    Console.WriteLine("******** Bugünün Kitabı: Çalıkuşu ********");
                    Console.WriteLine("*************************************");
                    break;

                case '4':
                    Console.WriteLine("*********** Kitap Arşivi ***********");
                    FileStream fss = new FileStream(@"C:\Users\CASPER\Desktop\kitaplar.txt", FileMode.OpenOrCreate);
                    StreamReader sr = new StreamReader(fss);
                    string metin = sr.ReadToEnd();
                    Console.WriteLine(metin);
                    sr.Close();
                    fss.Close();
                    Console.WriteLine("*************************************");
                    break;

                case '5':
                    for (int i = 0; i < 100; i++)
                    {
                        Console.Write("Alacağınız kitabın numarasını giriniz: ");
                        secim = Console.ReadLine();

                        if (secim == "1") toplamfiyat += 12;
                        else if (secim == "2") toplamfiyat += 14;
                        else if (secim == "3") toplamfiyat += 16;
                        else if (secim == "4") toplamfiyat += 11;
                        else if (secim == "5") toplamfiyat += 8;
                        else if (secim == "6") toplamfiyat += 13;
                        else if (secim == "7") toplamfiyat += 17;
                        else if (secim == "8") toplamfiyat += 14;
                        else if (secim == "9") toplamfiyat += 13;
                        else if (secim == "10") toplamfiyat += 13;
                        else if (secim == "11") toplamfiyat += 8;
                        else if (secim == "12") toplamfiyat += 6;
                        else Console.WriteLine("Böyle bir kitap bulunmamaktadır!");

                        Console.Write("Başka kitap almak ister misiniz? (E/H): ");
                        string devam = Console.ReadLine().ToLower();
                        if (devam != "e") break;
                    }
                    Console.WriteLine("Toplam Tutar: " + toplamfiyat + " TL");
                    break;

                case '6':
                    Console.WriteLine("Sayı Tahmin Oyununa Hoş Geldiniz!");
                    Random rastgele = new Random();
                    int sayi = rastgele.Next(1, 100);
                    int tahmin = 0;
                    while (tahmin != sayi)
                    {
                        Console.Write("1 ile 100 arasında bir sayı girin: ");
                        tahmin = Convert.ToInt32(Console.ReadLine());
                        if (tahmin > sayi) Console.WriteLine("Daha küçük bir sayı giriniz.");
                        else if (tahmin < sayi) Console.WriteLine("Daha büyük bir sayı giriniz.");
                        else Console.WriteLine("Tebrikler! Sayıyı doğru tahmin ettiniz.");
                    }
                    break;

                default:
                    Console.WriteLine("Geçersiz işlem numarası!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
