using System;
using System.Collections.Generic;

namespace Generic_Koleksiyonlar_ve_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(4);
            sayiListesi.Add(10);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");
            renkListesi.Add("Sarı");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);

            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            // Listeden eleman cıkartmak
            sayiListesi.Remove(4); // bulduğu degeri 4 olan ilk itemı cıkartır
            renkListesi.Remove("Sarı"); // bulduğu degeri sarı olan ilk itemı cıkartır

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(0);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            if (sayiListesi.Contains(10)){
                Console.WriteLine("10 listede var");
            }

            //Eleman ile indexe erişmek
            // diziyi listeye çevirmek
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};
            List<string> hayvanlistesi = new List<string>(hayvanlar);

            // listeyi temizlemek
            hayvanlistesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcılistesi = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim="Ayşe";
            kullanıcı1.Soyisim="Yılmaz";
            kullanıcı1.Yas=23;
            kullanıcılistesi.Add(kullanıcı1);

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim="Veli";
            kullanıcı2.Soyisim="Sonmez";
            kullanıcı2.Yas=26;          
            kullanıcılistesi.Add(kullanıcı2);

            foreach (var item in kullanıcılistesi)
            {
                Console.WriteLine(item.Isim);
                Console.WriteLine(item.Soyisim);
                Console.WriteLine(item.Yas);
            }
        }
    }

    public class Kullanıcılar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
