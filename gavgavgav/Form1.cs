using Microsoft.VisualBasic.ApplicationServices;

namespace gavgavgav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\student\\source\\repos\\img\\kefir.jpg");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\student\\source\\repos\\img\\stoLitrovPiva.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\student\\source\\repos\\img\\sho.jpg");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\student\\source\\repos\\img\\cat.jpg");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\student\\source\\repos\\img\\sobaka.jpg");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\student\\source\\repos\\img\\fish.jpg");
        }
    }
}
