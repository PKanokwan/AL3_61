using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TestProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            bnStop_Srart.Enabled = false;
        }

        int c_get = 1;
        static int limit_Chroms = 10;
        Chromosome gen = new Chromosome();
        Random ran_r = new Random();
        string[] cho = new string[limit_Chroms];
        int[] ran_X = new int[limit_Chroms];
        int[] finess = new int[limit_Chroms];
        double[] pselect = new double[limit_Chroms];
        double[] expected = new double[limit_Chroms];
        double[] qi = new double[limit_Chroms];
        double[] r = new double[limit_Chroms];
        int[] r_qi = new int[limit_Chroms];
        //static int set_b = 5;
        bool check_start = true;

        /*********************** Crossover *******************************/
        Random ran = new Random();
       
        string[] mating_p = new string[limit_Chroms];
        string[] befor_cross = new string[2];
        string[] after_cross = new string[2];
        string[] b_mutation = new string[limit_Chroms];
        string[] a_mutation = new string[limit_Chroms];
        int[] r_qi2 = new int[limit_Chroms];
        int[] m_f = new int[limit_Chroms];
        string x1, x2;
        int f1, f2;
        bool check_cross = false;
        int pos;
        
        int[] new_Chrome = new int[limit_Chroms];

       
        List<int> list_newChro = new List<int>();
        List<int> Max_F = new List<int>();
        //List<int> X = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            /*********************** check Input Genaration *****************************/
            // Genaration
            if (numericUpDownGen.Value == 0)
            {
                numericUpDownGen.Focus();
                return;
            }

            list_newChro.Clear();
            Max_F.Clear();
 
            timer1.Start();
            c_get = 1;
            bnStop_Srart.Text = "Pause";
            bnStop_Srart.Enabled = true;
            progressBar.Maximum = Convert.ToInt32(numericUpDownGen.Value);
            txt_Max.Clear();
            check_start = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            list_newChro.Clear();
            Max_F.Clear();
           

            progressBar.Value = c_get;
             
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();

            // call gen
            Genaral();
                  
            txtLoop.Text = c_get.ToString();
             

            if (c_get == numericUpDownGen.Value)
            {
                timer1.Stop();
                bnStop_Srart.Enabled = false;
                //MessageBox.Show("ค่า x สูงสุดของฟังชันก์ y = x^2 เท่ากับ : " + txt_Max.Text, "จบการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            c_get++;            // เพิ่มรอบการทำงาน
            
            
        }
        private void Genaral()
        {

            if(check_start)
            {
                gen.Random_Bit();  // random ค่า 0-15 
                new_Chrome = gen.Get_X();
                check_start = false;
            }
           
            for (int i = 0; i < limit_Chroms;i++ )
            {
                list_newChro.Add(new_Chrome[i]);
            }

            cho = gen.Create_Chromosome(new_Chrome);                         // เก็บโคโมโซม  4 bit           
            finess = gen.Get_Finess(new_Chrome);                          //เก็บค่าความเหมาะสม
            for(int i=0;i<limit_Chroms;i++)
            {
                Max_F.Add(finess[i]);
            }
            gen.Finess_Total();                                              // ผลรวมความเหมาะสมทั้งหมด
            pselect = gen.Get_Pselect();                                     // ความน่าจะเป็น
            expected = gen.Get_Expected_Value();                             // จำนวนที่คาดหวัง
            qi = gen.Get_Qi();                                               // ความถี่สะสมความน่าจะเป็น
            r = gen.Get_r();                                                 // เก็บค่าจำนวนจริว r
            r_qi = gen.Get_rqi();                                            // ลำดับที่เลือก

  
            for (int i = 0; i < limit_Chroms; i++)
            {

                string txt_pselect = pselect[i].ToString("0.0000");
                string txt_expected = expected[i].ToString("0.0000");
                string txt_qi = qi[i].ToString("0.0000");
                string txt_r = r[i].ToString("0.0000");
                // เพื่มแถวใน DataGridview1
                dataGridView1.Rows.Add(i + 1, cho[i], new_Chrome[i], finess[i], txt_pselect, txt_expected,txt_qi,txt_r,(r_qi[i]+1)); 
            }


            /*********************** Crossover *******************************/
            
            Crossover cros = new Crossover(cho, r_qi);
          
            mating_p = cros.Get_MatingPool(); // เก็บ mating pool
            r_qi2 = cros.Get_rqi();           // ลำดับการคัดเลือก
          

            for(int i=0;i<limit_Chroms;i++)   // ตาราง 2
            {
                dataGridView2.Rows.Add((r_qi2[i]+1),mating_p[i],"-","-","-","-","-","-","-",i+1);
            }

            
            
            for (int i = 0; i < limit_Chroms;i+=2 )
            {
                
                // สุ่ม พ่อ - แม่
                int tmpran1 = Convert.ToInt32(dataGridView2.Rows[ran.Next(0, 9)].Cells[0].Value);
                int tmpran2 = Convert.ToInt32(dataGridView2.Rows[ran.Next(0, 9)].Cells[0].Value);

                dataGridView2.Rows[i].Cells[2].Value = tmpran1 + "," + tmpran2;

                befor_cross[0] = cho[tmpran1-1];
                befor_cross[1] = cho[tmpran2-1];

                string c = "" ;
                string n_pos = "" ;
                double r2 = ran.NextDouble();

                if (r2 <= Convert.ToDouble(txtCrossover.Text))
                {

                    check_cross = false;
                    pos = ran.Next(1, 5);
                    c = "<=" + txtCrossover.Text;                   
                    after_cross = cros.Get_Crossover(befor_cross, pos); // call crossover
                    x1 = Convert.ToString(Convert.ToInt32(after_cross[0].ToString(), 2), 10);
                    x2 = Convert.ToString(Convert.ToInt32(after_cross[1].ToString(), 2), 10);
                    cros.Set_F(Convert.ToInt32(x1),Convert.ToInt32(x2));
                    // ค่าความเหมาะสม
                    f1 = cros.Get_f1();  
                    f2 = cros.Get_f2();
                    // มิวเตชัน
                    b_mutation[i] = after_cross[0];
                    b_mutation[i + 1] = after_cross[1];
  
                }
                else {

                    check_cross = true;
                    c = ">" + txtCrossover.Text;
                    n_pos = "ไม่ครอสโอเวอร์";
                    x1 = Convert.ToString(Convert.ToInt32(befor_cross[0].ToString(), 2), 10);
                    x2 = Convert.ToString(Convert.ToInt32(befor_cross[1].ToString(), 2), 10);
                    cros.Set_F(Convert.ToInt32(x1), Convert.ToInt32(x2));
                    // ค่าความเหมาะสม
                    f1 = cros.Get_f1();
                    f2 = cros.Get_f2();
                    // มิวเตชัน
                    b_mutation[i] = befor_cross[0];
                    b_mutation[i + 1] = befor_cross[1];
                }

                string txt_r = r2.ToString("0.0000");
                dataGridView2.Rows[i].Cells[3].Value = txt_r;
                dataGridView2.Rows[i + 1].Cells[3].Value = c;

                if (check_cross) // ไม่ครอสโอเวอร์
                {
                    dataGridView2.Rows[i].Cells[5].Value = n_pos;
                    dataGridView2.Rows[i].Cells[6].Value = befor_cross[0];
                    dataGridView2.Rows[i + 1].Cells[6].Value = befor_cross[1];
                     
                }
                else {
                    // ก่อนครอสโอเวอร์
                    dataGridView2.Rows[i].Cells[4].Value = befor_cross[0];
                    dataGridView2.Rows[i + 1].Cells[4].Value = befor_cross[1];
                    dataGridView2.Rows[i].Cells[5].Value = pos;
                    //หลังครอสโอเวอร์
                    dataGridView2.Rows[i].Cells[6].Value = after_cross[0];
                    dataGridView2.Rows[i + 1].Cells[6].Value = after_cross[1];
                }

                // ค่า X, F
                dataGridView2.Rows[i].Cells[7].Value = x1;
                dataGridView2.Rows[i + 1].Cells[7].Value = x2;
                dataGridView2.Rows[i].Cells[8].Value = f1;
                dataGridView2.Rows[i + 1].Cells[8].Value = f2;
              
 
            }

            /******************************** ตาราง 3 *******************************/

            Mutation mut = new Mutation(b_mutation);
            string r_m;

           

            for (int i = 0; i < limit_Chroms;i++ )
            {
               
                r_m = mut.Get_r();                      // เก็บค่าซุ่ม r 5 ค่า
                string strmutation = mut.Get_Mutation(Convert.ToDouble(txtMutation.Text),i); 
                a_mutation[i] = strmutation;            // เก็บค่า Mutation
                int m_X = Convert.ToInt32(Convert.ToString(Convert.ToInt32(a_mutation[i], 2), 10));
                m_f[i] = mut.Get_F(a_mutation[i]);      // หาค่า F
    
                list_newChro.Add(m_X);
                Max_F.Add(m_f[i]);
                

                dataGridView3.Rows.Add(i + 1, b_mutation[i], r_m,a_mutation[i], m_X,m_f[i]);
            }
         
            list_newChro.Sort();        //  
            list_newChro.Reverse();     //
            Max_F.Sort();               //
            Max_F.Reverse();            //    
            
            /*for (int i = 0; i < limit_Chroms;i++ )
            {
                new_Chrome[i] = Get_NewChromosome(list_newChro, Max_F[i],i);
            }*/
            int index = 0, k = 0;
            while (index <  10)
            {
                if (index == 10)
                {
                    break;
                }
                int y = (15 * list_newChro[k]) - (list_newChro[k] * list_newChro[k]);
                if (y == Max_F[0])
                {
                    new_Chrome[index] = list_newChro[k];
                    list_newChro.RemoveAt(k);
                    Max_F.RemoveAt(0);
                    k = 0;
                    index++;
                }
                else
                {
                    k++;
                }
            }
             
            txt_Max.Text = new_Chrome[0].ToString();        // ค่าสูงสุด
        }

        
        private void bnCose_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void bnStop_Srart_Click(object sender, EventArgs e)
        {
            if(bnStop_Srart.Text.Equals("Pause"))
            {
                timer1.Stop();
                bnStop_Srart.Text = "Start";
            }else
            {
                timer1.Start();
                bnStop_Srart.Text = "Pause";
            }
        }
       
    }
}
