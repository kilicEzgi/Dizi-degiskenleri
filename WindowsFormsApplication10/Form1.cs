using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayi = { 12,34,45,56,67,89,98};
        private void button1_Click(object sender, EventArgs e)
        {
            Array.Sort(sayi);
            listBox1.Items.Clear();  
            for (int i = 0; i < sayi.Length; i++)
            {
                listBox1.Items.Add(sayi[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Reverse(sayi);
            listBox1.Items.Clear();
            for (int i = 0;i <sayi.Length; i++)
            {
                listBox1.Items.Add(sayi[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "En Büyük Sayı" + sayi.Max().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "En Küçük Sayı" + sayi.Min().ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
                label3.Text = "Toplam Sayı" + sayi.Sum().ToString();
        }

       
        }

       
         
            
        }
   


