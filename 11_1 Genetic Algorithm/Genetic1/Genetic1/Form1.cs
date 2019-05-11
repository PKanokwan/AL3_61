using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace Genetic1
{
    public partial class Form1 : Form
    {   
            ///////////////variable setting/////////////////////
            Random rn = new Random();
            Random radius = new Random();

            static int limit_chrome=10;
            int set_n = 5,bin_n=31; //จำนวนโครโมโซม
            double sum_f = 0, sumpsel = 0;
            int outloop = 0;
            String[] chromosom = new String[limit_chrome];
            int[] x = new int[limit_chrome];
            int[] f = new int[limit_chrome];
            double[] pselect13 = new double[limit_chrome];
            double[] ei = new double[limit_chrome];
            double[] sumpselect13 = new double[limit_chrome];
            int[] qi = new int[limit_chrome];
            int[] a = new int[limit_chrome];
            int[] cho=new int[limit_chrome];
            int b = 0;
            double cor_rate = 0.0;
            double mtr_rate = 0;
            int tog = 0;
            int max_a = 0;

           List<int> ar = new List<int>();
          // int loop = 0;
            ///////////////variable setting/////////////////////
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //gen();
            //MessageBox.Show(cor.Text);
            //cor_rate = Convert.ToDouble(cor.Text + "");
        }

        public void gen() {
 
            if (b == 0)
            {
                for (int i = 0; i < limit_chrome; i++)
                {
                    cho[i] = (rn.Next(0, bin_n));

                }
            }
           
            b++;
            // for (int b = 0; b < 20; b++)
            // {
            sum_f = 0;
            for (int i = 0; i < limit_chrome; i++)
            {

                String txt_chrom = Convert.ToString(Convert.ToInt32(cho[i].ToString(), 10), 2);

                txt_chrom = txt_chrom.PadLeft(set_n, '0');
                x[i] = cho[i]; chromosom[i] = txt_chrom;


                //======================================================หาค่าความเหมาะสม
                f[i] = cho[i] * cho[i];
                sum_f += f[i];




            }


            for (int i = 0; i < limit_chrome; i++)
            {

                //======================================================ค่าความน่าจะเป็น
                pselect13[i] = f[i] / sum_f;
                String showpselect13 = (f[i] / sum_f).ToString("0.000");


                //======================================================ค่าความคาดหวัง
                ei[i] = pselect13[i] * limit_chrome;
                String showE = (pselect13[i] * limit_chrome).ToString("0.000");

                //======================================================ความถี่สะสม
                sumpsel += pselect13[i];
                sumpselect13[i] = sumpsel;
                String showSumpselect13 = sumpsel.ToString("0.000");
               
                //ค่า r




                //========================================= เอาค่าลง grid

                grid1.Rows.Add(i + 1, chromosom[i], x[i], f[i], showpselect13, showE, showSumpselect13);
            }

            /////////////เอาค่า ที่สุ่มในวงล้อ กับ qi ใส่
            for (int i = 0; i < limit_chrome; i++)
            {
                for (int k = 0; k < limit_chrome - 1; k++)
                {
                    double ran_r = radius.NextDouble();
                   // MessageBox.Show(ran_r+"");
                    if (ran_r < sumpselect13[k])
                    {
                        qi[i] = k;
                        String showRanr = ran_r.ToString("0.000");
                        grid1.Rows[i].Cells[7].Value = showRanr;
                        grid1.Rows[i].Cells[8].Value = qi[i] + 1;
                        break;
                    }
                    else {
                        qi[i] = rn.Next(0,limit_chrome-1);
                        String showRanr = ran_r.ToString("0.000");
                        grid1.Rows[i].Cells[7].Value = showRanr;
                        grid1.Rows[i].Cells[8].Value = qi[i] + 1;
                        break;
                    }
                }
            }



            ///////////////////////////////////////////////////////////////////////////////////////////////////

            Random rn3 = new Random();
            String[] matting = new String[limit_chrome];
            String[] after_cross = new String[limit_chrome];
            String[] n_x = new String[limit_chrome];
            int[] n_n = new int[limit_chrome];
            int[] ran_parent = new int[limit_chrome];
            double[] ran_3 = new double[limit_chrome];
            int[] pos = new int[limit_chrome];


            /////////////////////ตาราง2
            for (int i = 0; i < limit_chrome; i++)
            {
                n_n[i] = qi[i];
                matting[i] = chromosom[n_n[i]];


                grid2.Rows.Add((n_n[i] + 1) + "", matting[i]);
            }


            for (int i = 0; i < limit_chrome; i = i + 2)
            {
                after_cross[i] = matting[i];
                if (i % 2 == 0)
                {
                    String condi_r = "";
                    int tmpran1 = Convert.ToInt32(grid2.Rows[rn3.Next(0, 9)].Cells[0].Value + "");
                    int tmpran2 = Convert.ToInt32(grid2.Rows[rn3.Next(0, 9)].Cells[0].Value + "");
                    ran_parent[i] = tmpran1;
                    ran_parent[i + 1] = tmpran2;

                    grid2.Rows[i].Cells[2].Value = tmpran1 + "," + tmpran2;

                    ran_3[i] = rn3.NextDouble();
                   
                    if (ran_3[i] <= cor_rate)
                    {
                        condi_r = " <= " + cor.Text;
                        pos[i] = rn3.Next(1, set_n);
                        after_cross[i] = matting[i].ToString().Substring(0, pos[i]) + matting[i + 1].ToString().Substring(pos[i], set_n - pos[i]);
                        after_cross[i + 1] = matting[i + 1].ToString().Substring(0, pos[i]) + matting[i].ToString().Substring(pos[i], set_n - pos[i]);
                    }
                    else
                    {
                        condi_r = " > " + cor.Text;
                        pos[i] = 0;
                        after_cross[i] = matting[i];
                        after_cross[i + 1] = matting[i + 1];
                    }
                    grid2.Rows[i].Cells[3].Value = ran_3[i].ToString("0.000");
                    grid2.Rows[i + 1].Cells[3].Value = condi_r;

                    if (pos[i] == 0)
                    {
                        grid2.Rows[i].Cells[5].Value = "ไม่ครอสโอเวอร์";
                    }
                    else
                    {
                        grid2.Rows[i].Cells[4].Value = matting[i];
                        grid2.Rows[i + 1].Cells[4].Value = matting[i + 1];
                        grid2.Rows[i].Cells[5].Value = pos[i] + "";
                        grid2.Rows[i].Cells[6].Value = after_cross[i] + "";
                        grid2.Rows[i + 1].Cells[6].Value = after_cross[i + 1] + "";

                    }

                }

                n_x[i] = Convert.ToString(Convert.ToInt32(after_cross[i], 2), 10);
                grid2.Rows[i].Cells[7].Value = n_x[i] + "";
                n_x[i + 1] = Convert.ToString(Convert.ToInt32(after_cross[i + 1], 2), 10);
                grid2.Rows[i + 1].Cells[7].Value = n_x[i + 1] + "";
            }

            for (int i = 0; i < limit_chrome; i++)
            {
                grid2.Rows[i].Cells[8].Value = (Convert.ToInt32(n_x[i]) * (Convert.ToInt32(n_x[i]))) + "";
                grid2.Rows[i].Cells[9].Value = i + 1;

            }

            double[] tmpr3 = new double[set_n];

            for (int i = 0; i < limit_chrome; i++)
            {

                String showTmpr = "";
                for (int j = 0; j < set_n; j++)
                {
                    tmpr3[j] = rn3.NextDouble() / 5;

                    if (j != 0)
                    {
                        showTmpr += " , ";
                    }
                    showTmpr += tmpr3[j].ToString("0.000");
                }
                grid3.Rows.Add(i + 1 + "", matting[i], showTmpr);
            }



            for (int i = 0; i < limit_chrome; i++)
            {
                String tt = grid3.Rows[i].Cells[2].Value.ToString();
                String[] tt2 = tt.Split(',');


                char[] arc = matting[i].ToCharArray();
                String tmpstr = "";
                for (int j = 0; j < set_n; j++)
                {
                    double tpr3 = Convert.ToDouble(tt2[j]);

                    if (tpr3 < mtr_rate)
                    {

                        if (arc[j] == '0') { arc[j] = '1'; } else if (arc[j] == '1') { arc[j] = '0'; }
                    }

                    tmpstr += arc[j];
                }
                matting[i] = tmpstr;
                grid3.Rows[i].Cells[3].Value = matting[i];
                grid3.Rows[i].Cells[4].Value = Convert.ToString(Convert.ToInt32(matting[i], 2), 10);
                int tmp_a = Convert.ToInt32(Convert.ToString(Convert.ToInt32(matting[i], 2), 10));
                grid3.Rows[i].Cells[5].Value = tmp_a*tmp_a;
                ar.Add(tmp_a);
                
                /*for (int w = limit_chrome-1; w >= 0; w--)
                {
                    if (x[w] > tmp_a)
                    {
                        a[i] = x[w];
                        break;
                    }
                    else {
                        a[i] = tmp_a;
                    }
                }*/
                
                max_a = (a[i] > max_a) ? a[i] : max_a;
                textBo.Text = max_a+"";
                tmpstr = "";
                
                //ar.Add(a[i]);
               // ar.Sort();
                //textBo.Text += "," + ar[i];
            }

            //}
            
           // textBo.Text = "," + ar[limit_chrome-1];
            ar.Sort();
            ar.Reverse();
            for (int i = 0; i < limit_chrome; i++)
            {
                a[i] = ar[i];
            }
        }




        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            cor_rate = Convert.ToDouble(cor.Text);
            mtr_rate = Convert.ToDouble(mtr.Text);
            outloop = 0;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ArrayList ar = new ArrayList();
            if (outloop == Convert.ToInt32(loopn.Text)) { timer1.Enabled = false; }
            textBox5.Text = outloop.ToString();
            int chk=0;
            int chking=0;
            for (int jj = 0; jj < limit_chrome; jj++) { 
            if(chk!=0){
                if (a[jj] != x[jj])
                {
                    chking = 0;
                    break;
                }
                else {
                    chking = 1;
                }
               
                }
            } 
            if (chking == 1) {
                timer1.Enabled = false;
            }
                grid1.Rows.Clear();
            grid2.Rows.Clear();
            grid3.Rows.Clear();
            sumpsel = 0;
            for (int i = 0; i < limit_chrome; i++) { 
            chromosom[i] = "";
          x[i] =0;
          f[i] = 0;
            pselect13[i] =0;
            }
                
            for (int i = 0; i < limit_chrome; i++)
            {
                cho[i] = a[i];
            }
            gen();
           
            chk++;
            outloop++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tog == 0)
            {
                button2.Text = "Resume";
                tog = 1;
                timer1.Stop();
            }
            else {
                button2.Text = "Pause";
                tog = 0;
                timer1.Start();
            }
        }
    }
}
