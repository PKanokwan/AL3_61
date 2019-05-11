using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Neural_Network
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8) ;
            else if (e.KeyChar == 46 && txtEa.Text.Contains(".")) e.Handled = true;
            else if (e.KeyChar < 46 || e.KeyChar > 57 || e.KeyChar == 47) e.Handled = true;
        }

        private void lnkIOPattern_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Input_Output_Pattern().Show();
        }


        private void btGen_Click(object sender, EventArgs e)
        {
            string output = chkPattern();
            if (output == "") 
                MessageBox.Show("รูปแบบ Keypad pattern ไม่ถูกต้อง!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                calculate(output);
                txtOpHex.Text = output;

                lblSW.Visible = false;
                BtnKey0.Enabled = false;
                BtnKey1.Enabled = false;
                BtnKey2.Enabled = false;
                BtnKey3.Enabled = false;
                BtnKey4.Enabled = false;
                BtnKey5.Enabled = false;
                BtnKey6.Enabled = false;
                BtnKey7.Enabled = false;
                BtnKey8.Enabled = false;
                BtnKey9.Enabled = false;
                BtnKey0.Enabled = false;
                BtnKeySharp.Enabled = false;
                BtnKeyStar.Enabled = false;


                if (txtOpHex.Text == "0xE6")
                {
                    BtnKey1.Enabled = true;
                }
                else if (txtOpHex.Text == "0xE5")
                {
                    BtnKey2.Enabled = true;
                }
                else if (txtOpHex.Text == "0xE3")
                {
                    BtnKey3.Enabled = true;
                }
                else if (txtOpHex.Text == "0xD6")
                {
                    BtnKey4.Enabled = true;
                }
                else if (txtOpHex.Text == "0xD5")
                {
                    BtnKey5.Enabled = true;
                }
                else if (txtOpHex.Text == "0xD3")
                {
                    BtnKey6.Enabled = true;
                }
                else if (txtOpHex.Text == "0xB6")
                {
                    BtnKey7.Enabled = true;
                }
                else if (txtOpHex.Text == "0xB5")
                {
                    BtnKey8.Enabled = true;
                }
                else if (txtOpHex.Text == "0xB3")
                {
                    BtnKey9.Enabled = true;
                }
                else if (txtOpHex.Text == "0x75")
                {
                    BtnKey0.Enabled = true;
                }
                else if (txtOpHex.Text == "0x73")
                {
                    BtnKeySharp.Enabled = true;
                }
                else if (txtOpHex.Text == "0x76")
                {
                    BtnKeyStar.Enabled = true;
                }
                else
                {
                    lblSW.Visible = true;
                }

            }
        }

        public string chkPattern()
        {
            string Input = R4.Text + R3.Text + R2.Text + R1.Text + C3.Text + C2.Text + C1.Text;
            String[] In_pattern = { "0000111", "1110110", "1110101", "1110011", "1101110", "1101101", "1101011", "1011110", "1011101", "1011011", "0111110", "0111101", "0111011" };
            string[] Out_pattern = { "0x07", "0xE6", "0xE5", "0xE3", "0xD6", "0xD5", "0xD3", "0xB6", "0xB5", "0xB3", "0x76", "0x75", "0x73", };
            int index = Array.IndexOf(In_pattern, Input);

            if (index != -1) return Out_pattern[index];
            else return "";
        }

        private void calculate(string ou)
        {
            int i = 0;
            double x1 = Convert.ToDouble(C3.Text), x2 = Convert.ToDouble(C2.Text), x3 = Convert.ToDouble(C1.Text), x4 = Convert.ToDouble(R4.Text),
                   x5 = Convert.ToDouble(R3.Text), x6 = Convert.ToDouble(R2.Text), x7 = Convert.ToDouble(R1.Text);
            double Y1 = Convert.ToDouble(Convert.ToInt32(ou[2] + "", 16) / 100), Y2 = Convert.ToDouble(ou[3]+"") / 100;
            Random r = new Random();
            double w11 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w11 = -1 * w11;
            double w21 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w21 = -1 * w21;
            double w31 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w31 = -1 * w31;
            double w41 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w41 = -1 * w41;
            double w51 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w51 = -1 * w51;
            double w61 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w61 = -1 * w61;
            double w71 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w71 = -1 * w71;

            double w12 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w12 = -1 * w12;
            double w22 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w22 = -1 * w22;
            double w32 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w32 = -1 * w32;
            double w42 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w42 = -1 * w42;
            double w52 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w52 = -1 * w52;
            double w62 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w62 = -1 * w62;
            double w72 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w72 = -1 * w72;

            double W11 = randomWpk(), W21 = randomWpk(), W31 = randomWpk(), W41 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1);
            double W12 = randomWpk(), W22 = randomWpk(), W32 = randomWpk(), W42 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1);
            double W13 = randomWpk(), W23 = randomWpk(), W33 = randomWpk(), W43 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1);
            double W14 = randomWpk(), W24 = randomWpk(), W34 = randomWpk(), W44 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1);
            double teta1 = randomWpk(), teta2 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1);
            double tetay1 = randomWpk(), tetay2 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1);
            
            double d1, d2;
            double y1, y2;
            double e1, e2;
            double sumE;
            
            Random rr = new Random();
            int nloop = rr.Next(5000, 6000);
            dataGridView1.Rows.Clear();
            while (true)
            {
                i++;
                d1 = 1 / (1 + Math.Exp(-(x1 * w11 + x2 * w21 + x3 * w31 + x4 * w41 + x5 * w51 + x6 * w61 + x7 * w71 - 1 * teta1)));
                d2 = 1 / (1 + Math.Exp(-(x1 * w12 + x2 * w22 + x3 * w32 + x4 * w42 + x5 * w52 + x6 * w62 + x7 * w72 - 1 * teta2)));
                y1 = 1 / (1 + Math.Exp(-(d1 * W11 + d2 * W21 - 1 * tetay1)));
                y2 = 1 / (1 + Math.Exp(-(d1 * W12 + d2 * W22 - 1 * tetay2)));

                e1 = Y1 - y1;
                e2 = Y2 - y2;

                sumE = Math.Pow(e1, 2) + Math.Pow(e2, 2);
                sumE = sumE / 2;
                dataGridView1.Rows.Add(x1, x2, x3, x4, x5, x6, x7, w11.ToString("0.##"), w21.ToString("0.##"), w31.ToString("0.##"), w41.ToString("0.##"), w51.ToString("0.##"), w61.ToString("0.##"), w71.ToString("0.##"), w12.ToString("0.##"), w22.ToString("0.##"), w32.ToString("0.##"), w42.ToString("0.##"), w52.ToString("0.##"), w62.ToString("0.##"), w72.ToString("0.##"), teta1.ToString("0.##"), teta2.ToString("0.##"), tetay1.ToString("0.##"), tetay2.ToString("0.##"), d1.ToString("0.##"), d2.ToString("0.##"), y1.ToString("0.##"), y2.ToString("0.##"), sumE.ToString("0.####"));

                if (sumE < double.Parse(txtEa.Text) || (i == nloop))
                {
                    textBox1.Text = i + "";
                    break;
                }
                else
                { //update  W ro=0.1
                    double ro = 0.1;
                    double deltay1 = y1 * (1 - y1) * e1;
                    double deltaW11 = ro * d1 * deltay1; W11 += deltaW11;
                    double deltaW21 = ro * d2 * deltay1; W21 += deltaW21;
                    double deltatetay1 = ro * (-1) * deltay1; tetay1 += deltatetay1;

                    double deltay2 = y2 * (1 - y2) * e2;
                    double deltaW12 = ro * d1 * deltay2; W12 += deltaW12;
                    double deltaW22 = ro * d2 * deltay2; W22 += deltaW22;
                    double deltatetay2 = ro * (-1) * deltay2; tetay2 += deltatetay2;

                    double deltad1 = d1 * (1 - d1) * (deltay1 * W11 + deltay2 * W12);
                    double deltaw11 = ro * x1 * deltad1; w11 += deltaw11;
                    double deltaw21 = ro * x2 * deltad1; w21 += deltaw21;
                    double deltaw31 = ro * x3 * deltad1; w31 += deltaw31;
                    double deltaw41 = ro * x4 * deltad1; w41 += deltaw41;
                    double deltaw51 = ro * x5 * deltad1; w51 += deltaw51;
                    double deltaw61 = ro * x6 * deltad1; w61 += deltaw61;
                    double deltaw71 = ro * x7 * deltad1; w71 += deltaw71;
                    double deltateta1 = ro * (-1) * deltad1; teta1 += deltateta1;

                    double deltad2 = d2 * (1 - d2) * (deltay1 * W21 + deltay2 * W22);
                    double deltaw12 = ro * x1 * deltad2; w12 += deltaw12;
                    double deltaw22 = ro * x2 * deltad2; w22 += deltaw22;
                    double deltaw32 = ro * x3 * deltad2; w32 += deltaw32;
                    double deltaw42 = ro * x4 * deltad2; w42 += deltaw42;
                    double deltaw52 = ro * x5 * deltad2; w52 += deltaw52;
                    double deltaw62 = ro * x6 * deltad2; w62 += deltaw62;
                    double deltaw72 = ro * x7 * deltad2; w72 += deltaw72;
                    double deltateta2 = ro * (-1) * deltad2; teta2 += deltateta2;
                }
            }
        }

        private double randomWpk()
        {
            Random r = new Random();
            if (r.Next(1, 3) == 1)
                return Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1);
            else return -1 * Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1);
        }

    }
}
