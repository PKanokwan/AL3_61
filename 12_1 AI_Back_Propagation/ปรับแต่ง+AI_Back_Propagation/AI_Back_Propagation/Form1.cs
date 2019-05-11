using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace AI_Back_Propagation
{
    public partial class Form1 : Form
    {
        int ti = -1;
        public Form1()
        {
            InitializeComponent();
        }

        public void display7seg(PictureBox p, NumericUpDown num)
        {
            if (num.Value == 1)
            {
                p.BackColor = Color.Red;
            }
            else {
                p.BackColor = Color.White;
            }
        }

       

       

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Input_Output_Pattern().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string outp=chkPattern();
            if (outp == "") MessageBox.Show("Pattren ไม่ถูกต้อง");
            else {

                calculate(outp);
                Char[] sc = outp.ToCharArray();

               String d = outp.ToString();
               if (d == "1")
               {
                   d = "Play";
               }
               else
               {
                   d = "Don't Play";
               }
               label1.Text = d.ToString();
            }
        }

     
        public string  chkPattern()
        {
            int WindyNum;
            int outNum = int.Parse(Outlook.SelectedIndex.ToString());
            Double TempertNum = int.Parse(Temperrature.Text.ToString());
            Double HumiNum = int.Parse(Humidity.Text.ToString());
            Double TemIn = TempertNum / 100;
            Double HumiIn = HumiNum / 100;

           

            if (Windy.Checked == false)
                WindyNum = 0;
            else
                WindyNum = 1;

            string Input = outNum.ToString() + TemIn.ToString() + HumiIn.ToString() + WindyNum.ToString();
            ArrayList In_pattern = new ArrayList() { "00.850.850", "00.800.901", "10.830.780", "20.700.960", "20.680.800", "20.650.701", "10.640.651", "00.720.950", "00.690.700", "20.750.800", "00.750.701", "10.720.901", "10.810.750", "20.710.801" };
       
            
            string[] Out_pattern = { "0", "0", "1", "1", "1","0","1","0","1","1","1","1","1","0" };
           
            int ou = In_pattern.IndexOf(Input);

            if (ou != -1) return Out_pattern[ou];
            else return "";
       
        }
        private void calculate(string ou)
        {
            
           
            int i = 0;
            Char[] sc = ou.ToCharArray();
            int WindyNum;
            int outNum = int.Parse(Outlook.SelectedIndex.ToString());
            Double TempertNum = int.Parse(Temperrature.Text.ToString());
            Double HumiNum = int.Parse(Humidity.Text.ToString());
            Double TemIn = TempertNum / 100;
            Double HumiIn = HumiNum / 100;
            

            if(Windy.Checked==false)
                WindyNum = 0;
            else
                WindyNum = 1;

            double x1 = Convert.ToDouble(outNum), x2 = Convert.ToDouble(TemIn), x3 = Convert.ToDouble(HumiIn), x4 = Convert.ToDouble(WindyNum);
            double Y1 = Convert.ToDouble(sc[0] + "");
            Random r = new Random();
            double w11 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w11 = -1 * w11;
            double w21 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w21 = -1 * w21;
            double w31 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w31 = -1 * w31;
            double w41 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w41 = -1 * w41;


            double w12 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w12 = -1 * w12;
            double w22 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w22 = -1 * w22;
            double w32 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w32 = -1 * w32;
            double w42 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w42 = -1 * w42;



            double W11 = randomWpk(), W21 = randomWpk();


            double teta1 = randomWpk(), teta2 = randomWpk(), teta3 = randomWpk();
               // teta4 = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1);
            double tetay1 = randomWpk();
            double d1, d2;
            double y1;
            double e1;
            double sumE;
            Random rr = new Random();
            int nloop=rr.Next(5000,6000);
            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();
            while (true)
            {
               
                i++;
                d1 = 1 / (1 + Math.Exp(-(x1 * w11 + x2 * w21 + x3 * w31 + x4 * w41 - 1 * teta1)));
                d2 = 1 / (1 + Math.Exp(-(x1 * w12 + x2 * w22 + x3 * w32 + x4 * w42 - 1 * teta2)));

                y1 = 1 / (1 + Math.Exp(-(d1 * W11 + d2 * W21 - 1 * tetay1)));

                e1 = Y1 - y1;


                sumE = Math.Pow(e1, 2);
                sumE = sumE / 2;
                chart1.Series[0].Points.AddXY(i, sumE);
         
                dataGridView1.Rows.Add(x1, x2, x3, x4, w11, w21, w31, w41, w21, w22, w32, w42, W11 ,W21, teta1, teta2, tetay1, d1, d2, y1, sumE);
                  

                if (sumE < double.Parse(Ep.Text) || (i == nloop))
                {
                    textBox1.Text = i+"";
                    break;
                }
                else { 
                    double ro = 0.1;
                    double deltay1 = y1 * (1 - y1) * e1;
                    double deltaW11 = ro * d1 * deltay1; W11 += deltaW11;
                    double deltaW21 = ro * d2 * deltay1; W21 += deltaW21;

                    double deltatetay1=ro*(-1)*deltay1;tetay1+=deltatetay1;


                
                }
                
                
            }

           
        }
        private double randomWpk()
        {
            Random r = new Random();
            if(r.Next(1,3)==1)
            return Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1);
            else return  -1*Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8) ;
            else if (e.KeyChar == 46 && Ep.Text.Contains(".")) e.Handled = true;
            else if (e.KeyChar < 46 || e.KeyChar > 57 || e.KeyChar == 47) e.Handled = true;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

     
   
  

    

       
    }
}
