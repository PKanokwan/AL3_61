using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProgram
{
    class Chromosome
    {
        Random ran = new Random();
        static int limit_Chroms = 10;
        int set_b = 4, bit_n = 15;
        int[] chomse = new int[limit_Chroms];
        string[] cho = new string[limit_Chroms];
        int[] finess = new int[limit_Chroms];
        double  finess_total = 0;
        double[] pselect = new double[limit_Chroms];
        double[] expected = new double[limit_Chroms];
        double[] qi = new double[limit_Chroms];
        double qi_total = 0;
        double[] r = new double[limit_Chroms];
        int[] r_qi = new int[limit_Chroms+1];
        



        public void Random_Bit()
        {

             for (int i = 0; i < limit_Chroms; i++)
             {
                   chomse[i] = ran.Next(0, bit_n);
                  
             }
                       
        }
        
        public double[] Get_r() // สุ่มค่า r (0.0 - 1.0) และเลือกลำดับโคโมโซม
        {
            for (int i = 0; i < limit_Chroms; i++)
            {
                r[i] = ran.NextDouble();
                if (r[i] < qi[i])
                {
                    r_qi[i] = i;
                }
                else
                {
                    r_qi[i] = ran.Next(0, limit_Chroms - 1);
                }
            }
            return r;
        }
        public int[] Get_rqi() // คืนค่าลำดับที่เลือก
        {
            return r_qi;
        }
        public int[] Get_X()
        {
            return chomse;
        }
        public int[] Get_Finess(int[] c)
        {
            for (int i = 0; i < limit_Chroms; i++)
            {
                finess[i] = (15*c[i]) -(c[i]*c[i]); // ค่าความดหมาะสม y=15x-x^2
            }
            return finess;
        }
        
        public void Finess_Total() // ค่าความเหมาะสมทั้ใหมด
        {
            for (int i = 0; i < limit_Chroms;i++ )
            {
                finess_total += finess[i];  
            }         
        }
        public double[] Get_Pselect()
        {
            for (int i = 0; i < limit_Chroms; i++)
            {
                pselect[i] = finess[i] / finess_total; // เก็บความน่าจะเป็น
                expected[i] = pselect[i] * limit_Chroms; // จำนวนที่คาดหวัง
            }
            return pselect;
        }
        public double[] Get_Qi() // ความถี่สะสมความน่าจะเป็น
        {
            qi_total = 0;
            for(int i=0;i<limit_Chroms;i++){

                 qi_total += pselect[i];
                 qi[i] = qi_total;   
            
            }
            return qi;
        }
        public double[] Get_Expected_Value() // จำนวนที่คาดหวัง
        {       
            return expected;
        }
        public string[] Create_Chromosome(int[] c) // สร้างโคโมโซม
        {
            for (int i = 0; i < limit_Chroms; i++)
            {
                string bit = Convert.ToString(Convert.ToInt32(c[i].ToString(), 10), 2);
                bit = bit.PadLeft(set_b, '0');
                cho[i] = bit;

            }

            return cho;
        }

    }
}
