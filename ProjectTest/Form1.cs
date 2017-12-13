using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form_2 = new Form2();//ประกาศตัวแปล form_2 เก็บ  Form2
            form_2.ShowDialog();//show form และใช้งานได้แค่ form เดียว
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form_3 = new Form3();//ประกาศตัวแปล form_3 เก็บ  Form3
            form_3.ShowDialog();//show form และใช้งานได้แค่ form เดียว
        }
    }
}
