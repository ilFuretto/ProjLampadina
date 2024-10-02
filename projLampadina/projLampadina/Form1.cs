using System.Windows.Forms;

namespace projLampadina
{
    public partial class Form1 : Form
    {
        private bool bottonePremuto = false;

        //aaaa
        public Form1()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bottoneGiu_Click(object sender, EventArgs e)
        {

        }

        private void bottoneSu_Click(object sender, EventArgs e)
        {

        }


        private async void spostaImmagine(int direction)
        {
            bottonePremuto = true;
            while (bottonePremuto&&(pictureBox1.Top+direction>=0&&pictureBox1.Bottom+direction <= this.ClientSize.Height)&&(pictureBox2.Top+direction >= 0 && pictureBox2.Bottom+direction <= this.ClientSize.Height))
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + direction);
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + direction);

                await Task.Delay(50);
            }
        }

        private void bottoneGiu_MouseDown(object sender, MouseEventArgs e)
        {
            spostaImmagine(1);
        }

        private void bottoneSu_MouseDown(object sender, MouseEventArgs e)
        {
            spostaImmagine(-1);
        }

        private void bottone_MouseUp(object sender, MouseEventArgs e)
        {
            bottonePremuto = false;
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(371, 153);
            pictureBox2.Location = new Point(371, 153);

        }
    }
}