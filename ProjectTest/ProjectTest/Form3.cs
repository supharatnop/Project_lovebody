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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)//label2
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//comboBox1
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)//Form3
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;//คำสั่งให้ไม่สามารถเขียนลง comboBox1
            comboBox1.Items.Add("ไม่ออกกำลังกายหรือออกกำลังกายน้อยมาก");//combobox1 แสดงไม่ออกกำลังกายหรือออกกำลังกายน้อยมาก
            comboBox1.Items.Add("ออกกำลังกายน้อยเล่นกีฬา 1-3 วัน/สัปดาห์");//combobox1 แสดงออกกำลังกายน้อยเล่นกีฬา 1-3 วัน/สัปดาห์
            comboBox1.Items.Add("ออกกำลังกายปานกลางเล่นกีฬา 3-5 วัน/สัปดาห์");//combobox1 แสดงออกกำลังกายปานกลางเล่นกีฬา 3-5 วัน/สัปดาห์
            comboBox1.Items.Add("ออกกำลังกายหนักเล่นกีฬา 6-7 วัน/สัปดาห์");//combobox1 แสดงออกกำลังกายหนักเล่นกีฬา 6-7 วัน/สัปดาห์
            comboBox1.Items.Add("ออกกำลังกายหนักมากเป็นหนักกีฬา");//combobox1 แสดงออกกำลังกายหนักมากเป็นหนักกีฬา
        }

        private void button1_Click(object sender, EventArgs e)//ปุ่ม button1
        {
            if (textBox_w.Text != "" && textBox_h.Text != "" && textBox_age.Text != "")
            //ถ้า textBox_w , textBox_h และ textBox_age มีข้อมูล
            {
                double sex, age, w, h, total, td, se1 = 0;//สร้างตัวแปล sex, age, w, h, total, td, se1=0 ที่เป็น  double

                w = double.Parse(textBox_w.Text);//รับค่าจาก textBox_w เก็บไว้ใน w
                h = double.Parse(textBox_h.Text);//รับค่าจาก textBox_h เก็บไว้ใน h
                age = double.Parse(textBox_age.Text);//รับค่าจาก textBox_age เก็บไว้ใน age

                sex = 0;//กำหนดตัวแปล sex = 0
                if (radioButton1.Checked)//เงื่อนไข radioButton1.Checked
                {
                    se1 = (66 + (13.7 * w) + (5 * h) - (6.8 * age));//คำนวณ (66 + (13.7 * w) +(5 * h) - (6.8 * age)) แล้วเก็บไว้ใน se1
                    textBox_BMR.Text = se1.ToString();//ให้ se1 แสดงผลที่ textBox_BMR
                }
                else if (radioButton2.Checked)//เงื่อนไข radioButton2.Checked
                {
                    se1 = (665 + (9.6 * w) + (1.8 * h) - (4.7 * age));//คำนวณ (665 + (9.6 * w ) + (1.8 * h) - (4.7 * age)) แล้วเก็บไว้ใน se1
                    textBox_BMR.Text = se1.ToString();//ให้ se1 แสดงผลที่ textBox_BMR
                }


                if (comboBox1.Text == "ไม่ออกกำลังกายหรือออกกำลังกายน้อยมาก")//เงื่อนไข comboBox1 ไม่ออกกำลังกายหรือออกกำลังกายน้อยมาก
                {
                    total = 1.2 * se1;//ให้ total เก็บค่า 1.2* se1 
                    textBox_TDEE.Text = total.ToString();//ให้ total แสดงที่ textBox_TDEE
                }
                else if (comboBox1.Text == "ออกกำลังกายน้อยเล่นกีฬา 1-3 วัน/สัปดาห์")//เงื่อนไข comboBox1 ออกกำลังกายน้อยเล่นกีฬา 1-3 วัน/สัปดาห์
                {
                    total = 1.375 * se1;//ให้ total เก็บค่า 1.375 * se1
                    textBox_TDEE.Text = total.ToString();//ให้ total แสดงที่ textBox_TDEE
                }
                else if (comboBox1.Text == "ออกกำลังกายปานกลางเล่นกีฬา 3-5 วัน/สัปดาห์")//เงื่อนไข comboBox1 ออกกำลังกายปานกลางเล่นกีฬา 3-5 วัน/สัปดาห์
                {
                    total = 1.55 * se1;//ให้ total เก็บค่า 1.55 * se1
                    textBox_TDEE.Text = total.ToString();//ให้ total แสดงที่ textBox_TDEE
                }
                else if (comboBox1.Text == "ออกกำลังกายหนักเล่นกีฬา 6-7 วัน/สัปดาห์")//เงื่อนไข comboBox1 ออกกำลังกายหนักเล่นกีฬา 6-7 วัน/สัปดาห์
                {
                    total = 1.725 * se1;//ให้ total เก็บค่า 1.725 * se1
                    textBox_TDEE.Text = total.ToString();//ให้ total แสดงที่ textBox_TDEE
                }
                else if (comboBox1.Text == "ออกกำลังกายหนักมากเป็นหนักกีฬา")//เงื่อนไข comboBox1 ออกกำลังกายหนักมากเป็นหนักกีฬา
                {
                    total = 1.9 * se1;//ให้ total เก็บค่า 1.9 * se1
                    textBox_TDEE.Text = total.ToString();//ให้ total แสดงที่ textBox_TDEE
                }
                else//ถ้านอกเงื่อนไข
                {
                    total = 0 * se1;//ให้ total เก็บค่า 0 * se1
                    textBox_TDEE.Text = total.ToString();//ให้ total แสดงที่ textBox_TDEE
                }
            }
            else//ถ้านอกเงื่อนไข
            {
                MessageBox.Show("กรุณกรอกข้อมูล");//แสดง กรุณากรอกข้อมูล บน  MessageBox
            }
        }

        private void button2_Click(object sender, EventArgs e)//ปุ่ม button2
        {
            radioButton1.Checked = false;//clear radioButton1
            radioButton2.Checked = false;//clear radioButton1
            textBox_age.Text = "";//clear textBox_age
            textBox_h.Text = "";//clear textBox_h
            textBox_w.Text = "";//clear textBox_w
            comboBox1.SelectedIndex = 0;//clear comboBox1
            textBox_BMR.Text = "";//clear textBox_BMR
            textBox_TDEE.Text = "";//clear textBox_TDEE

        }
        public static bool check_num(string data)//สร้าง method ชื่อ check_num 
        {
            bool c1 = false;//เป็นค่าเริ่มต้น 
            if (System.Text.RegularExpressions.Regex.IsMatch(data, "[^0-9]"))//เงื่อนไขให้เขียนตัวเลขได้เท่านั้น 
            {
                c1 = false;//ไม่ตรงตามเงื่อนไข จะเป็น false
            }
            else
            {
                c1 = true;//ตรงตามเงื่อนไข จะเป็น true
            }
            return c1;//ส่งค่า c1 กลับ 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();//คำสั่งปิดโปรแกรม
        }

        private void textBox_age_TextChanged(object sender, EventArgs e)//textBox_age
        {
            if (check_num(textBox_age.Text) == false)//รับข้อมูลจาก textBox_age เซ็คตามเงื่อนไข check_num เท่ากับ false
            {
                MessageBox.Show("กรุณากรอกตัวเลข");//จะแสดงข้อความ กรุณากรอกตัวเลข บน MessageBox
                textBox_age.Text = "";//เปลี่ยนค่า textBox_age ให้ว่างเปล่า
            }
        }

        private void textBox_w_TextChanged(object sender, EventArgs e)//textBox_w
        {
            if (check_num(textBox_w.Text) == false)//รับข้อมูลจาก textBox_w เซ็คตามเงื่อนไข check_num เท่ากับ false
            {
                MessageBox.Show("กรุณากรอกตัวเลข");//จะแสดงข้อความ กรุณากรอกตัวเลข บน MessageBox
                textBox_w.Text = "";//เปลี่ยนค่า textBox_w ให้ว่างเปล่า
            }
        }

        private void textBox_h_TextChanged(object sender, EventArgs e)//textBox_h
        {
            if (check_num(textBox_h.Text) == false)//รับข้อมูลจาก textBox_h เซ็คตามเงื่อนไข check_num เท่ากับ false
            {
                MessageBox.Show("กรุณากรอกตัวเลข");//จะแสดงข้อความ กรุณากรอกตัวเลข บน MessageBox
                textBox_h.Text = "";//เปลี่ยนค่า textBox_h ให้ว่างเปล่า
            }
        }

        private void textBox_BMR_TextChanged(object sender, EventArgs e)//textBox_BMR
        {
           
        }

        private void textBox_TDEE_TextChanged(object sender, EventArgs e)//textBox_TDEE
        {
            
        }
    }
}
