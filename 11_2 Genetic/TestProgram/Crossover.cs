using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProgram
{
    class Crossover
    {

        Random ran = new Random();
        static int limit_chroms = 10;
        int set_b = 4;

        string[] mating_pool = new string[limit_chroms];
        int[] r_qi2 = new int[limit_chroms];
        int f1, f2;
        double[] r = new double[limit_chroms / 2];
        string[] cross = new string[2];
        public Crossover(string[] m_p,int[] r_qi)
        {
            r_qi2 = r_qi;
            Set_MatingPool(m_p, r_qi);
            
        }

        private void Set_MatingPool(string[] m_p, int[] r) // 
        {
            for (int i = 0; i < limit_chroms; i++)
            {
                int index = r[i];
                mating_pool[i] = m_p[index];
            }
        }

        public int[] Get_rqi()              //ลำดับที่คัดเลือก
        {
            return r_qi2;
        }
        public string[] Get_MatingPool()    // โคโมโซมที่ถูกเลือก
        {
            return mating_pool;
        }
        public double[] Get_r()             // คืนค่า r ที่สุ่ม            
        {
            for (int i = 0; i < limit_chroms / 2; i++)
            {
                r[i] = ran.NextDouble();

            }
            return r;
        }
        public string[] Get_Crossover(string[] cross,int pos) // Crossover
        {
            this.cross[0] = cross[0].Substring(0, pos).ToString() + cross[1].Substring(pos, set_b - pos);
            this.cross[1] = cross[1].Substring(0, pos).ToString() + cross[0].Substring(pos, set_b - pos);

            return this.cross;
        }
        public void Set_F(int x1,int x2)
        {
            f1 = (15*x1) -(x1* x1);
            f2 = (15 * x2) - (x2*x2);
        }
        public int Get_f1()
        {
            return f1;
        }
        public int Get_f2()
        { 
             return f2;
        }
        
        
    }
}
