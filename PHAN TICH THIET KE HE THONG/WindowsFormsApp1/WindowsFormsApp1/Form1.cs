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

        int []dinhmuc = {100, 500,350};
        int moi = 220;
        int[,] dm = { { 450, 1020 }, { 550, 1100 }, { 780, 1550 } };
        double tinh;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if( textBox1.Text ==" ")
            {
                button1.Enabled = false;
            }    
            else
                button1.Enabled=true;
        }

        private void Tinh()
        {
            if(comboBox1.Text=="Sinh hoạt")
            {
                if(100<= dinhmuc[0])
                {
                    tinh = 100 * dm[0, 0];
                    textBox7.Text=tinh.ToString();
                }  
                else
                {
                    tinh = 100 * dm[0, 0] + 120 * dm[0,1];
                    textBox7.Text = tinh.ToString();
                }
                
            }
            if (comboBox1.Text == "Sản xuất")
            {
                if (100 <= dinhmuc[1])
                {
                    tinh = 100 * dm[1, 0] ;
                    textBox7.Text = tinh.ToString();
                }
                else
                {
                    tinh = 100 * dm[1, 0] + 120 * dm[1, 1];
                    textBox7.Text = tinh.ToString();
                }

            }
            if (comboBox1.Text == "Dịch vụ")
            {
                if (100 <= dinhmuc[2])
                {
                    tinh = 100 * dm[2, 0];
                    textBox7.Text = tinh.ToString();
                }
                else
                {
                    tinh = 100 * dm[2, 0] + 120 * dm[2, 1];
                    textBox7.Text = tinh.ToString();
                }

            }
        }
        private void ktra()
        {
            label9.Text ="Ông/Bà: " +  textBox1.Text;
            if(comboBox1.Text == "Sinh hoạt")
            {
                label10.Text = "Đã sử dụng số KW điện: 100";
                label11.Text = "Hình thức tiêu thu: Sinh hoạt";
                textBox2.Text = dinhmuc[0].ToString();
                textBox3.Text = dm[0,0].ToString();
                textBox4.Text = dm[0, 1].ToString();
            }
            if (comboBox1.Text == "Sản xuất")
            {
                label10.Text = "Đã sử dụng số KW điện: 100";
                label11.Text = "Hình thức tiêu thu: Sản xuất";
                textBox2.Text = dinhmuc[1].ToString();
                textBox3.Text = dm[1, 0].ToString();
                textBox4.Text = dm[1, 1].ToString();
            }
            if (comboBox1.Text == "Dịch vụ")
            {
                label10.Text = "Đã sử dụng số KW điện: 100";
                label11.Text = "Hình thức tiêu thu: Dịch vụ";
                textBox2.Text = dinhmuc[2].ToString();
                textBox3.Text = dm[2, 0].ToString();
                textBox4.Text = dm[2, 1].ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            Tinh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Sinh hoạt";
            label10.Text = "Đã sử dụng số KW điện: 100";
            label11.Text = "Hình thức tiêu thu: Sinh hoạt";
            textBox2.Text = "100";
            textBox3.Text = "450";
            textBox4.Text = "1020";
            textBox5.Text = "110";
            textBox6.Text = "220";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ktra();
        }

       
    }
}
