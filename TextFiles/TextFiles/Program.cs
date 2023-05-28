using GameProjekt;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;



namespace GameProjekt
{
    public class Program
    {
        public static List<object> BankKontonListan { get; private set; } = new List<object>();

        static void Main()
        {
            TextGrafik ob = new TextGrafik();
            ob.TextGrafikStarta();//visa Huvud rubrik
            ob.StartaTavlan();//visa andra rubrik 
            ob.InfoTavlan();

            string prompt1 = ("Välja ett alternativ med  ↑ ↓ eller Enter "); //Visa Huvud Alternativ 
            string[] alternativ1 = { "Hård", "Genomsnittlig", "Lätt", "Tillbaka" };
            Menyn ob9 = new Menyn(prompt1, alternativ1);
            ob9.FyraAlternativ();

        }
    }
}










