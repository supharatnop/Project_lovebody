using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTest
{
    public partial class Form4 : Form
    {
        public static string name;// static คือ input ข้าม class //สร้าง method ชื่อ name
        public Form4()
        {
            InitializeComponent();
        }
        public string read_file()//สร้าง method ชื่อ read_file
        {
            string txt = File.ReadAllText(Application.StartupPath+@"\" +name+".txt");//สร้างตัวแปล txt เก็บ file
            return txt;//ส่ง txt กลับไป
        }

        private void Form4_Load(object sender, EventArgs e)//Form4
        {
            textBox1.Text = read_file();//แสดงค่า read_file ใน textBox1
        }

        private void button1_Click(object sender, EventArgs e)//ปุ่ม button1
        {
            this.Close();//คำสั่งปิดโปรแกรม
        }
    }
}
