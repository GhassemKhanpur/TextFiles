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
using System.Runtime.InteropServices;
using System.Configuration;
using System.Xml.Linq;

namespace GameProjekt
{
    class Menyn
    {
        int ValdIndex;
        readonly string[] Alternativ;
        readonly string Prompt;

        public Menyn(string prompt, string[] alternativ)
        {
            Prompt = prompt;
            Alternativ = alternativ;
            ValdIndex = 1;//standard vald
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

            ConsoleKey keyPressed;//få en nyckel 
            do
            {
                Console.SetCursorPosition(0, WindowHeight - 10);//ställ in skärmhöjden i denna punkt

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
            } while (keyPressed != ConsoleKey.Enter);//till stiga på "Enter"
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
        static void StartIgenEfterBytaInfo()//starta igen att visa efter rensa skärmen
        {

            Console.Clear(); //Rensa skärmen

            TextGrafik obj12 = new TextGrafik();
            obj12.TextGrafikStarta();

            TextGrafik obj40 = new TextGrafik();
            obj40.StartaTavlan();

            obj40.InfoTavlan();


        }

        static void StartIgenIspelaSidan()//starta igen att visa efter rensa skärmen
        {

            Console.Clear(); //Rensa skärmen

            TextGrafik objekt12 = new TextGrafik();
            objekt12.TextGrafikStarta();

            objekt12.StartaTavlan();

        }
        public void TreAlternativ()
        {
            string prompt = ("Välja ett alternativ med  ↑ ↓ Enter från tangentbordet ");
            string[] alternativ = { "Ändra information", "Om uss", "Spela" };
            Menyn objekt20 = new Menyn(prompt, alternativ);
            int valdIndex = objekt20.Springa();

            switch (valdIndex)
            {
                case 0:

                    Clear();

                    StartIgenEfterBytaInfo();

                    TextGrafik obj345 = new TextGrafik();
                    obj345.BytaTextFilTavlan();

                    Clear();
                    StartIgenMenyn();

                    obj345.VissaBytadeTextFilTavlan();

                    TreAlternativ();

                    break;

                case 1:

                    Clear();

                    StartIgenMenyn();

                    TextGrafik obj6767 = new TextGrafik();

                    obj6767.SkapaEnTextFil();

                    obj6767.VissaOmUssTexFilen();

                    for (int i = 0; i < 8; i++)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" - - - ");
                        Thread.Sleep(i + 50);//en pause
                        Console.ResetColor();
                    }
                    Console.ResetColor();


                    Clear();
                    StartIgenMenyn();

                    TextGrafik obj6780 = new TextGrafik();
                    obj6780.VissaBytadeTextFilTavlan();

                    TreAlternativStatic();

                    break;

                case 2:

                    StartIgenMenyn();//rensa skärmen och börja om

                    AlternativIspelaSidan();//går till spela sidan med fyra alternativ

                    break;
            }
        }
        static void TreAlternativStatic()
        {
            string prompt = ("Välja ett alternativ med  ↑ ↓ Enter från tangentbordet ");
            string[] alternativ = { "Ändra information", "Om uss", "Spela" };
            Menyn objekt20 = new Menyn(prompt, alternativ);
            int valdIndex = objekt20.Springa();



            switch (valdIndex)
            {
                case 0:

                    Clear();

                    StartIgenEfterBytaInfo();

                    TextGrafik obj345 = new TextGrafik();
                    obj345.BytaTextFilTavlan();

                    Clear();
                    StartIgenMenyn();

                    obj345.VissaBytadeTextFilTavlan();

                    TreAlternativStatic();

                    break;

                case 1:

                    Clear();

                    StartIgenMenyn();

                    TextGrafik obj6767 = new TextGrafik();

                    obj6767.SkapaEnTextFil();

                    obj6767.VissaOmUssTexFilen();

                    for (int i = 0; i < 8; i++)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" - - - ");
                        Thread.Sleep(i + 50);//en pause
                        Console.ResetColor();
                    }
                    Console.ResetColor();
                    Clear();
                    StartIgenMenyn();

                    TextGrafik obj6780 = new TextGrafik();
                    obj6780.VissaBytadeTextFilTavlan();


                    TreAlternativStatic();

                    break;

                case 2:

                    StartIgenMenyn();//rensa skärmen och börja om

                    AlternativIspelaSidan();//går till spela sidan med fyra alternativ

                    break;
            }
        }
        static void AlternativIspelaSidan() //en metod som visa rubrik ov spela sidan
        {
            TextGrafik objekt12 = new TextGrafik();
            objekt12.TextGrafikStarta();


            string prompt = ("Välja ett alternativ med  ↑ ↓ eller Enter från tangentbordet");
            string[] alternativ = { "Hård", "Genomsnittlig", "Lätt", "Tillbaka" };
            Menyn objekt67 = new Menyn(prompt, alternativ);//kalla på Springa metoden i Meny klassen
            int valdIndex = objekt67.Springa();

            switch (valdIndex)
            {
                case 0:// Om hård nivå har kommit in
                    Clear();

                    StartIgenIspelaSidan();

                    Beep(150, 200);//beep ljud

                    WriteLine("\t\t\tHård nivå vald.Lycka till");


                    TextGrafik objekt3130 = new TextGrafik();
                    objekt3130.TextGrafikSpelaSidanHardLevel();


                    AlternativIspelaSidan();//starta igen


                    break;

                case 1: //Om genomsnittlig nivå har kommit in

                    Clear();

                    StartIgenIspelaSidan();//Vissa rubriken igen

                    Beep(150, 200);//beep ljud

                    WriteLine("\t\t\tMedelmåttigt nivå vald.");


                    RubrikFaryAvarageLevel();

                    AlternativIspelaSidan();//starta igen


                    break;

                case 2:

                    Clear();
                    StartIgenIspelaSidan();

                    Write("\t\t\t\t\tLätt nivå vald.");
                    Beep(150, 200);//beep ljud


                    TextGrafik objekt313 = new TextGrafik();
                    objekt313.RubrikFaryEasyLevel();


                    AlternativIspelaSidan();//starta igen


                    break;

                case 3:

                    Clear();
                    StartIgenMenyn();

                    TextGrafik obj678 = new TextGrafik();
                    obj678.VissaBytadeTextFilTavlan();

                    TreAlternativStatic();


                    break;
            }
        }

        public static void RubrikFaryAvarageLevel()
        {

            string avarage1 = @"
  ____  
 /    |  
Y  o  | 
|     |  
|  _  l 
|  |  |
l__j__j
                               ";
            string avarage2 = @"
  ____ __ __   
 /    |  T  |
Y  o  |  |  Y  
|     |  |  |    
|  _  l  :  |  
|  |  |\   /
l__j__j \_/
                                                                              
                                   ";
            string avarage3 = @"
  ____ __ __  ____ 
 /    |  T  |/    |    
Y  o  |  |  Y  o  |  
|     |  |  |     |    
|  _  l  :  |  _  |    
|  |  |\   /|  |  |  
l__j__j \_/ l__j__l
                                                                              
                                   ";
            string avarage4 = @"
  ____ __ __  ____ ____    
 /    |  T  |/    |    \ 
Y  o  |  |  Y  o  |  D  Y  
|     |  |  |     |    /
|  _  l  :  |  _  |    \  
|  |  |\   /|  |  |  .  |  
l__j__j \_/ l__j__l__j\_l
                                                                              
                                   ";
            string avarage5 = @"
  ____ __ __  ____ ____   ____  
 /    |  T  |/    |    \ /    T
Y  o  |  |  Y  o  |  D  Y  o  Y   
|     |  |  |     |    /|     |  
|  _  l  :  |  _  |    \|  _  |  
|  |  |\   /|  |  |  .  |  |  |     
l__j__j \_/ l__j__l__j\_l__j__l
                                                                              
                                    ";
            string avarage6 = @"
  ____ __ __  ____ ____   ____  ____  
 /    |  T  |/    |    \ /    T/    T 
Y  o  |  |  Y  o  |  D  Y  o  Y   __j
|     |  |  |     |    /|     |  T  Y    
|  _  l  :  |  _  |    \|  _  |  l_ |   
|  |  |\   /|  |  |  .  |  |  |     |     
l__j__j \_/ l__j__l__j\_l__j__l___,_l
                                                                              
                                    ";
            string avarage7 = @"
  ____ __ __  ____ ____   ____  ____   ___     
 /    |  T  |/    |    \ /    T/    T /  _]    
Y  o  |  |  Y  o  |  D  Y  o  Y   __j/  [_    
|     |  |  |     |    /|     |  T  Y    _]    
|  _  l  :  |  _  |    \|  _  |  l_ |   [_     
|  |  |\   /|  |  |  .  |  |  |     |     T    
l__j__j \_/ l__j__l__j\_l__j__l___,_l_____j    
                                                                              
                                   ";

            string avarage8 = @"
  ____ __ __  ____ ____   ____  ____   ___      _        
 /    |  T  |/    |    \ /    T/    T /  _]    | T    
Y  o  |  |  Y  o  |  D  Y  o  Y   __j/  [_     | |     
|     |  |  |     |    /|     |  T  Y    _]    | l___Y  
|  _  l  :  |  _  |    \|  _  |  l_ |   [_     |     |   
|  |  |\   /|  |  |  .  |  |  |     |     T    |     |  
l__j__j \_/ l__j__l__j\_l__j__l___,_l_____j    l_____l

                                    ";

            string avarage9 = @"
  ____ __ __  ____ ____   ____  ____   ___      _       ___  
 /    |  T  |/    |    \ /    T/    T /  _]    | T     /  _|  
Y  o  |  |  Y  o  |  D  Y  o  Y   __j/  [_     | |    /  [_|  
|     |  |  |     |    /|     |  T  Y    _]    | l___Y    _|  
|  _  l  :  |  _  |    \|  _  |  l_ |   [_     |     |   [_l  
|  |  |\   /|  |  |  .  |  |  |     |     T    |     |     T
l__j__j \_/ l__j__l__j\_l__j__l___,_l_____j    l_____l_____j 
                                                                              
                                   ";

            string avarage10 = @"
  ____ __ __  ____ ____   ____  ____   ___      _       ___ __ __   
 /    |  T  |/    |    \ /    T/    T /  _]    | T     /  _|  T  | 
Y  o  |  |  Y  o  |  D  Y  o  Y   __j/  [_     | |    /  [_|  |  |
|     |  |  |     |    /|     |  T  Y    _]    | l___Y    _|  |  Y    
|  _  l  :  |  _  |    \|  _  |  l_ |   [_     |     |   [_l  :  |   
|  |  |\   /|  |  |  .  |  |  |     |     T    |     |     T\   /
l__j__j \_/ l__j__l__j\_l__j__l___,_l_____j    l_____l_____j \_/


                                  ";
            string avarage11 = @"
  ____ __ __  ____ ____   ____  ____   ___      _       ___ __ __   ___      
 /    |  T  |/    |    \ /    T/    T /  _]    | T     /  _|  T  | /  _| 
Y  o  |  |  Y  o  |  D  Y  o  Y   __j/  [_     | |    /  [_|  |  |/  [_| 
|     |  |  |     |    /|     |  T  Y    _]    | l___Y    _|  |  Y    _| 
|  _  l  :  |  _  |    \|  _  |  l_ |   [_     |     |   [_l  :  |   [_|     
|  |  |\   /|  |  |  .  |  |  |     |     T    |     |     T\   /|     |    
l__j__j \_/ l__j__l__j\_l__j__l___,_l_____j    l_____l_____j \_/ l_____l
                                                                              
 
                                     ";

            string avarage12 = @"
  ____ __ __  ____ ____   ____  ____   ___      _       ___ __ __   ___ _     
 /    |  T  |/    |    \ /    T/    T /  _]    | T     /  _|  T  | /  _| T    
Y  o  |  |  Y  o  |  D  Y  o  Y   __j/  [_     | |    /  [_|  |  |/  [_| |    
|     |  |  |     |    /|     |  T  Y    _]    | l___Y    _|  |  Y    _| l___ 
|  _  l  :  |  _  |    \|  _  |  l_ |   [_     |     |   [_l  :  |   [_|     T
|  |  |\   /|  |  |  .  |  |  |     |     T    |     |     T\   /|     |     |
l__j__j \_/ l__j__l__j\_l__j__l___,_l_____j    l_____l_____j \_/ l_____l_____j
                                                                              
    ";
            string[] avarage = { avarage1, avarage2, avarage3, avarage4, avarage5, avarage6, avarage7, avarage8, avarage9, avarage10, avarage11, avarage12 };

            for (int v = 0; v < 12; v++)
            {

                // få en array med värde av ConsoleColor enumeration medlem
                ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

                ////SetCursorPosition(v + 10, 10);
                Console.ForegroundColor = colors[v];
                Console.WriteLine(avarage[v]);
                SetCursorPosition(v + 10, 10);


                Thread.Sleep(350);

            }
        }
    }
}



