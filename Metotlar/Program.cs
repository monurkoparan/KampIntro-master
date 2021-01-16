using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun Urun1 = new Urun();

            Urun1.Adi = "Elma";
            Urun1.Fiyatı = 15;
            Urun1.Aciklama = "Amasya elması";

            Urun Urun2 = new Urun();
            Urun2.Adi = "Karpuz";
            Urun2.Fiyatı = 80;
            Urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] Urunler = new Urun[] {Urun1,Urun2};

            //type güvenli ------ tip güvenliği
            foreach (Urun urun in Urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------");

            }

            Console.WriteLine("--------Metodlar--------");

            //instance - örnke
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(Urun1);
            sepetManager.Ekle(Urun2);

            sepetManager.Ekle2("armut", "yesilar armut", 5,10);
            sepetManager.Ekle2("Elma", "yesilar elma", 5, 10);
            sepetManager.Ekle2("karpuz", "diyarbakır", 5, 10);

        }
    }
}
