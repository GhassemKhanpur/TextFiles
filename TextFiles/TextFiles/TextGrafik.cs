using System;
using GameProjekt;
using System.Collections.Generic;
using System.Linq;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
using static System.Collections.Specialized.BitVector32;
using System.Globalization;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;


namespace GameProjekt
{
    public class TextGrafik
    {

        public void StartaTavlan()
        {
            //Byta text färg och skriv 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\tVälkommen till Spelprojekt");
            Console.ResetColor();

        }
        public void BytaTextFilTavlan()
        {

            string[] frogorStart = { "Grundare:", "Investerare:", "Designer:", "Chef:", "Grafisk designer:", "Musik:", "Fotograf:", "Stöd:", "Projektets startar:", "Förtfattare", "Budgetens:" };

            string[] svararStart = { "Ghassem", "Khanpur Sardehay", "Johan Andersson", "Emilia Warner", "Sonia Marshal", "Sanna Söderling", "Fanna Malchom", "Katarina Sozaki", "2021", "FanShanna miomal", "10,000,000kr" };

            var resultat1 = frogorStart.Zip(svararStart, (n1, p2) => new { info1 = n1, info2 = p2 }); //parallell array


            Console.Write("Grundare:\t");//få info 
            svararStart[0] = Console.ReadLine();

            Console.Write("Investerare:\t");//få indo
            svararStart[1] = Console.ReadLine();

            Console.Write("Enter behöv");
            Console.ReadKey();


            string pathTextFilInfo = "InfoText.txt";

            using (StreamWriter streamWriter = File.CreateText(pathTextFilInfo))
            {
                foreach (var a in resultat1)//skriva ur parallell array 1
                {
                    streamWriter.Write(a.info1 + a.info2 + "\n");

                }

            }
        }

        public void StartaInfoTavlan(ref string Grundare, ref string Investerare)

        {
            string[] frogorStart = { " Grundare:", " Investerare:", " Designer:", " Chef:", " Grafisk designer:", " Musik:", " Fotograf:", " Stöd:", "  Projektets startar:", "     Förtfattare:", "  Budgetens:" };

            string[] svararStart = { "Ghassem", "Khanpur Sardehay", "Johan Andersson", "Emilia Warner", "      Sonia Marshal", "Sanna Söderling", " Fanna Malchom", "Katarina Sozaki", "2021", " FanShanna miomal", "10,000,000kr" };

            svararStart[0] = Grundare;
            svararStart[1] = Investerare;

            var resultat1 = frogorStart.Zip(svararStart, (n1, p2) => new { info1 = n1, info2 = p2 }); //parallell array

            for (int i = 0; i < 117; i++)//rita en linje
            {
                Console.ForegroundColor = ConsoleColor.Blue;//Byta färg

                Console.Write("_");
                Console.ResetColor();
                if (i == 116)
                {
                    Console.WriteLine();
                    Console.ResetColor(); 
                }

            }
            Console.ForegroundColor = ConsoleColor.Yellow;//Byta textfärg

            foreach (var a in resultat1)//skriva ur parallell array 1
            {
                Console.Write(a.info1 + a.info2 + "  ");

            }
            Console.ResetColor(); //Lägga rätt
            Console.WriteLine();

            for (int i = 0; i < 117; i++)//rita en linje
            {
                Console.ForegroundColor = ConsoleColor.Blue;//Byta färg

                Console.Write("_");
                Console.ResetColor(); //Lägga rätt
                if (i == 116)
                {
                    Console.WriteLine();
                    Console.ResetColor(); //Lägga rätt
                }
            }
        }
        public void SkapaEnTextFil() //skappa 3 textfilen för att vissa sedan på VissaOmUssTexFilen metoden
        {
            string pathTextFil1 = "Om_uss1.txt";
            using (StreamWriter f = File.CreateText(pathTextFil1))
            {
                // skriv texten i textfilen
                f.WriteLine("--Spela Projekt-- \nWWW.ABCDEFGH.COM \nTelefon:071232432532 \nAdress:Stockholm 235315");

            }
            string pathTextFil2 = "Om_uss2.txt";
            using (StreamWriter f = File.CreateText(pathTextFil2))
            {
                // skriv texten i textfilen
                f.WriteLine("Datorspel (dator-spel), i viss utsträckning även dataspel (data-spel),\nTidigare kallat videospel (video-spel, av engelska: video game  är spel som visualiseras.");
            }
            string pathTextFil3 = "Om_uss3.txt";
            using (StreamWriter f = File.CreateText(pathTextFil3))
            {
                // skriv texten i textfilen
                f.WriteLine("Såsom persondator, spelkonsol, mobiltelefon eller spelautomat/arkadkabinett, etc.\nDatorspel indelas traditionellt i olika klasser beroende på \nvilken datorplattform spelen programmerats för,\nexempelvis: PC-spel/datorspel, TV-spel/konsolspel, mobilspel eller arkadspel.");

            }

        }
        public void VissaOmUssTexFilen() //vissa tre textfilen som skappade i SkapaEnTextFil metoden
        {
            ////Console.WriteLine();
            string pathTextFil1 = "Om_uss1.txt";
            using (StreamReader str = File.OpenText(pathTextFil1))
            {
                string ettText;
                while ((ettText = str.ReadLine()) != null)
                {

                    Console.WriteLine(ettText);//skriv texten
                }
            }
            Thread.Sleep(1500);//en pause
            string pathTextFil2 = "Om_uss2.txt";
            using (StreamReader str = File.OpenText(pathTextFil2))
            {
                string ettText;
                while ((ettText = str.ReadLine()) != null)
                {

                    Console.WriteLine(ettText);//skriv texten
                }
            }
            Thread.Sleep(1500);//en pause
            string pathTextFil3 = "Om_uss3.txt";
            using (StreamReader str = File.OpenText(pathTextFil3))
            {
                string ettText;
                while ((ettText = str.ReadLine()) != null)
                {

                    Console.WriteLine(ettText);//skriv texten
                }
            }
            Thread.Sleep(2000);//en pause

        }

        public void VissaBytadeTextFilTavlan() //Vissa textfilen informationen igen efter info bytade
        {

            string pathTextFilInfo = "InfoText.txt";
            using (StreamReader str = File.OpenText(pathTextFilInfo))
            {
                string ettText;
                while ((ettText = str.ReadLine()) != null)
                {

                    Console.WriteLine(ettText);//skriv texten
                }
            }
        }
        public void InfoTavlan()
        {
            string pathTextFilInfo = "InfoText.txt";//Vissa textfilen information
            if (File.Exists(pathTextFilInfo))
            {
                VissaBytadeTextFilTavlan();
            }
            else//Om det finns inte textfilen vissa nedan information
            {
                //visa information av Grundare, Investerare och andra...
                string Grundare = "Ghassem";
                string Investerare = "Khanpur Sardehay";
                StartaInfoTavlan(ref Grundare, ref Investerare);
            }
        }
        public void TextGrafikStarta()//vissa huvud rubriken 
        {
            SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write(@"
         ____             _                 _      _    _   
        / ___| _ __   ___| |_ __  _ __ ___ (_) ___| | _| |_ 
        \___ \| '_ \ / _ \ | '_ \| '__/ _ \| |/ _ \ |/ / __|
         ___) | |_) |  __/ | |_) | | | (_) | |  __/   <| |_ 
        |____/| .__/ \___|_| .__/|_|  \___// |\___|_|\_\\__|
              |_|          |_|           |__/ Copyright@ GHassem Khanpur Sardehay");

            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            DateTime dat = DateTime.Now;// Visa tid

            Console.Write("Tid: {0:d} kl {0:t} ", dat);
            Console.ResetColor();

        }

    }
}















