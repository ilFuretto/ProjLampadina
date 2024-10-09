namespace projLampadina
{
    public class Lampadina
    {
        private bool accesa;
        private int posizione;

        public bool Accesa
        {
            get { return accesa; }
            set { accesa = value; }
        }

        public int Posizione
        {
            get { return posizione; }
            set { posizione = value; }
        }

        public void Accendi()
        {
            Accesa = true;
        }

        public void Spegni()
        {
            Accesa = false;
        }

        public void Alza()
        {
            Posizione -= 5; // Sposta verso l'alto
        }

        public void Abbassa()
        {
            Posizione += 5; // Sposta verso il basso
        }
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}