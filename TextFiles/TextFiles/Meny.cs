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

namespace GameProjekt
{
    class Meny
    {
        int ValdIndex;
        string[] Alternativ;
        string Prompt;

        public void Menyn(string prompt, string[] alternativ)
        {

            Prompt = prompt;
            Alternativ = alternativ;
            ValdIndex = 0;
        }
        public void VisaAlternativ() //Visaa menyn att välj mellan 3 alternativ
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Prompt);
            Console.ResetColor();
            
            for (int i = 0; i < Alternativ.Length; i++)
            {
                string redanAlternativ = Alternativ[i];
                string prefix;

                if (i == ValdIndex)//Skriv en stjärna bakom alternativet
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.Black;//byta färg
                    BackgroundColor = ConsoleColor.White;

                }
                else //Skriv ett utrymme bakom alternativet
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;//standard färg
                    BackgroundColor = ConsoleColor.Black;

                }
                WriteLine($"{prefix}<<{redanAlternativ}>>");

            }
            ResetColor();

        }
        public int Springa()
        {

            ConsoleKey keyPressed;
            do
            {
                //////Console.SetCursorPosition(0, WindowHeight - 10);//ställ in skärmhöjden i denna punkt


                VisaAlternativ(); //kalla metoden

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                //Uppdatera valt index baserat på piltangenterna

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    ValdIndex--;


                    if (ValdIndex == -1)//om du går up markören går till  det sista alternativen i menyn
                    {
                        ValdIndex = Alternativ.Length - 1;// Array Alternativ lång=3 --> till backa till altenativet[2]
                    }

                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    ValdIndex++;
                    if (ValdIndex == Alternativ.Length)//om du går efeter sista alternativen markören går till backa första alternativen i menyn
                    {
                        ValdIndex = 0;

                    }
                }
            } while (keyPressed != ConsoleKey.Enter);
            return ValdIndex;


        }

        static void StartIgenMenyn()//starta igen att visa efter rensa skärmen
        {

            Console.Clear(); //Rensa skärmen

            TextGrafik obj12 = new TextGrafik();
            obj12.TextGrafikStarta();

            TextGrafik obj40 = new TextGrafik();
            obj40.StartaTavlan();

        }
        public void TreAlternativ()
        {

            Meny obj989 = new Meny();
            int valdIndex = obj989.Springa();


            switch (valdIndex)
            {
                case 0:

                    Mnus obj4 = new Mnus();
                    obj4.VisaTextFilen();

                    break;

                case 1:

                    Console.WriteLine("tryck på en knapp om du har läst klart information.");
                    Console.ReadKey();
                    StartIgenMenyn();

                    Mnus obje1 = new Mnus();
                    obje1.AlltInfoVisa();

                    break;

                case 2:
                    ////går till andra alternativet
                    //StartIgenMenyn();//rensa skärmen och börja om
                    FyraAlternativIspelaSidan();
                    break;

            }

        }
        static void FyraAlternativIspelaSidan() //en metod som visa rubrik ov spela sidan
        {
            //////Console.Clear();
            TextGrafik objekt12 = new TextGrafik();
            objekt12.TextGrafikSpelaSidanRubrik();


            Meny startMeny1 = new Meny();   //kalla på Springa metoden i Meny klassen
            int valdIndex = startMeny1.Springa();

            switch (valdIndex)
            {
                case 0:// Om hård nivå har kommit in

                    Beep(150, 200);//beep ljud

                    WriteLine("                           Hård nivå vald.Lycka till");


                    //TextGrafik text = new TextGrafik();
                    //text.RubrikFaryAlternativEtt();


                    Meny obj700 = new Meny();
                    obj700.Springa();


                    FyraAlternativIspelaSidan();//starta igen

                    break;

                case 1: //Om genomsnittlig nivå har kommit in

                    Beep(150, 200);//beep ljud

                    //////Clear();

                    WriteLine("\t\t\tMedelmåttigt nivå vald.");

                    FyraAlternativIspelaSidan();//starta igen

                    Thread.Sleep(10);//en paus



                    Meny obj701 = new Meny();
                    obj701.Springa();
                    break;

                case 2:
                    WriteLine("\t\t\tLätt nivå vald.");

                    Clear();

                    FyraAlternativIspelaSidan();//starta igen

                    Thread.Sleep(10);

                    Meny obj702 = new Meny();
                    obj702.Springa();
                    break;
                case 3:
                    StartIgenMenyn();

                    Mnus obje1 = new Mnus();//kalla metoden i klassen AlltInfo
                    obje1.VisaTextFilen();

                    Meny objekt54 = new Meny();
                    objekt54.TreAlternativ();

                    break;
            }
        }

    }
}
