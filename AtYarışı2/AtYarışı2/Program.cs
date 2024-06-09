using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtYarışı2
{
    internal class Program
    {
        private static double ilerleMiktari1;

        static void Main(string[] args)
        {
            Random random = new Random();
            int randomSayi = random.Next();

            
            double kazanılanPara = 0, alınanYol1 = 0, alınanYol2 = 0, alınanYol3 = 0, alınanYol4 = 0, enBüyük = 0;
            string[] atIsimleri = new string[] { "Şubar", "Burul", "Akkula", "Çalkuyruk" };
            double[] atOranları = new double[] { 8.2 , 3.8 , 6.6 , 2.9 };
            double[] atHızları = new double[] { random.Next(4, 11), random.Next(6, 14), random.Next(5, 12), random.Next(7, 16) };

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{i + 1}.At:{atIsimleri[i]},Bahis Oranı:{atOranları[i]},Hızı:{atHızları[i]}");

            }

            while (true)
            {
                for (int i = 0; i < 10; i++)
                {


                    enBüyük = alınanYol1;
                    alınanYol1 += random.Next(1,32) * atHızları[0];
                    alınanYol2 += random.Next(1,32) * atHızları[1];
                    alınanYol3 += random.Next(1,32) * atHızları[2];
                    alınanYol4 += random.Next(1,32) * atHızları[3];



                }
                if (alınanYol1 > enBüyük)
                {
                    enBüyük = alınanYol1;

                }
                if (alınanYol2 > enBüyük)
                {
                    enBüyük = alınanYol2;
                }
                if (alınanYol3 > enBüyük)
                {
                    enBüyük = alınanYol3;
                }
                if (alınanYol4 > enBüyük)
                {
                    enBüyük = alınanYol4;
                }
                
                string at = Console.ReadLine();
                Console.Write("Yatırmak istediğiniz miktarı giriniz:");
                int miktar = int.Parse(Console.ReadLine());

                switch (at)
                {
                    case "Şubar":
                        if (enBüyük == alınanYol1)
                        {
                            kazanılanPara = atOranları[0] * miktar;
                            Console.WriteLine($"Yarıştan kazandığınız miktar:{kazanılanPara}");
                            Devammı.DevamMI();

                        }
                        else
                        {
                            Console.WriteLine("Seçtiğiniz at yarışı kaznamadı");
                            Devammı.DevamMI();

                        }
                        break;
                    case "Burul":
                        if (enBüyük == alınanYol2)
                        {
                            kazanılanPara = atOranları[1] * miktar;
                            Console.WriteLine($"Yarıştan kazandığınız miktar:{kazanılanPara}");
                            Devammı.DevamMI();



                        }
                        else
                        {
                            Console.WriteLine("Seçtiğiniz at yarışı kaznamadı");
                            Devammı.DevamMI();

                        }
                        break;
                    case "Akkula":
                        if (enBüyük == alınanYol3)
                        {
                            kazanılanPara = atOranları[2] * miktar;
                            Console.WriteLine($"Yarıştan kazandığınız miktar:{kazanılanPara}");
                            Devammı.DevamMI();


                        }
                        else
                        {
                            Console.WriteLine("Seçtiğiniz at yarışı kaznamadı");
                            Devammı.DevamMI();

                        }
                        break;
                    case "Çalkuyruk":
                        if (enBüyük == alınanYol4)
                        {
                            kazanılanPara = atOranları[3] * miktar;
                            Console.WriteLine($"Yarıştan kazandığınız miktar:{kazanılanPara}");
                            Devammı.DevamMI();


                        }
                        else
                        {
                            Console.WriteLine("Seçtiğiniz at yarışı kaznamadı");
                            Devammı.DevamMI();

                        }

                        break;
                    default:
                        Console.WriteLine("Yanlış bir at ismi girdiniz! Tekrar deneyniz. ");
                        break;
                }


            }
        }
    }
    public class Devammı
    {
        public static void DevamMI()
        {
            Console.WriteLine("Oynamaya devam etmek istermisiniz(1-2):");
            Console.WriteLine("1.Evet");
            Console.WriteLine("2.Hayır");
            int seçim = int.Parse(Console.ReadLine());
            if (seçim == 1)
            {
                Console.WriteLine("Oyun devam ediyor!");
            }
            if (seçim == 2)
            {
                Environment.Exit(0);
            }

        }
    }
}






