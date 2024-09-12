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
            pictureBox1.Image = Image.FromFile("C:\\Users\\student\\source\\repos\\ForGitHub\\gavgavgav\\img\\kefir.jpg");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\student\\source\\repos\\ForGitHub\\gavgavgav\\img\\stoLitrovPiva.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\student\\source\\repos\\ForGitHub\\gavgavgav\\img\\sho.jpg");
        }
    }
}
