using System.IO;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kadi;
        StreamWriter dosya;
        StreamWriter dosya2;
        int sayac = 3;
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("L�tfen kullan�c� ad�n� giriniz!");
                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("�ifre Bo� B�rak�lamaz");
                return;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show("�ifrenizi Tekrar Giriniz");
                return;
            }
            kadi = textBox1.Text;
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("�ifre tekrar� ayn� de�il");
                return;
            }

            if (kadi == "Sema" && textBox2.Text == "12345" && textBox2.Text == textBox3.Text)
            {
                dosya = File.AppendText("dogru.txt");
                dosya.WriteLine("Kullan�c� adi: " + textBox1.Text + "Sifre: " + textBox2.Text + " " + DateTime.Now);
                dosya.Close();
                MessageBox.Show("Bilgiler Ba�ar�yla kaydedildi");
                Form2 goster = new Form2();

                this.Hide();
                goster.ShowDialog();
                this.Close();

            }
            else
            {
                dosya2 = File.AppendText("yanlis.txt");
                dosya2.WriteLine("Kullan�c� adi: " + textBox1.Text + "Sifre: " + textBox2.Text + " " + DateTime.Now);
                dosya2.Close();
                sayac = sayac - 1;
                MessageBox.Show("Yanl�� kullan�c� ad� veya �ifre kalan hakk�n�z : " + sayac);
            }
            if (sayac == 0)
            {
                Application.Exit();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
