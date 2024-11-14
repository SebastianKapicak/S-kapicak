namespace S_Kapicak
{
    public class Singleton
    {
        // Soukromý statický atribut, který uchovává jedinou instanci třídy
        private static Singleton _instance;

        // Soukromý konstruktor, aby nebylo možné vytvářet instance zvenčí
        private Singleton()
        {
        }

        // Veřejná statická metoda, která vrátí jedinou instanci třídy
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        // Metoda pro demonstraci použití singletonu
        public void ShowMessage()
        {
            Console.WriteLine("Toto je instance Singleton třídy.");
        }
    }
}