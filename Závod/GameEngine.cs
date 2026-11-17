using System.Numerics;

using System;

namespace ZavodAut
{
    internal class GameEngine
    {
        public Auto Auto1 { get; set; }
        public Auto Auto2 { get; set; }

        public GameEngine()
        {
            Auto1 = new Auto("SportAuto", 180, 6.0, 15.0);
            Auto2 = new Auto("FamilyAuto", 150, 10.0, 6.5);
        }

        internal void GameStart()
        {
            int pocetKol = 3;
            double dlzkaTrate = 15.0;

            for (int i = 1; i <= pocetKol; i++)
            {
                Auto1.OdjazdiKolo(dlzkaTrate);
                Auto2.OdjazdiKolo(dlzkaTrate);

                Console.WriteLine("Vysledok kola " + i);

                if (Auto1.MaPalivo)
                {
                    Console.WriteLine(Auto1.Nazov + " - Cas: " + Math.Round(Auto1.CasKola, 2) + " min | Palivo: " + Math.Round(Auto1.AktualnePalivo, 2) + " l");
                }
                else
                {
                    Console.WriteLine(Auto1.Nazov + " - DOSLO PALIVO");
                }

                if (Auto2.MaPalivo)
                {
                    Console.WriteLine(Auto2.Nazov + " - Cas: " + Math.Round(Auto2.CasKola, 2) + " min | Palivo: " + Math.Round(Auto2.AktualnePalivo, 2) + " l");
                }
                else
                {
                    Console.WriteLine(Auto2.Nazov + " - DOSLO PALIVO");
                }

                if (Auto1.MaPalivo && Auto2.MaPalivo)
                {
                    if (Auto1.CasKola < Auto2.CasKola)
                    {
                        Console.WriteLine("Kolo vyhral: " + Auto1.Nazov);
                    }
                    else if (Auto2.CasKola < Auto1.CasKola)
                    {
                        Console.WriteLine("Kolo vyhral: " + Auto2.Nazov);
                    }
                    else
                    {
                        Console.WriteLine("Remiza v kole");
                    }
                }
                else if (Auto1.MaPalivo)
                {
                    Console.WriteLine("Kolo vyhral: " + Auto1.Nazov);
                }
                else if (Auto2.MaPalivo)
                {
                    Console.WriteLine("Kolo vyhral: " + Auto2.Nazov);
                }
                else
                {
                    Console.WriteLine("Nikto nedokoncil kolo");
                }

                Console.WriteLine("------------------------------------------");
            }

            if (Auto1.MaPalivo && Auto2.MaPalivo)
            {
                if (Auto1.CelkovyCas < Auto2.CelkovyCas)
                {
                    Console.WriteLine("Celkovy vitaz: " + Auto1.Nazov);
                }
                else
                {
                    Console.WriteLine("Celkovy vitaz: " + Auto2.Nazov);
                }
            }
            else if (Auto1.MaPalivo)
            {
                Console.WriteLine("Celkovy vitaz: " + Auto1.Nazov);
            }
            else if (Auto2.MaPalivo)
            {
                Console.WriteLine("Celkovy vitaz: " + Auto2.Nazov);
            }
            else
            {
                Console.WriteLine("Zavod nedokoncilo ziadne auto");
            }
        }
    }
}

