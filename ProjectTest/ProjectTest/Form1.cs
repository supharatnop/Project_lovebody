using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void button1_Click_1(object sender, EventArgs e)//ปุ่ม button1
        {
            Form2 form_2 = new Form2();//ประกาศตัวแปล form_2 เก็บ  Form2
            form_2.ShowDialog();//show form และใช้งานได้แค่ form เดียว
        }

        private void button2_Click(object sender, EventArgs e)//ปุ่ม button2
        {
            Form3 form_3 = new Form3();//ประกาศตัวแปล form_3 เก็บ  Form3
            form_3.ShowDialog();//show form และใช้งานได้แค่ form เดียว
        }

        private void label5_Click(object sender, EventArgs e)//ปุ่ม button3
        {
            Process.Start("http://www.bangpakokhospital.com/care_blog/content/วีธีคำนวณดัชนีมวลกายBMI");
            //คลิก http://www.bangpakokhospital.com/care_blog/content/วีธีคำนวณดัชนีมวลกายBMI จะลิ้งค์ไปยังที่อยู่บนเว็บ
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.fatnever.com/bmr/"); //คลิก https://www.fatnever.com/bmr/ จะลิ้งค์ไปยังที่อยู่บนเว็บ
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.sanook.com/women/66559");//คลิก https://www.sanook.com/women/66559 จะลิ้งค์ไปยังที่อยู่บนเว็บ
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Process.Start("http://fotomelia.com/wp-content/uploads/2017/01/bonhomme-blanc-3d-images-gratuites-8-1560x1560.jpg");
            //คลิก http://fotomelia.com/wp-content/uploads/2017/01/bonhomme-blanc-3d-images-gratuites-8-1560x1560.jpg จะลิ้งค์ไปยังที่อยู่บนเว็บ
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Process.Start("https://material.io/icons");//คลิก https://material.io/icons จะลิ้งค์ไปยังที่อยู่บนเว็บ
        }

        private void label11_Click(object sender, EventArgs e)//label11
        {
            
        }

        private void label6_Click(object sender, EventArgs e)//label6
        {
            Process.Start("https://health.kapook.com/view90923.html");//คลิก https://health.kapook.com/view90923.html จะลิ้งค์ไปยังที่อยู่บนเว็บ
        }

        private void label11_Click_1(object sender, EventArgs e)//label11
        {
            Process.Start("https://github.com/supharatnop/Project_lovebody");//คลิก https://github.com/supharatnop/Project_lovebody จะลิ้งค์ไปยังที่อยู่บนเว็บ
        }

        private void label10_Click(object sender, EventArgs e)//label10
        {

        }
    }
}
