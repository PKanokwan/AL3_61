using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProgram
{
    class Mutation
    {
        static int limit_chrome=10;
        static int set_b = 4;
        Random ran = new Random();
        string[] mutation = new string[limit_chrome];
        double[] r_m = new double[set_b];
        

        public Mutation(string[] m_t)
        {
            mutation = m_t;
        }

        public string Get_r()             // สุ่มค่า r ห้าค่า
        {
            string r = "";

            for (int i = 0; i < set_b;i++ )
            {
                r_m[i] = ran.NextDouble();

                if(i != 0)
                {
                    r += " | ";
                }
                r += r_m[i].ToString("0.0000");
            }

            return r;
        }
      
        public string Get_Mutation(double m,int index)
        {

            string str_m = "";
                char[] arc = mutation[index].ToCharArray();
                 
                for (int j = 0; j < set_b;j++ )
                {
                    if(r_m[j] < m)
                    {
                        if(arc[j] == '1')
                        {
                            arc[j] = '0';
                        }else if(arc[j] == '0')
                        {
                            arc[j] = '1';
                        }
                         
                    }
                    str_m += arc[j];

                }

               return  str_m;
            
        }

        public int Get_F(string f)
        {
            string m_f = Convert.ToString(Convert.ToInt32(f,2),10);
            int int_f = (15 * Convert.ToInt32(m_f)) - (Convert.ToInt32(m_f) * Convert.ToInt32(m_f));
            return int_f;
        }
        
    }
}
