using System;
using S_Kapicak;

namespace S_Kapicak
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Získání instance Singletonu a zavolání metody ShowMessage
            Singleton instance1 = Singleton.GetInstance();
            instance1.ShowMessage();

            // Ověření, že při opakovaném volání se vrací stále stejná instance
            Singleton instance2 = Singleton.GetInstance();
            Console.WriteLine("MTV, Jam of the Week." );
        }
    }
}