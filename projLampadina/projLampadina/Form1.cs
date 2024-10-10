using System.Windows.Forms;

namespace projLampadina
{
    public partial class Form1 : Form
    {
        bool bottonePremuto=false;
        private Lampadina lampadina;

        public Form1()
        {
            InitializeComponent();
            lampadina = new Lampadina();
            lampadina.Posizione = 153;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AggiornaVisibilita();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lampadina.Spegni();
            AggiornaVisibilita();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lampadina.Accendi();
            AggiornaVisibilita();
        }

        private async void bottoneGiu_MouseDown(object sender, MouseEventArgs e)
        {
            bottonePremuto = true;
            while (bottonePremuto)
            {
                lampadina.Abbassa();
                AggiornaPosizione();
                await Task.Delay(50);
            }
        }

        private async void bottoneSu_MouseDown(object sender, MouseEventArgs e)
        {
            bottonePremuto = true;
            while (bottonePremuto)
            {
                lampadina.Alza();
                AggiornaPosizione();
                await Task.Delay(50);
            }
        }

        private void bottone_MouseUp(object sender, MouseEventArgs e)
        {
            bottonePremuto = false;
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            lampadina.Posizione = 153;
            AggiornaPosizione();
            lampadina.Spegni();
            AggiornaVisibilita();
        }

        private void AggiornaPosizione()
        {
            int altezzaMinima = 0;
            int altezzaMassima = this.ClientSize.Height - pictureBox1.Height;

            if (lampadina.Posizione < altezzaMinima)
            {
                lampadina.Posizione = altezzaMinima;
            }
            else if (lampadina.Posizione > altezzaMassima)
            {
                lampadina.Posizione = altezzaMassima;
            }
            pictureBox1.Location = new Point(371, lampadina.Posizione);
            pictureBox2.Location = new Point(371, lampadina.Posizione);
        }
        private void AggiornaVisibilita()
        {
            pictureBox1.Visible = lampadina.Accesa;
            pictureBox2.Visible = !lampadina.Accesa;
        }
    }
}
