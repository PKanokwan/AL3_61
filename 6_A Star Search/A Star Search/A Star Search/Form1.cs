using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A_Star_Search
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> arr_short_name = new Dictionary<string, string>()
        {
            {"Arad","a"},            {"Bucharest","b"},            {"Craiova","c"},            {"Dobreta","d"},
            {"Eforie","e"},            {"Fagaras","f"},            {"Giurgiu","g"},            {"Hirsova","h"},
            {"Iasi","i"},            {"Lugoj","l"},            {"Mehadia","m"},            {"Neamt","n"},
            {"Oradea","o"},            {"Pitesti","p"},            {"Rimnicu","r"},            {"Sibiu","s"},
            {"Timisoara","t"},            {"Urziceni","u"},            {"Vaslui","v"},            {"Zerind","z"},
        };
                
        string[] city = new string[] { "Arad", "Bucharest", "Craiova", "Dobreta", "Eforie", "Fagaras", "Giurgiu", "Hirsova", "Iasi", "Lugoj", 
            "Mehadia", "Neamt", "Oradea", "Pitesti", "Rimnicu Vilcea", "Sibiu", "Timisoara", "Urziceni", "Vaslui", "Zerind"};
        int[,] travel = new int[31, 17];//(เมือง,ระยะทางที่ห่างจากเมือง Bucharest,ระยะทางสะสม,ระยะทางรวม)X4 ,ระดับ
        int[,] select_city = new int[31, 4];//หมายเลขเมือง,ตำแหน่ง row ในอาร์เรย์ travel,ตำแหน่ง column ในอาร์เรย์ travel,ระยะทาง
        int[,] dis_city = new int[20, 10]{
        {0,366,15,140,16,118,19,75,0,0},
        {1,0,5,211,6,90,13,101,17,85},
        {2,160,3,120,13,138,14,146,0,0},
        {3,242,2,120,10,75,0,0,0,0},
        {4,161,7,86,0,0,0,0,0,0},
        {5,176,1,211,15,99,0,0,0,0},
        {6,77,1,90,0,0,0,0,0,0},
        {7,151,4,86,17,98,0,0,0,0},
        {8,226,11,87,18,92,0,0,0,0},
        {9,244,10,70,16,111,0,0,0,0},
        {10,241,3,75,9,70,0,0,0,0},
        {11,234,8,87,0,0,0,0,0,0},
        {12,380,15,151,19,71,0,0,0,0},
        {13,100,1,101,2,138,14,97,0,0},
        {14,193,2,146,13,97,15,80,0,0},
        {15,253,0,140,5,99,12,151,14,80},
        {16,329,0,118,9,111,0,0,0,0},
        {17,80,1,85,7,98,18,142,0,0},
        {18,199,8,92,17,142,0,0,0,0},
        {19,374,0,75,12,71,0,0,0,0}
        };//หมายเลขเมือง,ระยะทางที่ห่างจากเมือง Bucharest,หมายเลขเมืองที่อยู่ติดกัน <= 4,ระยะทางระหว่างเมือง <= 4
        int start, speed;
        Form2 Answer_form;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //กำหนดค่า Default ที่เมือง Arad
            cbbStart.SelectedIndex = 0;
            ((PictureBox)Floor.Panel1.Controls["town_a"]).BorderStyle = BorderStyle.FixedSingle;
            Floor.Panel1.Controls["town_a"].Visible = true;
            Floor.Panel1.Controls["town_a"].BackgroundImage = global::A_Star_Search.Properties.Resources._true;
        }

        private void cbbStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Floor.Panel1.Controls.Count; i++)
            {
                if (Floor.Panel1.Controls[i].Name.Contains("town_"))
                {
                    Floor.Panel1.Controls[i].Visible = true;
                    Floor.Panel1.Controls[i].BackgroundImage = null;
                    ((PictureBox)Floor.Panel1.Controls[i]).BorderStyle = BorderStyle.FixedSingle;
                }
            }

            //กำหนดให้ ตำแหน่ง Bucharest เป็นรูปบ้าน
            ((PictureBox)Floor.Panel1.Controls["town_b"]).BorderStyle = BorderStyle.FixedSingle;
            Floor.Panel1.Controls["town_b"].Visible = true;
            Floor.Panel1.Controls["town_b"].BackgroundImage = global::A_Star_Search.Properties.Resources.home;

            //if (cbbStart.SelectedIndex == 0)
            //{
           //     return;
            //}

            // กำหนดให้เมื่อเลือกเมือง จะนำชื่อที่ได้ไปแปลงเป็นอักษรย่อ จาก Dictionary ที่กำหนด
            // และกำหนดให้มีรูปเครื่องหมายถูกที่ตำแหน่งเมืองนั้นๆ
            string town = arr_short_name[cbbStart.SelectedItem.ToString()];
            Floor.Panel1.Controls["town_" + town].Visible = true;
            Floor.Panel1.Controls["town_" + town].BackgroundImage = global::A_Star_Search.Properties.Resources._true;
            //btnSearch.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbbStart.SelectedIndex < 1)
            {
                start = cbbStart.SelectedIndex;
            }
            else
            {
                // +1 เนื่องจาก ตำแหน่งที่ 1 เป็นเมือง Bucharest ที่ไม่มีอยู่ใน List รายการ
                start = cbbStart.SelectedIndex + 1;
            }

            a_search(start, 1);
            speed = (10 - Convert.ToInt32(numericUpDown1.Value.ToString())) * 150;
            Answer_form = new Form2(travel, select_city, speed);
            Answer_form.ShowDialog();
        }

        private void a_search(int start_, int destination_)//ค้นหาแบบ A_star
        {
            //////////////////////Clear ค่าใน Array /////////////////////////////////
            Array.Clear(select_city, 0, select_city.Length);
            Array.Clear(travel, 0, travel.Length);
            //////////////////////////ประกาศตัวแปร กำหนดค่าในตัวแปร/////////////////////////////////////////////
            int[] step_traval = new int[17];
            int[] choose_now, choose_new = new int[4];
            int back = 0;
            select_city[0, 0] = start_;//เมืองที่เลือก
            select_city[0, 1] = 0;//ตำแหน่ง row ในอาร์เรย์ travel
            select_city[0, 2] = 0;//ตำแหน่ง column ในอาร์เรย์ travel
            select_city[0, 3] = dis_city[start_, 1] + 0;//ระยะทางรวม
            travel[0, 0] = start_;//เมืองที่เลือก
            travel[0, 1] = dis_city[start_, 1];//ระยะทางที่ห่างจากเมือง Bucharest
            travel[0, 2] = 0; //ระยะทางสะสม
            travel[0, 3] = dis_city[start_, 1] + 0;//ระยะทางรวม
            //////////////////////////////วนรอบทำการค้นหา/////////////////////////////////////////
            for (int i = 1; i < 31; i++)
            {
                //////////////////////////////ค้นหาเมืองที่จะไปได้///////////////////////////////////
                step_traval = find_city(select_city[i - 1, 0], i - 1 - back);//หาเมืองที่จะไป,ระยะทางจาก Bucharest,ระยะทางสะสม,ระยะทางรวม
                step_traval[16] = chk_lv(i - back);//ใส่ค่าระดับ
                for (int j = 0; j < 17; j++)
                {
                    travel[i, j] = step_traval[j];
                }
                choose_now = choose_city(step_traval, i);//หมายเลขเมือง,ตำแหน่ง row ในอาร์เรย์ travel,ตำแหน่ง column ในอาร์เรย์ travel,ระยะทาง
                choose_new = sch_dis_city_less(choose_now[3], i);
                //////////////////////เปรียบเทียบหาค่าที่น้อยสุดเพื่อนำไปค้นหาเมืองที่จะไปได้/////////////////////
                if (choose_now[3] > choose_new[3] && choose_new[3] != 0)//ถ้ามีเมืองที่มีระยะทางสะสมน้อยกว่าเมืองที่เลือกในปัจจุบัน
                {
                    select_city[i, 0] = choose_new[0];//เมืองที่เลือก
                    select_city[i, 1] = choose_new[1];//ตำแหน่ง row ในอาร์เรย์ travel
                    select_city[i, 2] = choose_new[2];//ตำแหน่ง column ในอาร์เรย์ travel
                    select_city[i, 3] = choose_new[3];//ระยะทางรวม
                    back = i - choose_new[1];
                }
                else
                {
                    select_city[i, 0] = choose_now[0];//เมืองที่เลือก
                    select_city[i, 1] = choose_now[1];//ตำแหน่ง row ในอาร์เรย์ travel
                    select_city[i, 2] = choose_now[2];//ตำแหน่ง column ในอาร์เรย์ travel
                    select_city[i, 3] = choose_now[3];//ระยะทางรวม
                    back = 0;
                }
                //select_city[i, 1] = step_traval[16];
                //////////////////////////เงื่อนไขในการหยุดค้นหา//////////////////////////////
                if (select_city[i, 0] == destination_ && choose_new[3] == 0)
                {
                    i = 32;
                    for (int k = 0; k < 17; k++)
                    {
                        select_city[k, 1] = travel[k, 16];//เปลี่ยนจากค่าตำแหน่ง row ในอาร์เรย์ travel เป็นระดับ
                    }
                }
            }
        }

        private int[] find_city(int source_city, int step_for_sch)//หาเมืองที่จะไป,ระยะทางจาก Bucharest,ระยะทางสะสม,ระยะทางรวม
        {
            int[] step_traval_ = new int[17];
            int count = 0;
            int index_of_source_city = find_index_no_city(source_city, step_for_sch); //ลำดับของเมืองกำหนด ที่อยู่ในอาร์เรย์ travel ในชั้นที่ส่งมา
            for (int i = 2; i < 10; i += 2) //หาเมืองที่จะไปได้
            {
                if (dis_city[source_city, i + 1] != 0)//ถ้าระยะทางระหว่างเมืองมากกว่าในตำแหน่งที่หาอยู่ไม่เป็น 0
                {
                    step_traval_[count] = dis_city[source_city, i];//หมายเลขเมือง
                    count++;

                    step_traval_[count] = dis_city[step_traval_[count - 1], 1];//ระยะทางที่ห่างจากเมือง Bucharest ของเมืองที่สามารถไปได้
                    count++;

                    step_traval_[count] = dis_city[source_city, i + 1] + travel[step_for_sch, index_of_source_city + 2];//ระยะทางสะสม
                    count++;

                    step_traval_[count] = dis_city[step_traval_[count - 3], 1] + step_traval_[count - 1];//ระยะทางรวม
                    count++;
                }
            }
            return step_traval_;
        }

        private int[] choose_city(int[] step_travel_, int step_for_sch)//หาเมืองที่เลือก, ตำแหน่งในอาร์เรย์ travel, ระยะทาง
        {
            int[] choose = new int[4];//หมายเลขเมือง,ตำแหน่ง row ในอาร์เรย์ travel,ตำแหน่ง column ในอาร์เรย์ travel,ระยะทาง
            int less = 5000;
            for (int i = 3; i < 16; i += 4) //หาเมืองที่มีระยะทางรวมน้อยที่สุด
            {
                if (step_travel_[i] != 0)
                {
                    if (step_travel_[i] < less)
                    {
                        less = step_travel_[i];
                        choose[0] = step_travel_[i - 3];
                        choose[1] = step_for_sch;
                        choose[2] = (i - 3) / 4;
                        choose[3] = less;
                    }
                }
            }
            return choose;
        }

        private int find_index_no_city(int soucer_city, int step_for_sch)//หาลำดับของเมืองกำหนด ที่อยู่ในอาร์เรย์ travel ในชั้นที่ส่งมา
        {
            int index_ = 0;
            for (int i = 0; i < 16; i += 4)
            {
                if (soucer_city == travel[step_for_sch, i] && travel[step_for_sch, i + 3] != 0)
                {
                    index_ = i;
                }
            }
            return index_;
        }

        private int[] sch_dis_city_less(int choose_distance, int sum_choose)//หาเมืองที่มีระยะทางรวมน้อยกว่าค่าที่ส่งมา และยังไม่เคยถูกเลือกมาก่อน
        {
            int[] choose = new int[4];//เมือง,ตำแหน่งในอาร์เรย์ travel,ระยะทาง
            int less = 5000;
            int chk;
            for (int i = 1; i < sum_choose; i++)//หาเมืองที่มีระยะทางรวมน้อยที่สุด
            {
                for (int j = 3; j < 16; j += 4)//หาเมืองที่มีระยะทางรวมน้อยที่สุด
                {
                    chk = 0;
                    if (travel[i, j] != 0)//ถ้าระยะทางรวมน้อยที่สุดไม่เป็น 0
                    {
                        if (travel[i, j] < less && travel[i, j] < choose_distance)//ถ้าระยะทางรวมน้อยกว่าค่า less และน้อยกว่าค่า choose_distance
                        {
                            for (int k = 1; k <= sum_choose; k++)
                            {
                                if (travel[i, j] == select_city[k, 3])//ถ้าระยะทางรวมไม่ตรงกับเมืองที่เคยเลือก
                                {
                                    chk = 1;
                                }
                            }
                            if (chk == 0)
                            {
                                less = travel[i, j];
                                choose[0] = travel[i, j - 3];
                                choose[1] = i;
                                choose[2] = (j - 3) / 4;
                                choose[3] = less;
                            }
                        }
                    }
                }
            }
            return choose;
        }

        private int chk_lv(int row_of_travel)//หาค่าระดับจากค่า row ในอาร์เรย์ travel
        {
            int lv = 5001;
            lv = travel[row_of_travel - 1, 16] + 1;
            return lv;
        }
    }
}