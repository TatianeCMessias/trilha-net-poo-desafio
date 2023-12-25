using DesafioPOO.Models;
using System;

namespace DesaioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone nokia = new Nokia("81981040481", "nokia", "131314", 64);
            Smartphone iphone = new Iphone("81983557430", "iphone 15", "151515", 300);
            
            Console.WriteLine("========== Smartphone Iphone ==========");
            iphone.InstalarAplicativo("WhatsApp");
            nokia.Ligar();

            Console.WriteLine("=======================================");

            Console.WriteLine("========== Smartphone Nokia ==========");
            nokia.InstalarAplicativo("WhatsApp");
            iphone.ReceberLigacao();    
        }
    }
}