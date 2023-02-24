using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            if (student.Check(textBox2.Text) != -1 && student.Check(numericUpDown1.Value.ToString()) != -1 &&  student.CheckName(textBox1.Text)!="null")
            {
                student.height = double.Parse(numericUpDown1.Value.ToString());
                double food = double.Parse(textBox2.Text);
                student.name = textBox1.Text; 
                student.SetEat(food);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
