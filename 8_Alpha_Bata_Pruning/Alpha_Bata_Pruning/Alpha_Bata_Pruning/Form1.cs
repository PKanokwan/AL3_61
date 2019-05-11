using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Alpha_Bata_Pruning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int count = 1;
        public int count_step = 1;
        public int buff;

        private void btnRandom_Click(object sender, EventArgs e) // random
        {
            DialogResult result;
            if (check())
                result = DialogResult.Yes;
            else
                result = MessageBox.Show("คุณต้องการสุ่มค่าใหม่ทั้งหมดหรือไม่", "สุ่มค่า" , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Random ObjRan = new Random();

                nudIn_1.Value = ObjRan.Next(-99, 99);
                nudIn_2.Value = ObjRan.Next(-99, 99);
                nudIn_3.Value = ObjRan.Next(-99, 99);

                nudIn_4.Value = ObjRan.Next(-99, 99);
                nudIn_5.Value = ObjRan.Next(-99, 99);
                nudIn_6.Value = ObjRan.Next(-99, 99);

                nudIn_7.Value = ObjRan.Next(-99, 99);
                nudIn_8.Value = ObjRan.Next(-99, 99);
                nudIn_9.Value = ObjRan.Next(-99, 99);
            }
        }
        public Boolean check()
        {
            if (
            nudIn_1.Value == 0 &&
            nudIn_2.Value == 0 &&
            nudIn_3.Value == 0 &&

            nudIn_4.Value == 0 &&
            nudIn_5.Value == 0 &&
            nudIn_6.Value == 0 &&

            nudIn_7.Value == 0 &&
            nudIn_8.Value == 0 &&
            nudIn_9.Value == 0)
                return true;
            else
                return false;
        }

        public void ABP_Search() // ค้นหาหลัก
        {
            if (count_step == 1)
                step_1();
            else if (count_step == 2)
                timer2.Enabled = true;
            else if (count_step == 3)
                timer2.Enabled = true;
            else if (count_step == 4)
                timer2.Enabled = true;
            else if (count_step == 5)
                timer2.Enabled = true;
            else if (count_step == 6)
                timer2.Enabled = true;
            else if (count_step == 7)
                timer2.Enabled = true;
            else if (count_step == 8)
                timer2.Enabled = true;
            else if (count_step == 9)
                timer2.Enabled = true;
            else if (count_step == 10)
                timer2.Enabled = true;
            else if (count_step == 11)
                timer2.Enabled = true;
            else if (count_step == 12)
                timer2.Enabled = true;
            else if (count_step == 13)
                timer2.Enabled = true;
            else if (count_step == 14)
                timer2.Enabled = true;
            else if (count_step == 15)
                timer2.Enabled = true;
            else if (count_step == 16)
                timer2.Enabled = true;
            else if (count_step == 17)
                timer2.Enabled = true;
            else if (count_step == 18)
                timer2.Enabled = true;
            else if (count_step == 19)
                timer2.Enabled = true;
            else if (count_step == 20)
                timer2.Enabled = true;
            else if (count_step == 21)
                timer2.Enabled = true;
            else if (count_step == 22)
                timer2.Enabled = true;
            else if (count_step == 23)
                timer2.Enabled = true;
            else if (count_step == 24)
                timer2.Enabled = true;
            else if (count_step == 25)
                timer2.Enabled = true;
            else if (count_step == 26)
                timer2.Enabled = true;
            else if (count_step == 27)
                timer2.Enabled = true;
            else if (count_step == 28)
                timer2.Enabled = true;
            else if (count_step == 29)
                timer2.Enabled = true;
            else if (count_step == 30)
                timer2.Enabled = true;
            else if (count_step == 31)
                timer2.Enabled = true;
            else if (count_step == 32)
                timer2.Enabled = true;
            else if (count_step == 33)
                timer2.Enabled = true;
            else if (count_step == 34)
                timer2.Enabled = true;
            else if (count_step == 35)
                timer2.Enabled = true;
            else if (count_step == 99)
                timer2.Enabled = true;
        }

        /// <1>
        /// ////////////////
        /// </summary>
        public void step_1() // โชว์ค่าจาก input
        {
            label1.Text = nudIn_1.Value.ToString();
            label2.Text = nudIn_2.Value.ToString();
            label3.Text = nudIn_3.Value.ToString();

            label4.Text = nudIn_4.Value.ToString();
            label5.Text = nudIn_5.Value.ToString();
            label6.Text = nudIn_6.Value.ToString();

            label7.Text = nudIn_7.Value.ToString();
            label8.Text = nudIn_8.Value.ToString();
            label9.Text = nudIn_9.Value.ToString();

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;

            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;            
        }
        public void step_2()
        {
            if (count == 1)
                ptbGreen_13.Visible = true;
            else if (count == 2)
            {
                ptbGreen_13.Visible = false;
                labRoot.Visible = true;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_3()
        {
            if (count == 3)
                ptbGreen_10.Visible = true;
            else if (count == 4)
            {
                ptbGreen_10.Visible = false;
                labMin_1.Visible = true;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_4()
        {
            if (count == 5)
            {
                ptbGreen_1.Visible = true;
                label1.BackColor = Color.Lime;
            }
            else if (count == 6)
            {
                ptbGreen_1.Visible = false;
                ptbRad_1.Visible = true;
                label1.BackColor = Color.Red;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_5()
        {
            if (count == 7)
            {
                ptbGreen_10.Visible = true;
            }
            else if (count == 8)
            {
                ptbGreen_10.Visible = false;
                label10.Visible = true;
                ptbRad_10.Visible = true;                
                label10.BackColor = Color.Red;
                label10.Text = label1.Text;                
                labMin_1.Text = "(-infinite , " + label1.Text + " ]";
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_6()
        {
            if (count == 9)
            {
                label2.BackColor = Color.Lime;
                ptbGreen_2.Visible = true;                
            }
            else if (count == 10)
            {
                ptbGreen_2.Visible = false;
                ptbRad_2.Visible = true;
                label2.BackColor = Color.Red;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_7()
        {
            if (count == 11)
            {
                ptbRad_10.Visible = false;
                ptbGreen_10.Visible = true;
            }
            else if (count == 12)
            {
                if (Convert.ToInt32(label2.Text) <= Convert.ToInt32(label10.Text))
                {                    
                    label10.Text = label2.Text;
                    labMin_1.Text = "(-infinite , " + label2.Text + " ]";
                }
                ptbGreen_10.Visible = false;
                label10.Visible = true;
                ptbRad_10.Visible = true;
                label10.BackColor = Color.Red;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_8()
        {
            if (count == 13)
            {
                label3.BackColor = Color.Lime;
                ptbGreen_3.Visible = true;
            }
            else if (count == 14)
            {
                ptbGreen_3.Visible = false;
                ptbRad_3.Visible = true;
                label3.BackColor = Color.Red;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_9()
        {
            if (count == 15)
            {
                ptbRad_10.Visible = false;
                ptbGreen_10.Visible = true;
            }
            else if (count == 16)
            {
                if (Convert.ToInt32(label3.Text) <= Convert.ToInt32(label10.Text))
                {
                    label10.Text = label3.Text;
                    labMin_1.Text = "[ " + label10.Text + " , " + label10.Text + " ]";
                }
                labMin_1.Text = "[ " + label10.Text + " , " + label10.Text + " ]";
                ptbGreen_10.Visible = false;
                label10.Visible = true;
                ptbRad_10.Visible = true;
                label10.BackColor = Color.Red;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_10()
        {
            if (count == 17)
            {
                ptbRad_13.Visible = false;
                ptbGreen_13.Visible = true;
            }
            else if (count == 18)
            {
                buff = Convert.ToInt32(label10.Text);
                label13.Text = buff.ToString();
                labRoot.Text = "[ " + label13.Text + " , +infinite )";
                ptbGreen_13.Visible = false;
                label13.Visible = true;
                ptbRad_13.Visible = true;
                label13.BackColor = Color.Red;
                timer2.Enabled = false;
                
            }
            count++;
        } // ขึ้นหา root

        /// <2>
        /// //////////////////////
        /// </summary>
        public void step_11()
        {
            if (count == 19)
            {
                ptbGreen_11.Visible = true;
            }
            else if (count == 20)
            {
                labMin_2.Visible = true;
                ptbGreen_11.Visible = false;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_12()
        {
            if (count == 21)
            {
                ptbGreen_4.Visible = true;
                label4.BackColor = Color.Lime;
            }
            else if (count == 22)
            {
                ptbGreen_4.Visible = false;
                ptbRad_4.Visible = true;
                label4.BackColor = Color.Red;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_13()
        {
            if (count == 23)
            {
                ptbGreen_11.Visible = true;
            }
            else if (count == 24)
            {
                ptbGreen_11.Visible = false;                
                label11.Visible = true;
                ptbRad_11.Visible = true;
                label11.BackColor = Color.Red; 
                label11.Text = label4.Text;
                labMin_2.Text = "(-infinite , "+ label11.Text + " ]" ;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_14() // ขึ้นหา root
        {
            if (count == 25)
            {
                ptbGreen_13.Visible = true;
                label13.BackColor = Color.Lime;
                label13.Visible = false;
            }
            else if (count == 26)
            {
                if (buff >= Convert.ToInt32(label11.Text))// cut off
                {
                    labRoot.Text = "[ " + label11.Text + " , " + label13.Text + " ]";
                    ptbGreen_13.Visible = false;
                    label13.Visible = true;
                    ptbRad_13.Visible = true;
                    label13.BackColor = Color.Red;
                    labA_B.Visible = true;
                    count_step = 23;
                    count = 42;
                }
                else
                {
                    //.Text = label11.Text;
                    labRoot.Text = "[ " + label13.Text + " , " + label11.Text + " ]";
                    ptbGreen_13.Visible = false;
                    label13.Visible = true;
                    ptbRad_13.Visible = true;
                    label13.BackColor = Color.Red;
                }
                timer2.Enabled = false;
            }
            count++;
        }
        
        public void step_15() // lab 11  กระพริบ ไม่เปลี่ยนค่า
        {
            if (count == 27)
            {
                ptbGreen_11.Visible = true;
                label11.BackColor = Color.Lime;
            }
            else if (count == 28)
            {
                ptbGreen_11.Visible = false;
                label11.Visible = true;
                ptbRad_11.Visible = true;
                label11.BackColor = Color.Red;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_16() // lab 5  กระพริบ
        {
            if (count == 29)
            {
                ptbGreen_5.Visible = true;
                label5.BackColor = Color.Lime;
            }
            else if (count == 30)
            {
                ptbGreen_5.Visible = false;
                label5.Visible = true;
                ptbRad_5.Visible = true;
                label5.BackColor = Color.Red;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_17() // lab 11  กระพริบ เปลี่ยนค่า
        {
            if (count == 31)
            {
                ptbRad_11.Visible = false;
                ptbGreen_11.Visible = true;
            }
            else if (count == 32)
            {
                if (Convert.ToInt32(label5.Text) <= Convert.ToInt32(label11.Text))
                {
                    label11.Text = label5.Text;
                }

                labMin_2.Text = "(-infinite , " + label11.Text + " ]";
                ptbGreen_11.Visible = false;
                label11.Visible = true;
                ptbRad_11.Visible = true;
                label11.BackColor = Color.Red;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_18() // ขึ้นหา root
        {
            if (count == 33)
            {
                ptbGreen_13.Visible = true;
                label13.BackColor = Color.Lime;
                label13.Visible = false;
            }
            else if (count == 34)
            {                
                if (buff >= Convert.ToInt32(label11.Text))// cut off
                {
                    buff = Convert.ToInt32(label11.Text);
                    labRoot.Text = "[ " + buff.ToString() + " , " + label13.Text + " ]";
                    ptbGreen_13.Visible = false;
                    label13.Visible = true;
                    ptbRad_13.Visible = true;
                    label13.BackColor = Color.Red;
                    labA_B.Visible = true;
                    count_step = 23;
                    count = 42;
                }
                else
                {
                    //label13.Text = label11.Text;
                    labRoot.Text = "[ " + label13.Text + " , " + label11.Text + " ]";
                    ptbGreen_13.Visible = false;
                    label13.Visible = true;
                    ptbRad_13.Visible = true;
                    label13.BackColor = Color.Red;
                }
                timer2.Enabled = false;
            }
            count++;
        }

        public void step_19() // lab 11  กระพริบ ไม่เปลี่ยนค่า
        {
            if (count == 35)
            {
                ptbGreen_11.Visible = true;
                label11.BackColor = Color.Lime;
            }
            else if (count == 36)
            {
                ptbGreen_11.Visible = false;
                label11.Visible = true;
                ptbRad_11.Visible = true;
                label11.BackColor = Color.Red;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_20() // lab 6  กระพริบ
        {
            if (count == 37)
            {
                ptbGreen_6.Visible = true;
                label6.BackColor = Color.Lime;
            }
            else if (count == 38)
            {
                ptbGreen_6.Visible = false;
                label6.Visible = true;
                ptbRad_6.Visible = true;
                label6.BackColor = Color.Red;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_21() // lab 11  กระพริบ เปลี่ยนค่า
        {
            if (count == 39)
            {
                ptbRad_11.Visible = false;
                ptbGreen_11.Visible = true;
            }
            else if (count == 40)
            {
                if (Convert.ToInt32(label6.Text) <= Convert.ToInt32(label11.Text))
                {
                    label11.Text = label6.Text;
                }
                labMin_2.Text = "[ " + label11.Text + " , " + label11.Text + " ]";
                ptbGreen_11.Visible = false;
                label11.Visible = true;
                ptbRad_11.Visible = true;
                label11.BackColor = Color.Red;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_22() // ขึ้นหา root
        {
            if (count == 41)
            {
                ptbGreen_13.Visible = true;
                label13.BackColor = Color.Lime;
                label13.Visible = false;
            }
            else if (count == 42)
            {
                if (buff >= Convert.ToInt32(label11.Text))// cut off
                {
                    buff = Convert.ToInt32(label11.Text);
                    labRoot.Text = "[ " + buff.ToString() + " , " + label13.Text + " ]";
                    ptbGreen_13.Visible = false;
                    label13.Visible = true;
                    ptbRad_13.Visible = true;
                    label13.BackColor = Color.Red;
                    //labA_B.Visible = true;
                    count_step = 23;
                    count = 42;
                }
                else
                {                    
                    labRoot.Text = "[ " + label11.Text + " , " + label13.Text + " ]";
                    label13.Text = label11.Text;
                    ptbGreen_13.Visible = false;
                    label13.Visible = true;
                    ptbRad_13.Visible = true;
                    label13.BackColor = Color.Red;
                }
                timer2.Enabled = false;
            }
            count++;
        }

        /// <3>
        /// ////////////////////////////
        /// </summary>
        public void step_23()
        {
            if (count == 43)
            {
                ptbGreen_12.Visible = true;
            }
            else if (count == 44)
            {
                labMin_3.Visible = true;
                ptbGreen_12.Visible = false;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_24()
        {
            if (count == 45)
            {
                ptbGreen_7.Visible = true;
                label7.BackColor = Color.Lime;
            }
            else if (count == 46)
            {
                ptbGreen_7.Visible = false;
                ptbRad_7.Visible = true;
                label7.BackColor = Color.Red;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_25()
        {
            if (count == 47)
            {
                ptbRad_12.Visible = false;
                ptbGreen_12.Visible = true;
                label12.BackColor = Color.Lime;
            }
            else if (count == 48)
            {
                ptbGreen_12.Visible = false;
                label12.Visible = true;
                ptbRad_12.Visible = true;
                label12.BackColor = Color.Red;
                label12.Text = label7.Text;
                labMin_3.Text = "(-infinite , " + label12.Text + " ]";
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_26() // ขึ้นหา root
        {
            buff = Convert.ToInt32(label13.Text);
            if (count == 49)
            {
                ptbGreen_13.Visible = true;
                label13.BackColor = Color.Lime;
                label13.Visible = false;
            }
            else if (count == 50)
            {
                if (buff >= Convert.ToInt32(label12.Text))// cut off
                {
                    labRoot.Text = "[ " + label12.Text + " , " + label13.Text + " ]";
                    ptbGreen_13.Visible = false;
                    label13.Visible = true;
                    ptbRad_13.Visible = true;
                    label13.BackColor = Color.Red;
                    labA_B2.Visible = true;
                    count_step = 99;
                    count = 66;
                }
                else
                {
                    labRoot.Text = "[ " + label13.Text + " , " + label12.Text + " ]";
                    ptbGreen_13.Visible = false;
                    label13.Visible = true;
                    ptbRad_13.Visible = true;
                    label13.BackColor = Color.Red;
                }
                timer2.Enabled = false;
            }
            count++;
        }

        public void step_27() // lab 12  กระพริบ ไม่เปลี่ยนค่า
        {
            if (count == 51)
            {
                ptbGreen_12.Visible = true;
                label12.BackColor = Color.Lime;
            }
            else if (count == 52)
            {
                ptbGreen_12.Visible = false;
                label12.Visible = true;
                ptbRad_12.Visible = true;
                label12.BackColor = Color.Red;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_28() // lab 8  กระพริบ
        {
            if (count == 53)
            {
                ptbGreen_8.Visible = true;
                label8.BackColor = Color.Lime;
            }
            else if (count == 54)
            {
                ptbGreen_8.Visible = false;
                label8.Visible = true;
                ptbRad_8.Visible = true;
                label8.BackColor = Color.Red;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_29() // lab 12  กระพริบ เปลี่ยนค่า
        {
            if (count == 55)
            {
                ptbRad_12.Visible = false;
                ptbGreen_12.Visible = true;
            }
            else if (count == 56)
            {
                if (Convert.ToInt32(label8.Text) <= Convert.ToInt32(label12.Text))
                {
                    label12.Text = label8.Text;
                    labMin_3.Text = "(-infinite , " + label12.Text + " ]";
                }
                ptbGreen_12.Visible = false;
                label12.Visible = true;
                ptbRad_12.Visible = true;
                label12.BackColor = Color.Red;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_30() // ขึ้นหา root
        {
            if (count == 57)
            {
                ptbGreen_13.Visible = true;
                label13.BackColor = Color.Lime;
                label13.Visible = false;
            }
            else if (count == 58)
            {
                if (buff >= Convert.ToInt32(label12.Text))// cut off
                {
                    //buff = Convert.ToInt32(label11.Text);
                    labRoot.Text = "[ " + label12.Text + " , " + label13.Text + " ]";
                    ptbGreen_13.Visible = false;
                    label13.Visible = true;
                    ptbRad_13.Visible = true;
                    label13.BackColor = Color.Red;
                    labA_B2.Visible = true;
                    count_step = 99;
                    count = 66;
                }
                else
                {
                    //label13.Text = label11.Text;
                    labRoot.Text = "[ " + label13.Text + " , " + label12.Text + " ]";
                    ptbGreen_13.Visible = false;
                    label13.Visible = true;
                    ptbRad_13.Visible = true;
                    label13.BackColor = Color.Red;
                }
                timer2.Enabled = false;
            }
            count++;
        }

        public void step_31() // lab 12  กระพริบ ไม่เปลี่ยนค่า
        {
            if (count == 59)
            {
                ptbGreen_12.Visible = true;
                label12.BackColor = Color.Lime;
            }
            else if (count == 60)
            {
                ptbGreen_12.Visible = false;
                label12.Visible = true;
                ptbRad_12.Visible = true;
                label12.BackColor = Color.Red;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_32() // lab 9  กระพริบ
        {
            if (count == 61)
            {
                ptbGreen_9.Visible = true;
                label9.BackColor = Color.Lime;
            }
            else if (count == 62)
            {
                ptbGreen_9.Visible = false;
                label9.Visible = true;
                ptbRad_9.Visible = true;
                label9.BackColor = Color.Red;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_33() // lab 12  กระพริบ เปลี่ยนค่า
        {
            if (count == 63)
            {
                ptbRad_12.Visible = false;
                ptbGreen_12.Visible = true;
            }
            else if (count == 64)
            {
                if (Convert.ToInt32(label9.Text) <= Convert.ToInt32(label12.Text))
                {
                    label12.Text = label9.Text;
                    labMin_3.Text = "[ " + label12.Text + " , " + label12.Text + " ]";
                }
                labMin_3.Text = "[ " + label12.Text + " , " + label12.Text + " ]";
                ptbGreen_12.Visible = false;
                label12.Visible = true;
                ptbRad_12.Visible = true;
                label12.BackColor = Color.Red;
                timer2.Enabled = false;
            }
            count++;
        }
        public void step_34() // ขึ้นหา root
        {
            if (count == 65)
            {
                ptbGreen_13.Visible = true;
                label13.BackColor = Color.Lime;
                label13.Visible = false;
            }
            else if (count == 66)
            {
                if (buff >= Convert.ToInt32(label12.Text))// cut off
                {
                    //buff = Convert.ToInt32(label12.Text);
                    labRoot.Text = "[ " + label12.Text + " , " + label13.Text + " ]";
                    ptbGreen_13.Visible = false;
                    label13.Visible = true;
                    ptbRad_13.Visible = true;
                    label13.BackColor = Color.Red;
                    labA_B2.Visible = true;

                }
                else
                {
                    labRoot.Text = "[ " + label13.Text + " , " + label12.Text + " ]";
                    ptbGreen_13.Visible = false;
                    label13.Visible = true;
                    ptbRad_13.Visible = true;
                    label13.BackColor = Color.Red;
                }
                count_step = 99;
                count = 66;
                timer2.Enabled = false;
            }
            count++;
        }

        public void step_99() // end 13 กระพริบ
        {
            if (count == 67)
            {
                ptbGreen_13.Visible = false;
                ptbRad_13.Visible = true;
                label13.Visible = false;
            }
            else if (count == 68)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;

                labFin.Text = check_Num();
                labRoot.Text = "[ " + label13.Text + " , " + label13.Text + " ]";
                ptbRad_13.Visible = false;
                labFin.Visible = true;
                ptbGreen_13.Visible = true;
                labFin.BackColor = Color.Lime;
                btnStart.Enabled = false;
               // btnClear.Text = "Clear";
                MessageBox.Show("การค้นหาเสร็จสิ้น", "การค้นหา",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            count++;
        }
        public string check_Num()
        {
            string strOut = label10.Text;
            if (Convert.ToInt32(strOut) < Convert.ToInt32(label11.Text))
                strOut = label11.Text;
            if (Convert.ToInt32(strOut) < Convert.ToInt32(label12.Text))
                strOut = label12.Text;
            return strOut;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (count_step == 3)
                step_2();
            else if (count_step == 4)
                step_3();
            else if (count_step == 5)
                step_4();
            else if (count_step == 6)
                step_5();
            else if (count_step == 7)
                step_6();
            else if (count_step == 8)
                step_7();
            else if (count_step == 9)
                step_8();
            else if (count_step == 10)
                step_9();
            else if (count_step == 11)
                step_10();
            else if (count_step == 12)
                step_11();
            else if (count_step == 13)
                step_12();
            else if (count_step == 14)
                step_13();
            else if (count_step == 15)
                step_14();
            else if (count_step == 16)
                step_15();
            else if (count_step == 17)
                step_16();
            else if (count_step == 18)
                step_17();
            else if (count_step == 19)
                step_18();
            else if (count_step == 20)
                step_19();
            else if (count_step == 21)
                step_20();
            else if (count_step == 22)
                step_21();
            else if (count_step == 23)
                step_22();
            else if (count_step == 24)
                step_23();
            else if (count_step == 25)
                step_24();
            else if (count_step == 26)
                step_25();
            else if (count_step == 27)
                step_26();
            else if (count_step == 28)
                step_27();
            else if (count_step == 29)
                step_28();
            else if (count_step == 30)
                step_29();
            else if (count_step == 31)
                step_30();
            else if (count_step == 32)
                step_31();
            else if (count_step == 33)
                step_32();
            else if (count_step == 34)
                step_33();
            else if (count_step == 35)
                step_34();
            else if (count_step == 100)
                step_99();

            if (chbAuto.Checked == true && count % 2 != 0)
                btnStart.Enabled = true;
            else if (chbAuto.Checked == true && count % 2 == 0)
                btnStart.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e) // load เริ่มต้น
        {
           
        }
       
        private void btnStart_Click(object sender, EventArgs e) // ปุ่มเริ่มต้น
        {
            btnClear.Text = "Stop";
            if (chbAuto.Checked == true)
            {
                timer1_Tick(sender, e);
                btnStart.Text = "Next";
                visi();
            }
            else
            {
                if (btnStart.Text == "Pause")
                {
                    timer1.Enabled = false;
                    btnStart.Text = "Play";
                }
                else
                {
                    timer1.Enabled = true;
                    visi();
                    btnStart.Text = "Pause";
                }
            }
        }

        public void visi()
        {
            chbAuto.Enabled = false;
            btnRandom.Enabled = false;

            chbAuto.Enabled = false;
            btnRandom.Enabled = false;

            nudIn_1.Enabled = false;
            nudIn_2.Enabled = false;
            nudIn_3.Enabled = false;

            nudIn_4.Enabled = false;
            nudIn_5.Enabled = false;
            nudIn_6.Enabled = false;

            nudIn_7.Enabled = false;
            nudIn_8.Enabled = false;
            nudIn_9.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e) // นาฬิกาทำงาน
        {            
            ABP_Search();
            count_step++;
        }

        private void btnClear_Click(object sender, EventArgs e) // clear
        {
            if (btnClear.Text == "Clear") //clear
            {
                DialogResult dig = MessageBox.Show("คุณต้องล้างค่าทั้งหมดหรือไม่", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dig == DialogResult.Yes)
                {
                    F_clear();
                    F_stop();
                }
            }
            else // stop
            {
                btnClear.Text = "Clear";
                F_stop();
            }
        }
        public void F_clear()
        {

            timer1.Enabled = false;
            timer2.Enabled = false;
            nudIn_1.Value = 0;
            nudIn_2.Value = 0;
            nudIn_3.Value = 0;

            nudIn_4.Value = 0;
            nudIn_5.Value = 0;
            nudIn_6.Value = 0;

            nudIn_7.Value = 0;
            nudIn_8.Value = 0;
            nudIn_9.Value = 0;
        }
        public void F_stop()
        {

            timer1.Enabled = false;
            timer2.Enabled = false;
            ptbGreen_1.Visible = false;
            ptbGreen_2.Visible = false;
            ptbGreen_3.Visible = false;

            ptbGreen_4.Visible = false;
            ptbGreen_5.Visible = false;
            ptbGreen_6.Visible = false;

            ptbGreen_7.Visible = false;
            ptbGreen_8.Visible = false;
            ptbGreen_9.Visible = false;

            ptbGreen_10.Visible = false;
            ptbGreen_11.Visible = false;
            ptbGreen_12.Visible = false;

            ptbGreen_13.Visible = false;

            ptbRad_1.Visible = false;
            ptbRad_2.Visible = false;
            ptbRad_3.Visible = false;

            ptbRad_4.Visible = false;
            ptbRad_5.Visible = false;
            ptbRad_6.Visible = false;

            ptbRad_7.Visible = false;
            ptbRad_8.Visible = false;
            ptbRad_9.Visible = false;

            ptbRad_10.Visible = false;
            ptbRad_11.Visible = false;
            ptbRad_12.Visible = false;

            ptbRad_13.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;

            label13.Visible = false;
            labFin.Visible = false;

            labMin_1.Visible = false;
            labMin_2.Visible = false;
            labMin_3.Visible = false;

            labA_B.Visible = false;
            labA_B2.Visible = false;
            labRoot.Visible = false;

            chbAuto.Enabled = true;
            btnRandom.Enabled = true;
            btnStart.Enabled = true;

            nudIn_1.Enabled = true;
            nudIn_2.Enabled = true;
            nudIn_3.Enabled = true;
            nudIn_4.Enabled = true;
            nudIn_5.Enabled = true;
            nudIn_6.Enabled = true;
            nudIn_7.Enabled = true;
            nudIn_8.Enabled = true;
            nudIn_9.Enabled = true;

            count = 1;
            count_step = 1;

            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;

            btnStart.Text = "Start";

            labRoot.Text = "(-infinite , +infinite)";
            labMin_1.Text = "(-infinite , +infinite)";
            labMin_2.Text = "(-infinite , +infinite)";
            labMin_3.Text = "(-infinite , +infinite)";
        }
                

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(about(), "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public string about()
        {
            string str = "โปรแกรมแสดงขั้นตอนการค้นหาเส้นทางโดยใช้วิธีการค้นหาแบบ Alpha-Beta Pruning\n Version 1.0.1\n\nDeveloped by EvilEdition Studio";
            return str;
        }

        private void alphaBataPruningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(what(), "Alpha-Beta Pruning",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public string what()
        {
            string str = "         Alpha-Beta นั้นเป็นอัลกอที่เหมาะกับ AI จำพวกหมากกระดาน เป็นอัลกอคิดคิดต่อเนื่องมาจาก MiniMax โดยมีแนวความคิดในการแตก Tree ทางเดินที่เป็นไปได้ทั้งหมดออกมา แล้วหาเส้นทางที่ดีที่สุดโดยมองล่วงหน้าไป (จะกี่ชั้นก็แล้วแต่) แบ่งเป็นตาเดินของเราและตาของฝ่ายตรงข้ามสลับๆไป จนถึงจำนวนชั้นล่วงหน้าที่กำหนด แล้วคิดคะแนนในความลึกชั้นสุดท้ายแล้ว return คะแนน กลับออกมาแล้วเอาคะแนนมาคิดหาทางเดินที่ควรจะเดินโดยAssumeว่า ในตาของฝ่ายตรงข้ามๆจะเลือกตาเดินที่แย่ที่สุดของเรา(ก็คือตาที่ดีที่สุดของฝ่ายตรงข้าม)และในความลึกที่เป็นตาของเรา เราก็จะเลือกตาที่ดีที่สุดของเราจนฟังก์ชั้น return กลับมาหมดเราก็จะได้ตาที่ดีที่สุดออกมา (ซึ่งขึ้นอยู่กับการตีคะแนนในชั้นสุดท้าย และ จำนวนชั้นที่มองล่วงหน้าเข้าไป)อันนี้คือคราวๆของ Minimax โดยที่ Alpha-Beta จะเป็นส่วนเสริมของMinimaxโดย Alpha-Beta จะตัดตาเดินที่ไม่จำเป็นต้องคิดออกไปตาเดินที่ว่าคือตาเดินในลักษณะที่ว่าเป็นตาเดินที่ยังไงซะ ในความลึกในระดับชั้นบนถัดไป ยังไงก็ไม่เลือกไปคิดอยู่แล้วคือมันเป็นตาที่ไม่ดีในความลึกระดับชั้นบนถัดไป";
            return str;
        }

        private void คำแนะนำในการใชToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(what_(), "คำแนะนำในการใช้", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public string what_()
        {
            string str = "         คลิกเครื่องหมายถูกที่ช่อง \"Step by Step\" เพื่อเลือกการทำงานแบบขั้นต่อขั้น หรือคลิกเครื่องหมายถูกออกเพื่อเลือกการทำงานแบบอัตโนมัติ";
            str += "\n         หลังจาที่กดปุ่ม \"Start\" สามารถกดปุ่มนั้นอีกครั้งเพื่อหยุดการทำงานชั่วคราวในโหมดอัตโนมัติ หรือทำงานในขั้นต่อไปในโหมด Step by Step";
            str += "\n         ในระหว่างระบบกำลังงานสามารถกดปุ่ม \"Stop\" เพื่อหยุดการทำงานทั้งหมด ซึ่งสามารถกดปุ่ม \"Start\" เพื่อเริ่มการทำงานเดิมได้อีกครั้ง และถ้าหากระบบไม่มีการทำงาน สามารถกดปุ่ม \"Clear\" เพื่อล้างค่าทั้งหมดให้ไปอยู่ในสถานะเริ่มตั้น";
            str += "\n         กดปุ่ม \"Random\" เพื่อสุ่มค่าตัวเลขที่ป้อนเข้าไปในการค้นหา ถ้าหากก่อนหน้านั้นมีการใส่หรือสุ่มตัวเลขไว้แล้ว(ตัวเลขที่ Input ไม่เท่ากับ 0)ระบบจะถามเพื่อยืนยันการสุ่มตัวเลข";
            return str;
        }
    }
}
