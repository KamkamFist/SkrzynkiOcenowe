using System.DirectoryServices;
using System.Net.Mail;
using System.Reflection;
using System.Windows.Forms;

namespace SkrzynkiOcenowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color[] kolorki = { Color.Red, Color.Blue, Color.Orange, Color.Yellow, Color.Green, Color.Purple, Color.Pink, Color.Brown };

        Random random = new Random();



        public async void button1_Click(object sender, EventArgs e)
        {
            czekanie = 10;
            for (int i = 0; i < 30; i++)
            {
                int losowa = random.Next(0, 8);

                textBox1.Text = textBox2.Text;
                textBox1.BackColor = textBox2.BackColor;
                textBox2.Text = textBox3.Text;
                textBox2.BackColor = textBox3.BackColor;
                textBox3.Text = textBox4.Text;
                textBox3.BackColor = textBox4.BackColor;
                textBox4.Text = textBox5.Text;
                textBox4.BackColor = textBox5.BackColor;
                textBox5.Text = textBox6.Text;
                textBox5.BackColor = textBox6.BackColor;
                textBox6.Text = textBox7.Text;
                textBox6.BackColor = textBox7.BackColor;
                textBox7.Text = random.Next(1, 7).ToString();
                textBox7.BackColor = kolorki[losowa];

                czekanie += 10;

                await losowanie();
            }
            MessageBox.Show("Wylosowano: " + textBox4.Text);
        }

        int czekanie = 2;
        async Task losowanie()
        {
            czekanie += 2;
            await Task.Delay(czekanie);
        }

        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var obecna = numericUpDown1.Value;
        }

        public async void button2_Click(object sender, EventArgs e)
        {
            czekanie = 10;
            int obecna = (int)numericUpDown1.Value; // Declare and initialize 'obecna' variable

            for (int i = 0; i < obecna; i++)
            {
                int losowa = random.Next(0, 5);

                textBox1.Text = textBox2.Text;
                textBox1.BackColor = textBox2.BackColor;
                textBox2.Text = textBox3.Text;
                textBox2.BackColor = textBox3.BackColor;
                textBox3.Text = textBox4.Text;
                textBox3.BackColor = textBox4.BackColor;
                textBox4.Text = textBox5.Text;
                textBox4.BackColor = textBox5.BackColor;
                textBox5.Text = textBox6.Text;
                textBox5.BackColor = textBox6.BackColor;
                textBox6.Text = textBox7.Text;
                textBox6.BackColor = textBox7.BackColor;
                textBox7.Text = random.Next(1, 7).ToString();
                textBox7.BackColor = kolorki[losowa];

                await altlosowanie();
            }
            MessageBox.Show("Wylosowano: " + textBox4.Text);
        }

        async Task altlosowanie()
        { 
            czekanie ++;
            await Task.Delay(20);
        }
    }
}
