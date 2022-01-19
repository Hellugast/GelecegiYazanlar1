using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> guzelFilmler = new List<string> { "Schindler's List", "Lotr Series", "Star Wars Series", "The Shawshank Redemption", "Fight Club" };


            foreach (var film in guzelFilmler)
            {
                Console.WriteLine(film);
            }

            //indexof
            int enSevdigim = guzelFilmler.IndexOf("Lotr Series");
            Console.WriteLine($"\nEn sevdiğim film kaçıncı indexte : {enSevdigim}\n");

            //contains
            Console.WriteLine("Matrix 4 guzelFilmler listesinde yer alıyor mu");
            bool matrix = guzelFilmler.Contains("Matrix 4");
            Console.WriteLine(matrix);


            string fightClub = "\n\nBen sürekli bug içeren kod yazıyorsam, bir adam sürekli kodlarımı düzeltiyorsa...";


            //split
            string[] ayrilmis = fightClub.Split(',');
            foreach (var kelime in ayrilmis)
            {
                Console.WriteLine(kelime);
            }

            Console.ReadLine();
        }
    }
}
