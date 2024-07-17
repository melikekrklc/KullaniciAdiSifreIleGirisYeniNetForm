using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formnet2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;

            if (kullaniciAdi == " ")
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz.");
            }
            if (sifre == " ")

            {
                MessageBox.Show("Sifre boş bırakılamaz.");
            }

            if (kullaniciAdi == "Melike Karakılıç" && sifre == "Bilgisayar Mühendisliği")
            {
                MessageBox.Show("Hoşgeldiniz");
            }

            else
                MessageBox.Show("Kullanici adı veya şifre hatalı.\nLütfen tekrar deneyin.");
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox1.Focus();//messageboxtan sonra okun textbox1 de bulunmasını sağlar.
        }


    }
}
