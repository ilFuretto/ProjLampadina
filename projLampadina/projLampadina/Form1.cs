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
            lampadina.Posizione = 153; // Imposta posizione iniziale
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
        }

        private void bottoneGiu_MouseDown(object sender, MouseEventArgs e)
        {
            lampadina.Abbassa();
            AggiornaPosizione();
        }

        private void bottoneSu_MouseDown(object sender, MouseEventArgs e)
        {
            lampadina.Alza();
            AggiornaPosizione();
        }

        private void bottone_MouseUp(object sender, MouseEventArgs e)
        {
            bottonePremuto = false;
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            lampadina.Posizione = 153; // Reset posizione
            AggiornaPosizione();
        }

        private void AggiornaPosizione()
        {
            pictureBox1.Location = new Point(371, lampadina.Posizione);
            pictureBox2.Location = new Point(371, lampadina.Posizione);
        }
    }
}
