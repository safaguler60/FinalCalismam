using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCalismam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //girilen plakaya göre şehir söyleme
            int sehir;
            sehir = Convert.ToInt32(textBox1.Text);
            if (sehir < 0 || sehir > 81)
            {
                MessageBox.Show("Hatalı Şehir");
                this.Close();
               
            }else { 

            string[] dizi = new string[81];
            dizi[74] = "Bartın";
            dizi[60] = "TOKAT";
            dizi[35] = "İzmir";
            dizi[34] = "İstanbul";
            dizi[55] = "Samsun";
            dizi[61] = "Trabzon";
            dizi[06] = "Ankara";
            dizi[01] = "Adana";
            
            label1.Text = dizi[sehir];
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Top = label2.Top - 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Left = label2.Left - 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Left = label2.Left + 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Top = label2.Top + 3;
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            sayac = sayac + 1;
            progressBar1.Maximum = 1000;
            progressBar1.Value = sayac;
            label3.Top = label3.Top + 1;
            if (sayac%2==0)
            {
                label3.ForeColor = Color.Blue;

            }else
            {
                label3.ForeColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            MessageBox.Show(hos());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aqua;
            button2.BackColor = Color.Gold;
            button3.BackColor = Color.Blue;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Green;
            button6.BackColor = Color.White;
            this.BackColor = Color.CadetBlue;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        { 
            //Güncel saati yazma (LongDate silersek tarihi de yazar)
            label4.Text = DateTime.Now.ToLongDateString();
            
        }


        private void button9_Click(object sender, EventArgs e)
        {
            //Checkbox ve radio buttonu listboxa ekleme
            listBox1.Items.Clear();
            listBox1.Items.Add(comboBox1.SelectedItem);
            if (checkBox1.Checked == true) listBox1.Items.Add("Klima");
            if (checkBox2.Checked == true) listBox1.Items.Add("Koltuk ısıtma");
            if (checkBox3.Checked == true) listBox1.Items.Add("Sunroof");
            if (radioButton1.Checked == true) listBox1.Items.Add("Çelik Jant");
            if (radioButton2.Checked == true) listBox1.Items.Add("Klasik Jant");

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(textBox2.Text);
            sayi2 = Convert.ToInt32(textBox3.Text);
            int toplam = sayi1 + sayi2;
            label5.Text = Convert.ToString(toplam);


        }

        private void button11_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(textBox2.Text);
            sayi2 = Convert.ToInt32(textBox3.Text);
            int toplam = sayi1 - sayi2;
            label5.Text = Convert.ToString(toplam);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(textBox2.Text);
            sayi2 = Convert.ToInt32(textBox3.Text);
            int toplam = sayi1 * sayi2;
            label5.Text = Convert.ToString(toplam);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(textBox2.Text);
            sayi2 = Convert.ToInt32(textBox3.Text);
            int toplam = sayi1 / sayi2;
            label5.Text = Convert.ToString(toplam);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            //Textbox boş ise butonu pasif yapma
            if (textBox1.Text==string.Empty)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //listboxlar arası item değiştirme
            listBox3.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox3.SelectedItem);
            listBox3.Items.Remove(listBox3.SelectedItem);
        }
        void temizle()
        {
            //prosedür ile listbox temizleme
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            temizle();
        }
        int sayi = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
           
            sayi = sayi + 1;
          
            label6.Text = "Geçirdiğiniz süre= "+ Convert.ToString(sayi);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //rastgele 3 sayı atayıp aynı olursa bingo
            Random rast = new Random();
            int tut = rast.Next(10);
            int tut1 = rast.Next(10);
            int tut2 = rast.Next(10);
            label7.Text = Convert.ToString(tut);
            label8.Text = Convert.ToString(tut1);
            label9.Text = Convert.ToString(tut2);
            if (tut==tut1 && tut1==tut2)
            {
                label7.ForeColor = Color.Green;
                label8.ForeColor = Color.Green;
                label9.ForeColor = Color.Green;
                MessageBox.Show("BİNGO");
            }else
            {
                label7.ForeColor = Color.Red;
                label8.ForeColor = Color.Red;
                label9.ForeColor = Color.Red;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //kelime parçalama
            listBox4.Items.Clear();
            string kelime = textBox4.Text;
            string[] parcalar;
            parcalar = kelime.Split(textBox5.Text.ToCharArray());
            listBox4.Items.Add(parcalar[0]);
            listBox4.Items.Add(parcalar[1]);
            listBox4.Items.Add(parcalar[2]);
            
            
        }
        int dikalan(int a, int b)
        {
            //dikdörtgen alanı fonksiyon ile
            return a * b;
        }
        string hos()
        {
            return "Hoşgeldiniz";
        }
        private void button19_Click(object sender, EventArgs e)
        {
            //fonksiyon ile dikdörtgen alanı bulma
            label10.Text = Convert.ToString(dikalan(5,4));

        }
        double vizefinal(double a, double b)
        {
            return (a * 0.40) + (b * 0.60);
        }
        private void button20_Click(object sender, EventArgs e)
        {
            //vize final hesaplaması
            double vize = Convert.ToDouble(textBox6.Text);
            double final = Convert.ToDouble(textBox7.Text);
            if (final < 50)
            {
                label11.Text = "Kaldınız: "+ Convert.ToString(vizefinal(vize, final));
            }else {
                label11.Text = Convert.ToString(vizefinal(vize, final));
            }
            

        }

        private void button21_Click(object sender, EventArgs e)
        {
            //textboxdan kelime seçimi
            textBox8.Focus();
            textBox8.Select(2, 3);
        }

        string asal(string ss)
        {
            int a = Convert.ToInt32(ss);
            string sonuc = "Asaldır";
            bool bayrak = false;
            for (int x = 2; x < a; x++)
                if (a % x == 0) bayrak = true;
            if (bayrak == true) sonuc = "Asal değildir";

            return sonuc;
        }
        private void button22_Click(object sender, EventArgs e)
        {
            label12.Text = asal(textBox9.Text);
        }
    }
}
