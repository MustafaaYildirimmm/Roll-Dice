using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RollDice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int sayac = 0, denemeSayisi = 0;
        bool hileVarmi = false;
        string s;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            
           
            if (hileVarmi)
            { 
                label1.Text = "6";
                label2.Text = "6";
            }
            else
            {
                label1.Text = rnd.Next(1, 7).ToString();
                label2.Text = rnd.Next(1, 7).ToString();

                s = String.Format(denemeSayisi.ToString() + ".deneme " + label1.Text + "-" + label2.Text + " - Saat: " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
            }
            if (sayac == 15)
            {
                timer1.Stop();
                sayac = 0;
                hileVarmi = false;
                listBox1.Items.Add(s);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            hileVarmi = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            denemeSayisi++;
        }
    }
}
