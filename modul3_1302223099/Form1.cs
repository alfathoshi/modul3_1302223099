﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302223099
{

    
    public partial class Form1 : Form
    {
        private int angka1;
        private int angka2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += button6.Text;
            textBox1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            textBox1.Text += button1.Text;
            textBox1.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
            angka1 = int.Parse(textBox1.Text);
           
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
            textBox1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
            textBox1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
            textBox1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
            textBox1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
            textBox1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
            textBox1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
            textBox1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
            textBox1.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            angka2 = int.Parse(textBox1.Text);

            
            textBox1.Text = (angka1 + angka2).ToString();
        }
    }
}
