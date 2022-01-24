using System;

namespace AdamAsmaca
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kelimeler = { "elma", "armut", "ayva", "kiraz" };

            string secilenKelime = kelimeyiSec(kelimeler);

            string[] gelenTahta = adamTahtasi(secilenKelime);

            tahtaYazdir(gelenTahta);


            
            bool kontrolBitme = true;
            
            while (kontrolBitme)
            {

                gelenTahta = tahminYap(gelenTahta, secilenKelime);

                tahtaYazdir(gelenTahta);

                if (secilenKelime == string.Concat(gelenTahta))
                {
                    Console.WriteLine("\nOyun bitti");
                    break;
                }

            }


        }



        private static string kelimeyiSec(string[] kelimeler)
        {
            Random sayirandomla = new Random();
            int x = sayirandomla.Next(0,4);
            string secilenKelime = kelimeler[x];
            return secilenKelime;
        }

        private static string[] adamTahtasi(string secilenKelime)
        {
            int uzunluk = secilenKelime.Length;
            string[] harfSayisi = new string[secilenKelime.Length];

            for (int i = 0; i < uzunluk; i++)
            {
                harfSayisi[i] = "*";
            }

            return harfSayisi;
        }


        private static void tahtaYazdir(string[] tahtaYazdir)
        {
            foreach (var item in tahtaYazdir)
            {
                Console.Write(item);
            }
        }

        private static string[] tahminYap(string[] gelenTahta, string secilenKelime)
        {
            Console.WriteLine("\nTahmin gir");
            char alinanHarf = Convert.ToChar(Console.ReadLine());
            bool kontrolHarf = false;
            

            for (int i = 0; i < secilenKelime.Length; i++)
            {
                if (alinanHarf == secilenKelime[i])
                {
                    gelenTahta[i] = alinanHarf.ToString();
                    kontrolHarf = true;
                }

            }

            if (!kontrolHarf)
            {
                Console.WriteLine("Harf yok");
            }



            return gelenTahta;
        }






    }





}
