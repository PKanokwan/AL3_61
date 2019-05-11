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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculate();
        }
        private void calculate()
        {
            dataGridView1.Rows.Clear();
 
            
            ArrayList In_pattern = new ArrayList() { "00.850.850", "00.800.901", "10.830.780", "20.700.960", "20.680.800", "20.650.701", "10.640.651", "00.720.950", "00.690.700", "20.750.800", "00.750.701", "10.720.901", "10.810.750", "20.710.801" };
            string[] Out_pattern = { "0", "0", "1", "1", "1", "0", "1", "0", "1", "1", "1", "1", "1", "0" };
            
            
            double[] E = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double Ea = double.Parse(Ep.Text + "");
            int i = 0;


            
            Random r = new Random();

            double[] w11 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] w21 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] w31 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] w41 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


            double[] w12 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] w22 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] w32 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] w42 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            double[] W11 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] W21 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            double[] d1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] d2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            double[] teta1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] teta2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] teta3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] tetay1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0};

           
             for (int n = 0; n < 14; n++){

                  w11[n] = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w11[n] = -1 * w11[n];
                  w21[n] = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w21[n] = -1 * w21[n];
                  w31[n] = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w31[n] = -1 * w31[n];
                  w41[n] = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w41[n] = -1 * w41[n];


                  w12[n] = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w12[n] = -1 * w12[n];
                  w22[n] = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w22[n] = -1 * w22[n];
                  w32[n] = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w32[n] = -1 * w32[n];
                  w42[n] = Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1); if (r.Next(1, 3) == 1) w42[n] = -1 * w42[n];

                  W11[n] = randomWpk();
                 W21[n] = randomWpk();


                  teta1[n] = randomWpk();
                 teta2[n] = randomWpk();
                 teta3[n] = randomWpk();

                 tetay1[n] = randomWpk();
           
             }
            while (true)
            {
                i++;
               
                double y1;
                double e1;
             
                for (int n = 0; n < 14; n++)
                {
                    Char[] sc = Out_pattern[n].ToCharArray();
                    Char[] inp = (In_pattern[n] + "").ToCharArray();
             
                    double x1 = Convert.ToDouble(inp[0].ToString()), x2 = Convert.ToDouble((inp[1].ToString() + inp[2].ToString() + inp[3].ToString()+ inp[4].ToString())), x3 = Convert.ToDouble(inp[5].ToString() + inp[6].ToString() + inp[7].ToString()+ inp[8].ToString()), x4 = Convert.ToDouble(inp[9].ToString());
                    double Y1 = Convert.ToDouble(sc[0] + "");
                  
                 

                    d1[n]= 1 / (1 + Math.Exp(-(x1 * w11[n] + x2 * w21[n] + x3 * w31[n] + x4 * w41[n] - 1 * teta1[n])));
                d2[n] = 1 / (1 + Math.Exp(-(x1 * w12[n] + x2 * w22[n] + x3 * w32[n] + x4 * w42[n] - 1 * teta2[n])));

                y1 = 1 / (1 + Math.Exp(-(d1[n] * W11[n] + d2[n] * W21[n] - 1 * tetay1[n])));

                e1 = Y1 - y1;


                    E[n] = Math.Pow(e1, 2);
                    E[n] = E[n] / 2;

                    dataGridView1.Rows.Add(i, n + 1,x1, x2, x3, x4, w11[n], w21[n], w31[n], w41[n], w21[n], w22[n], w32[n], w42[n], W11[n] ,W21[n],teta1[n], teta2[n], tetay1[n], d1[n], d2[n], y1, E[n]);
                     
                    if (i % 2 == 1) dataGridView1.Rows[dataGridView1.RowCount - 1].DefaultCellStyle.BackColor = Color.LightBlue;
                     else dataGridView1.Rows[dataGridView1.RowCount - 1].DefaultCellStyle.BackColor = Color.LightCyan;
                 

                     double ro = 0.1;
                     double deltay1 = y1 * (1 - y1) * e1;
                     double deltaW11 = ro * d1[n] * deltay1; 
                      W11[n] += deltaW11;
                     double deltaW21 = ro * d2[n] * deltay1; 
                      W21[n] += deltaW21;

                     double deltatetay1 = ro * (-1) * deltay1; tetay1[n] += deltatetay1;

   

                }
                if (i == new Random().Next(6000, 7000) || (E[0] < Ea && E[1] < Ea && E[2] < Ea && E[3] < Ea && E[4] < Ea && E[5] < Ea && E[6] < Ea
                    && E[7] < Ea && E[8] < Ea && E[9] < Ea && E[10] < Ea && E[11] < Ea && E[12] < Ea && E[13] < Ea && E[14] < Ea && E[15] < Ea)) break;
            }
            textBox1.Text = i + "";
        }
        private double randomWpk()
        {
            Random r = new Random();
            if (r.Next(1, 3) == 1)
                return Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1);
            else return -1 * Math.Round((double)(r.Next(1, 3) - r.NextDouble()), 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }
        private void Ea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8) ;
            else if (e.KeyChar == 46 && Ep.Text.Contains(".")) e.Handled = true;
            else if (e.KeyChar < 46 || e.KeyChar > 57 || e.KeyChar == 47) e.Handled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Input_Output_Pattern().Show();
        }
    }
}
