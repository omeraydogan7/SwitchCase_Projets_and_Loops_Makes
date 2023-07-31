using System;

namespace SwitchCaseProjectsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // BasamakBulmaMethod();
            // BasamakKupToplamiMethod();
            // DolarKurHesapla();
            // TernaryMethod3();
            //SayiToplamiMethod();
            AsalSayiBulma();
            Console.ReadKey();
        }
        #region Asal Sayi Bul
        private static void AsalSayiBulma()
        {
            int sayac = 0;
            Console.WriteLine("Sayıyı Girin");
            int sayi = Convert.ToInt32(Console.ReadLine());//100

            for (int i = 1; i <= sayi; i++)
            {
                //1 ve kendisinden başka bölünemeyen sayılara asal sayı denir...
                // koşul ?  doğru : yanlış;
                int sonuc = sayi % i == 0 ? sayac++ : 0;//harika kafalar var burada
                //if (sayi % i == 0)
                //{
                //    sayac++;//25
                //}
            }
            if (sayac == 2)  //asal sayaı kendisi ve 1 e bölünür
            {
                Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayıdır.", sayi);
            }
            else
            {
                Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayı Değildir.", sayi);
            }
            Console.ReadKey();
        }
        #endregion
        #region Asal Sayi Bulma
        static void AsalSayiBulma2()
        {
            Console.Write("2. Lütfen 1 dışında pozitif bir tam sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            bool asalMi = IsAsal(sayi);

            if (asalMi)
            {
                Console.WriteLine("6. Sayı asaldır.");
            }
            else
            {
                Console.WriteLine("6. Sayı asal değildir.");
            }

            Console.WriteLine("8. Bitiş");
        }
        static bool IsAsal(int sayi)
        {
            if (sayi <= 1)
            {
                return false; // 1 dışında pozitif bir sayı olmalı
            }

            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                {
                    return false; // Asal değil
                }
            }

            return true; // Asal
        }


        #endregion

        #region Dongu ornekleri
        static void ForDonguMethod()
        {
            Console.Write("Bir sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i = 2; i <= sayi; i += 2)
            {
                toplam += i;
            }

            Console.WriteLine($"1'den {sayi}'e kadar olan çift sayıların toplamı: {toplam}");
        }

        static void SayiToplamiMethod()
        {
            Console.WriteLine("1. başla");

            Console.Write("2. Başlangıç sayısını girin: ");
            int baslangicSayisi = Convert.ToInt32(Console.ReadLine());

            Console.Write("3. Bitiş sayısını girin: ");
            int bitisSayisi = Convert.ToInt32(Console.ReadLine());

            Console.Write("4. Sayıları toplamak için (t)ek sayıları mı, (ç)ift sayıları mı seçmek istersiniz?: ");
            char secim = Convert.ToChar(Console.ReadLine());

            int toplam = 0;
            if (secim % 2 == 0 && (secim == 't' || secim == 'T'))
            {
                // Tek sayıları topla
                for (int i = baslangicSayisi; i < bitisSayisi; i++)
                {
                    if (i % 2 != 0)
                    {
                        toplam += i;
                    }
                }
            }
            else if (secim == 'ç' || secim == 'Ç')
            {
                // Çift sayıları topla
                for (int i = baslangicSayisi; i < bitisSayisi; i++)
                {
                    if (i % 2 == 0)
                    {
                        toplam += i;
                    }
                }
            }
            else
            {
                Console.WriteLine("Hatalı seçim yaptınız. (t) veya (ç) harfini girmelisiniz.");
                Environment.Exit(0); // Programı sonlandır
            }

            Console.WriteLine($"5. Toplam sonuç: {toplam}");
            Console.WriteLine("7. Bitiş");
        }
        #endregion

        #region Ternary Operatörü kullanım örnekleri
        static void TernaryMethod1()
        {
            int sayi = 25;

            string sonuc = (sayi % 2 == 0) ? "Sayı Çifttir." : "Sayı Tektir.";

            Console.WriteLine(sonuc);
        }
        static void TernaryMethod2()
        {
            Console.Write("x sayısını gir: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y sayısını gir: ");
            int y = Convert.ToInt32(Console.ReadLine());
            string sonuc;

            sonuc = (x > y) ? "x değeri y den büyüktür." : (x < y) ? "x değeri y den küçüktür." : "x ve y değerleri eşittir.";
            Console.WriteLine(sonuc);
        }
        static void TernaryMethod3()
        {
            Random rnd = new Random();
            float flt = rnd.Next(0, 1);
            Console.WriteLine(flt);
        }
        #endregion

        #region Döviz kur hesaplama

        static void DolarKurHesapla()
        {  // Ana metotta çağrılacak metot
            /*
            Algoritma:
            1. başla
            2. kullanıcıdan TL cinsinden para girilmesi istenir
            3. kullanıcı para girer
            4. kullanıcıdan para birimi girilmesi istenir (Dolar: d, Euro: e, Pound: p)
            5.1 eğer para birimi dolar ise 
            5.2 kullanıcının girdiği parayı tanımlı olan dolar kuruna böl
            5.3 eğer para birimi euro ise
            5.4 kullacının girdiği parayı tanımlı olan euro kuruna böl
            5.5 eğer para birimi pound ise
            5.6 kullanıcının girdiği parayı tanımlı olan pound kuruna böl
            5.7 eğer para birimi dolar, euro ve pound değil ise
            5.8 kullanıcıdan doğru tanımlı para birimi girilmesi istenir
            6. işlem sonucu ekrana tarih ile birlikte yazdırılır
            7. bitir
            */
            Console.WriteLine("Algoritma:");
            Console.WriteLine("1. başla");
            double girilenPara = KullanicidanParaGirisiAl();
            string paraBirimi = KullanicidanParaBirimiGirisiAl();

            double donusturulenPara = ParaDonustur(girilenPara, paraBirimi);

            SonucuEkranaYazdir(girilenPara, donusturulenPara, paraBirimi);
            Console.WriteLine("7. bitir");

        }
        static double KullanicidanParaGirisiAl()
        {
            Console.WriteLine("2. kullanıcıdan TL cinsinden para girilmesi istenir");
            Console.Write("3. kullanıcı para girer: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        static string KullanicidanParaBirimiGirisiAl()
        {
            Console.WriteLine("4. kullanıcıdan para birimi girilmesi istenir (Dolar: d, Euro: e, Pound: p)");
            Console.Write("5. Para birimi: ");
            string paraBirimi = Console.ReadLine().ToLower();//girilen değeri küçük değer çeviriyoruz...

            while (paraBirimi != "d" && paraBirimi != "e" && paraBirimi != "p")
            {
                Console.WriteLine("Hatalı para birimi girdiniz. Lütfen doğru bir para birimi seçiniz (Dolar: d, Euro: e, Pound: p).");
                Console.Write("5. Para birimi: ");
                paraBirimi = Console.ReadLine().ToLower();
            }

            return paraBirimi;
        }

        static double ParaDonustur(double paraMiktari, string paraBirimi)
        {
            double dolarKuru = 8.5;
            double euroKuru = 10.0;
            double poundKuru = 11.5;

            if (paraBirimi == "d")
            {
                return paraMiktari / dolarKuru;
            }
            else if (paraBirimi == "e")
            {
                return paraMiktari / euroKuru;
            }
            else // "p" kabul edileceği varsayılır.
            {
                return paraMiktari / poundKuru;
            }
        }

        static void SonucuEkranaYazdir(double girilenPara, double donusturulenPara, string paraBirimi)
        {
            Console.WriteLine($"6. İşlem sonucu: {donusturulenPara:0.00} {paraBirimi.ToUpper()} - Tarih: {DateTime.Now}");
        }

        #endregion

        #region Basamakları küpleri sayının kendisini veren uygulamam
        static void BasamakKupToplamiMethod()
        {
            Console.Write("3 basamaklı bir sayı girin: ");
            int sayi = int.Parse(Console.ReadLine());

            if (KuplerinToplamiKontrolu(sayi))
            {
                Console.WriteLine("Girilen sayının basamaklarının küpleri toplamı kendisine eşittir.");
            }
            else
            {
                Console.WriteLine("Girilen sayının basamaklarının küpleri toplamı kendisine eşit değildir.");
            }
        }
        static bool KuplerinToplamiKontrolu(int sayi)
        {
            int birlerBasamagi = sayi % 10;
            int onlarBasamagi = (sayi / 10) % 10;
            int yuzlerBasamagi = sayi / 100;

            int birlerKup = birlerBasamagi * birlerBasamagi * birlerBasamagi;
            int onlarKup = onlarBasamagi * onlarBasamagi * onlarBasamagi;
            int yuzlerKup = yuzlerBasamagi * yuzlerBasamagi * yuzlerBasamagi;

            int toplam = birlerKup + onlarKup + yuzlerKup;

            return (toplam == sayi);
        }
        #endregion

        #region Basamak bulma örneği
        static void BasamakBulmaMethod()
        {
            Console.Write("3 basamaklı bir sayı girin: ");
            int sayi = int.Parse(Console.ReadLine());

            int birlerBasamagi = sayi % 10;
            int onlarBasamagi = (sayi / 10) % 10;
            int yuzlerBasamagi = sayi / 100;

            int birlerKup = birlerBasamagi * birlerBasamagi * birlerBasamagi;
            int onlarKup = onlarBasamagi * onlarBasamagi * onlarBasamagi;
            int yuzlerKup = yuzlerBasamagi * yuzlerBasamagi * yuzlerBasamagi;

            int toplam = birlerKup + onlarKup + yuzlerKup;

            if (toplam == sayi)
            {
                Console.WriteLine("Girilen sayının basamaklarının küpleri toplamı kendisine eşittir.");
            }
            else
            {
                Console.WriteLine("Girilen sayının basamaklarının küpleri toplamı kendisine eşit değildir.");
            }
        }
        #endregion

        #region Geometrik Alan hesaplma örneği
        static void SwitchCaseMethod2()
        {
            Console.WriteLine("Geometrik Alan Hesaplama");
            Console.WriteLine("*************************");
            Console.WriteLine("1. Kare");
            Console.WriteLine("2. Daire");
            Console.WriteLine("*************************");

            Console.Write("Alanını hesaplamak istediğiniz şekli seçin (1-2): ");
            int secim = int.Parse(Console.ReadLine());//kare 1

            switch (secim)//1
            {
                case 1:// case 1==1
                    Console.Write("Karenin kenar uzunluğunu girin: ");
                    double kenar = double.Parse(Console.ReadLine());
                    double kareAlan = kenar * kenar;
                    Console.WriteLine("Karenin Alanı: " + kareAlan);
                    break;

                case 2://
                    Console.Write("Dairenin yarıçapını girin: ");
                    double yaricap = double.Parse(Console.ReadLine());
                    double daireAlan = Math.PI * yaricap * yaricap;
                    Console.WriteLine("Dairenin Alanı: " + daireAlan);
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim! Lütfen 1 veya 2 seçin.");
                    break;
            }
        }
        #endregion

        #region Hesap makinası örneği Switch case kullanımı
        static void SwitchCaseMethod()
        {
            Console.WriteLine("Hesap Makinesi");
            Console.WriteLine("******************");
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Çıkarma");
            Console.WriteLine("3. Çarpma");
            Console.WriteLine("4. Bölme");
            Console.WriteLine("******************");

            Console.Write("Yapmak istediğiniz işlemi seçin (1-4): ");
            int secim = int.Parse(Console.ReadLine());

            Console.Write("İlk sayıyı girin: ");
            double sayi1 = double.Parse(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            double sayi2 = double.Parse(Console.ReadLine());

            double sonuc = 0;

            switch (secim)
            {
                case 1:
                    sonuc = sayi1 + sayi2;
                    break;
                case 2:
                    sonuc = sayi1 - sayi2;
                    break;
                case 3:
                    sonuc = sayi1 * sayi2;
                    break;
                case 4:
                    if (sayi2 != 0)
                    {
                        sonuc = sayi1 / sayi2;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı işlem! Bölen sıfır olamaz.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim! Lütfen 1-4 arasında bir seçim yapın.");
                    return;
            }

            Console.WriteLine("Sonuç: " + sonuc);
        }
        #endregion

    }
}
