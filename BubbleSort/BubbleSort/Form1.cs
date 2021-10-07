using Algorithm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleSort
{
    public partial class Form1 : Form
    {
        AlgorithmBase<int> algorithm = new BbSort<int>();
        public Form1() 
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int value))
            {
                algorithm.Items.Add(value);
                label1.Text += " " + value;
            }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            algorithm.Sort();
            foreach (var item in algorithm.Items)
            {
                label2.Text += " " + item;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            label2.Text = "";
        }
    }
}
