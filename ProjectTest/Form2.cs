using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)//Form2
        {

        }
        
        private void open_tip(string name1) //ไว้ส่งข้อมูลข้าม Form //สร้าง method ชื่อ open_tip
        {
            Form4.name = name1;//ส่งข้อมูล name1 ไปยัง name ที่ Form4
            Form4 f4 = new Form4();//สร้างตัวแปร f4 เก็บ Form4

            f4.ShowDialog();//แสดง Form4
        }
        private void button1_Click(object sender, EventArgs e)//ปุ่ม button1
        {
            if (textBox1.Text != "" && textBox2.Text != "")//ถ้า textBox1 และ textBox2 มีข้อมูล
            {
                double w, h, bmi;//สร้างตัวแปร w, h,bmi ที่เป็น double
                w = double.Parse(textBox1.Text);//รับค่าจาก textBox1 เก็บไว้ใน w
                h = double.Parse(textBox2.Text);//รับค่าจาก textBox2 เก็บไว้ใน h
                bmi = w / (h * h);//สร้างตัวแปร bmi เก็บ w / (h * h)
                label5.Text = bmi.ToString();//ให้ bmi แสดงที่ label5

                if (bmi < 18.5)//เงื่อนไข bmi < 18.5
                {
                    label7.Text = "น้ำหนักต่ำกว่าเกณฑ์";//แสดง น้ำหนักต่ำกว่าเกณฑ์ ที่ label7
                }
                else if (bmi >= 18.5 && bmi <= 22.9)//เงื่อนไข bmi >= 18.5 && bmi <= 22.9
                {
                    label7.Text = "สมส่วน";//แสดง สมส่วน ที่ label7
                }
                else if (bmi >= 23.0 && bmi <= 24.9)//เงื่อนไข bmi >= 23.0 && bmi <= 24.9
                {
                    label7.Text = "น้ำหนักเกิน";//แสดง น้ำหนักเกิน ที่ label7
                }
                else if (bmi >= 25.0 && bmi <= 29.9)//เงื่อนไข bmi >= 25.0 && bmi <= 29.9
                {
                    label7.Text = "โรคอ้วน";//แสดง โรคอ้วน ที่ label7
                }
                else if (bmi > 30)//เงื่อนไข bmi > 30
                {
                    label7.Text = "โรคอ้วนอันตราย";//แสดง โรคอ้วนอันตราย ที่ label7
                }

                switch (label7.Text)//เซ็คเงื่อนไขจาก label7
                {
                    case "น้ำหนักต่ำกว่าเกณฑ์"://เงื่อนไข น้ำหนักต่ำกว่าเกณฑ์
                        open_tip("1");//ส่งข้อมูลไปยัง open_tip
                        break;//หยุดการทำงาน
                    case "สมส่วน"://เงื่อนไข สมส่วน
                        open_tip("สมส่วน");//ส่งข้อมูลไปยัง open_tip
                        break;//หยุดการทำงาน
                    case "น้ำหนักเกิน"://เงื่อนไข น้ำหนักเกิน
                        open_tip("2");//ส่งข้อมูลไปยัง open_tip
                        break;//หยุดการทำงาน
                    case "โรคอ้วน"://เงื่อนไข โรคอ้วน
                        open_tip("2");//ส่งข้อมูลไปยัง open_tip
                        break;//หยุดการทำงาน
                    case "โรคอ้วนอันตราย"://เงื่อนไข โรคอ้วนอันตราย
                        open_tip("2");//ส่งข้อมูลไปยัง open_tip
                        break;//หยุดการทำงาน
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูล");//แสดง กรุณากรอกข้อมูล บน  MessageBox
            }
        }

        private void button2_Click(object sender, EventArgs e)//ปุ่ม button2
        {
            textBox1.Text = "";//Claer textBox1
            textBox2.Text = "";//Claer textBox2
            label5.Text = "";//Claer label5
            label7.Text = "";//Claer label7
            textBox1.Focus();//scorebar ไปปรากฏที่ textBox1
        }

        private void label7_Click(object sender, EventArgs e)//label7
        {

        }

        private void button3_Click(object sender, EventArgs e)//ปุ่ม button3
        {
            this.Close();//ปิดโปรแกรม
        }
        public static bool check_num(string data)//สร้าง method ชื่อ check_num 
        {
            bool c1 = false; //เป็นตัวหนังสือ //c1 = false เป็นค่าเริ่มต้น
            if (System.Text.RegularExpressions.Regex.IsMatch(data, "[^0-9.]+")) //เงื่อนไขให้เขียนตัวเลขและจุดได้เท่านั้น 
            {
                c1 = false;//ไม่ตรงตามเงื่อนไข จะเป็น false
            }
            else
            {
                c1 = true;//ตรงตามเงื่อนไข จะเป็น true
            }
            return c1;//ส่งค่า c1 กลับ 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//ปุ่มtextBox1
        {
            if (check_num(textBox1.Text) == false)//รับข้อมูลจาก textBox_age เซ็คตามเงื่อนไข check_num เท่ากับ false
            {
                MessageBox.Show("กรุณากรอกตัวเลข");//จะแสดงข้อความ กรุณากรอกตัวเลข บน MessageBox
                textBox1.Text = "";//เปลี่ยนค่า textBox1 ให้ว่างเปล่า
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//ปุ่มtextBox2
        {
            if (check_num(textBox2.Text) == false)//รับข้อมูลจาก textBox_age เซ็คตามเงื่อนไข check_num เท่ากับ false
            {
                MessageBox.Show("กรุณากรอกตัวเลข");//จะแสดงข้อความ กรุณากรอกตัวเลข บน MessageBox
                textBox2.Text = "";//เปลี่ยนค่า textBox2 ให้ว่างเปล่า
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//comboBox1
        {

        }
    }
}
