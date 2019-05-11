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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] city = new string[] { "Arad", "Bucharest", "Craiova", "Dobreta", "Eforie", "Fagaras", "Giurgiu", "Hirsova", "Iasi", "Lugoj", 
            "Mehadia", "Neamt", "Oradea", "Pitesti", "Rimnicu Vilcea", "Sibiu", "Timisoara", "Urziceni", "Vaslui", "Zerind"};
        int[,] travel2 = new int[31, 17];//(เมือง,ระยะทางที่ห่างจากเมือง Bucharest,ระยะทางสะสม,ระยะทางรวม)X4 ,ระดับ
        int[,] travel3 = new int[31, 17];//(เมือง,ระยะทางที่ห่างจากเมือง Bucharest,ระยะทางสะสม,ระยะทางรวม)X4 ,ระดับ แบบเรียงน้อยไปหามากในแต่ละ row
        int[,] select_city2 = new int[31, 4];//หมายเลขเมือง,ตำแหน่ง row ในอาร์เรย์ travel,ตำแหน่ง column ในอาร์เรย์ travel,ระยะทาง
        Bitmap Bmp_File = new Bitmap(1200, 650);
        Bitmap vvv = new Bitmap(1200, 650);
        int[,] point = new int[80, 4];//ตำแหน่งx,ตำแหน่งy,หมายเลขเมือง,ระยะทางรวม 
        int[] sch_per_lv;//เก็บค่าจำนวนครั้งในการค้นหาแต่ละระดับ
        int[] c_per_lv;
        int speed2, between_y;
        int time = 0, max_lv = 0, sum_step = 0, step = 0, c_box = 0;

        public Form2(int[,] travel, int[,] select_city, int speed)
        {
            InitializeComponent();
            travel2 = travel;
            select_city2 = select_city;
            speed2 = speed;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sch_setup();
            sort_arr_travel3();

            ///////////////////////////////////////////////////////////////////
            between_y = (650 - 120) / max_lv;//หาระยะห่างของแต่ละระดับ
            timer1.Interval = speed2;
            timer1.Start();
        }

        private Bitmap drawbox(Bitmap Bmp, int loc_x, int loc_y, string st, int path, int sum, int sum_path, Color color1)//วาดช่องมีขนาด กว้าง 90 สูง 40
        {
            Font font1 = new Font("Tahoma", 10.0f, FontStyle.Regular);
            SolidBrush drawBrush = new SolidBrush(color1);
            Graphics grap = Graphics.FromImage(Bmp);
            Pen my_pen = new Pen(color1, 1);
            grap.DrawEllipse(my_pen, loc_x, loc_y, 100, 60); // ----------------------------------->> กำหนดขนาดกรอบ grap.DrawEllipse(my_pen, loc_x, loc_y, 90, 40);
            //grap.DrawRectangle(my_pen, loc_x, loc_y + 20, 90, 20);
            grap.DrawString("   "+st, font1, drawBrush, loc_x, loc_y+10);  // ----------------------------------->> กำหนดตำแหน่งข้อความ ชื่อเมือง
            grap.DrawString("   "+sum_path + "=" + sum + "+" + path, font1, drawBrush, loc_x, loc_y + 30); // ----------------------------------->> กำหนดตำแหน่งข้อความ ตัวเลข

            return Bmp;
        }

        private Bitmap drawboxx(Bitmap Bmp, int loc_x, int loc_y,int locx, int locy, Color color1)
        {
            SolidBrush drawBrush = new SolidBrush(color1);
            Graphics grap = Graphics.FromImage(Bmp);
            Pen my_pen = new Pen(color1, 1);
            grap.DrawEllipse(my_pen, loc_x, loc_y, 100, 60); // ----------------------------------->> กำหนดขนาดกรอบ grap.DrawEllipse(my_pen, loc_x, loc_y, 90, 40);
            grap.DrawEllipse(my_pen, locx, locy, 100, 60); 
            return Bmp;
        }

        private Bitmap string_end(Bitmap Bmp, int loc_x, int loc_y, string st)//วาดข้อความ Finished
        {
            Font font1 = new Font("Tahoma", 16.0f, FontStyle.Regular);
            SolidBrush drawBrush = new SolidBrush(Color.DarkGreen);
            Graphics grap = Graphics.FromImage(Bmp);
            grap.DrawString(st, font1, drawBrush, loc_x, loc_y);
            return Bmp;
        }

        private Bitmap draw_line_fn(Bitmap Bmp, int source_x, int source_y, int destination_x, int destination_y, int size, Color color2)//ลากเส้นจากตำแหน่ง source_x,source_y ไปยัง destination_x,destination_y
        {
            Point point1 = new Point(source_x, source_y+20);
            Point point2 = new Point(destination_x, destination_y);
            Pen my_pen = new Pen(color2, size);
            Graphics grap = Graphics.FromImage(Bmp);
            grap.DrawLine(my_pen, point1, point2);
            return Bmp;
        }

        private int sch_city_per_time(int stepp)//หาจำนวนเมืองที่สามารถไปได้ในขั้นตอนที่กำหนดมา
        {
            int count = 0;
            for (int i = 3; i < 17; i += 4)
            {
                if (travel2[stepp, i] != 0)
                { count++; }
            }
            return count;
        }

        private int sch_cbox_from_dis(int distance)//หาค่าว่าอยู่จุดที่เท่าไรจากระยะทางรวม
        {
            int box = 5000;
            for (int i = 0; i < c_box; i++)
            {
                if (point[i, 3] == distance)
                {
                    box = i;
                }
            }
            return box;
        }

        private int[] sort_step(int step1)//เปรียบเทียบค่า4ค่าว่าอยู่ซ้ายถึงขวาโดยเลขน้อยอยู่ซ้าย
        {
            int[] order = new int[16];
            int[] buf1 = new int[4];
            int[] buf2 = new int[4];

            for (int i = 0; i < 4; i++)
            {
                if (travel2[step1, i * 4 + 3] != 0)
                {
                    buf1[i] = travel2[step1, i * 4 + 3];
                    buf2[i] = buf1[i];
                }
            }
            Array.Sort(buf1);
            for (int j = 0; j < 4; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (buf2[j] == buf1[k])
                    {
                        order[k * 4] = travel2[step1, j * 4];
                        order[k * 4 + 1] = travel2[step1, j * 4 + 1];
                        order[k * 4 + 2] = travel2[step1, j * 4 + 2];
                        order[k * 4 + 3] = travel2[step1, j * 4 + 3];
                    }
                }
            }
            return order;
        }

        private void sort_arr_travel3()//เรียงค่าน้อยสุดไปมากสุดแต่ละ row ในอาร์เรย์ travel3
        {
            int[] sort_travel = new int[16];
            int[] buf_travel = new int[16];
            for (int l = 0; l < sum_step; l++)
            {
                Array.Clear(buf_travel, 0, 16);
                sort_travel = sort_step(l);
                int index_ = 0;
                for (int m = 0; m < 4; m++)
                {
                    if (sort_travel[m * 4 + 3] != 0)
                    {
                        index_ = m * 4;
                        m = 4;
                    }
                }
                Array.Copy(sort_travel, index_, buf_travel, 0, buf_travel.Length - index_);
                for (int n = 0; n < 16; n++)
                {
                    travel3[l, n] = buf_travel[n];
                }
                travel3[l, 16] = travel2[l, 16];
            }
        }

        private void sch_setup()//หาค่า ระดับสูงสุด,จำนวนครั้งในการค้นหา,จำนวนครั้งในการค้นหาแต่ละระดับ
        {
            for (int i = 0; i < 31; i++)
            {
                if (travel2[i, 16] > max_lv)//หาว่ามีทั้งหมดถึงระดับที่เท่าไร นับเริ่มระดับที่ 0
                {
                    max_lv = travel2[i, 16];
                }
                if (travel2[i, 3] > 0) //หาว่าทำการท่องไปกี่ครั้งนับเริ่มครั้งที่ 0
                {
                    sum_step++;
                }
            }
            sch_per_lv = new int[max_lv + 1];//เก็บค่าจำนวนครั้งในการค้นหาแต่ละระดับ
            c_per_lv = new int[max_lv + 1];
            for (int j = 0; j < max_lv + 1; j++) // หาว่าแต่ละระดับมีการหาที่ระดับนี้กี่ครั้ง
            {
                for (int k = 0; k < sum_step; k++)
                {
                    if (travel2[k, 16] == j)
                    {
                        sch_per_lv[j]++;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time == 1)
            {
                ////////////วาดเมืองต้นทาง///////////
                point[c_box, 0] = 565;
                point[c_box, 1] = 10;
                point[c_box, 2] = travel3[0, 0];
                point[c_box, 3] = travel3[0, 3];
                Bmp_File = drawbox(Bmp_File, point[c_box, 0], point[c_box, 1], city[point[c_box, 2]], travel3[step, 1], travel3[step, 2], travel3[step, 3], Color.Red);
                pictureBox1.Image = Bmp_File;
                c_box++;
                step++;
            }
            else if (time > 1)
            {
                if (time % 2 == 0)
                {
                    if (sch_per_lv[travel3[step, 16]] == 1)
                    {
                        int city_per_time = sch_city_per_time(step);
                        for (int i = 0; i < city_per_time; i++)
                        {
                            point[c_box, 0] = 600 - city_per_time * 45 + (i * 110);  // ------->> Default 45 + (i * 90);
                            point[c_box, 1] = 10 + between_y * travel3[step, 16];
                            point[c_box, 2] = travel3[step, i * 4];
                            point[c_box, 3] = travel3[step, i * 4 + 3];
                            Bmp_File = drawbox(Bmp_File, point[c_box, 0], point[c_box, 1], city[point[c_box, 2]], travel3[step, i * 4 + 1], travel3[step, i * 4 + 2], travel3[step, i * 4 + 3], Color.Black);//กรอบสีดำ
                             int box_1 = sch_cbox_from_dis(select_city2[step - 1, 3]);
                            Bmp_File = draw_line_fn(Bmp_File, point[box_1, 0] + 45, point[box_1, 1] + 40, point[c_box, 0] + 45, point[c_box, 1], 2, Color.Black);//เส้นสีดำ
                            c_box++;
                        }
                        pictureBox1.Image = Bmp_File;
                        step++;
                    }
                    else if (sch_per_lv[travel3[step, 16]] == 2)
                    {
                        if (c_per_lv[travel3[step, 16]] == 0)
                        {
                            int city_per_time = sch_city_per_time(step);
                            for (int i = 0; i < city_per_time; i++)
                            {
                                point[c_box, 0] = 300 - city_per_time * 45 + (i * 110);
                                point[c_box, 1] = 10 + between_y * travel3[step, 16];
                                point[c_box, 2] = travel3[step, i * 4];
                                point[c_box, 3] = travel3[step, i * 4 + 3];
                                Bmp_File = drawbox(Bmp_File, point[c_box, 0], point[c_box, 1], city[point[c_box, 2]], travel3[step, i * 4 + 1], travel3[step, i * 4 + 2], travel3[step, i * 4 + 3], Color.Black);
                                int box_1 = sch_cbox_from_dis(select_city2[step - 1, 3]);
                                Bmp_File = draw_line_fn(Bmp_File, point[box_1, 0] + 45, point[box_1, 1] + 40, point[c_box, 0] + 45, point[c_box, 1], 2, Color.Black);
                                c_box++;
                            }
                            pictureBox1.Image = Bmp_File;
                            step++;
                        }
                        else if (c_per_lv[travel3[step, 16]] == 1)
                        {
                            int city_per_time = sch_city_per_time(step);
                            for (int i = 0; i < city_per_time; i++)
                            {
                                point[c_box, 0] = 900 - city_per_time * 45 + (i * 110);
                                point[c_box, 1] = 10 + between_y * travel3[step, 16];
                                point[c_box, 2] = travel3[step, i * 4];
                                point[c_box, 3] = travel3[step, i * 4 + 3];
                                Bmp_File = drawbox(Bmp_File, point[c_box, 0], point[c_box, 1], city[point[c_box, 2]], travel3[step, i * 4 + 1], travel3[step, i * 4 + 2], travel3[step, i * 4 + 3], Color.Black);
                                int box_1 = sch_cbox_from_dis(select_city2[step - 1, 3]);
                                Bmp_File = draw_line_fn(Bmp_File, point[box_1, 0] + 45, point[box_1, 1] + 40, point[c_box, 0] + 45, point[c_box, 1], 2, Color.Black);
                                c_box++;
                            }
                            pictureBox1.Image = Bmp_File;
                            step++;
                        }
                    }
                    else if (sch_per_lv[travel3[step, 16]] == 3)
                    {
                        if (c_per_lv[travel3[step, 16]] == 0)
                        {
                            int city_per_time = sch_city_per_time(step);
                            for (int i = 0; i < city_per_time; i++)
                            {
                                point[c_box, 0] = 200 - city_per_time * 45 + (i * 110);
                                point[c_box, 1] = 10 + between_y * travel3[step, 16];
                                point[c_box, 2] = travel3[step, i * 4];
                                point[c_box, 3] = travel3[step, i * 4 + 3];
                                Bmp_File = drawbox(Bmp_File, point[c_box, 0], point[c_box, 1], city[point[c_box, 2]], travel3[step, i * 4 + 1], travel3[step, i * 4 + 2], travel3[step, i * 4 + 3], Color.Black);
                                int box_1 = sch_cbox_from_dis(select_city2[step - 1, 3]);
                                Bmp_File = draw_line_fn(Bmp_File, point[box_1, 0] + 45, point[box_1, 1] + 40, point[c_box, 0] + 45, point[c_box, 1], 2, Color.Black);
                                c_box++;
                            }
                            pictureBox1.Image = Bmp_File;
                            step++;
                        }
                        else if (c_per_lv[travel3[step, 16]] == 1)
                        {
                            int city_per_time = sch_city_per_time(step);
                            for (int i = 0; i < city_per_time; i++)
                            {
                                point[c_box, 0] = 600 - city_per_time * 45 + (i * 110);
                                point[c_box, 1] = 10 + between_y * travel3[step, 16];
                                point[c_box, 2] = travel3[step, i * 4];
                                point[c_box, 3] = travel3[step, i * 4 + 3];
                                Bmp_File = drawbox(Bmp_File, point[c_box, 0], point[c_box, 1], city[point[c_box, 2]], travel3[step, i * 4 + 1], travel3[step, i * 4 + 2], travel3[step, i * 4 + 3], Color.Black);
                                int box_1 = sch_cbox_from_dis(select_city2[step - 1, 3]);
                                Bmp_File = draw_line_fn(Bmp_File, point[box_1, 0] + 45, point[box_1, 1] + 40, point[c_box, 0] + 45, point[c_box, 1], 2, Color.Black);
                                c_box++;
                            }
                            pictureBox1.Image = Bmp_File;
                            step++;
                        }
                        else if (c_per_lv[travel3[step, 16]] == 2)
                        {
                            int city_per_time = sch_city_per_time(step);
                            for (int i = 0; i < city_per_time; i++)
                            {
                                point[c_box, 0] = 1000 - city_per_time * 45 + (i * 110);
                                point[c_box, 1] = 10 + between_y * travel3[step, 16];
                                point[c_box, 2] = travel3[step, i * 4];
                                point[c_box, 3] = travel3[step, i * 4 + 3];
                                Bmp_File = drawbox(Bmp_File, point[c_box, 0], point[c_box, 1], city[point[c_box, 2]], travel3[step, i * 4 + 1], travel3[step, i * 4 + 2], travel3[step, i * 4 + 3], Color.Black);
                                int box_1 = sch_cbox_from_dis(select_city2[step - 1, 3]);
                                Bmp_File = draw_line_fn(Bmp_File, point[box_1, 0] + 45, point[box_1, 1] + 40, point[c_box, 0] + 45, point[c_box, 1], 2, Color.Black);
                                c_box++;
                            }
                            pictureBox1.Image = Bmp_File;
                            step++;
                        }

                    }
                    else if (sch_per_lv[travel3[step, 16]] == 4)
                    {
                        if (c_per_lv[travel3[step, 16]] == 0)
                        {
                            int city_per_time = sch_city_per_time(step);
                            for (int i = 0; i < city_per_time; i++)
                            {
                                point[c_box, 0] = 150 - city_per_time * 45 + (i * 110);
                                point[c_box, 1] = 10 + between_y * travel3[step, 16];
                                point[c_box, 2] = travel3[step, i * 4];
                                point[c_box, 3] = travel3[step, i * 4 + 3];
                                Bmp_File = drawbox(Bmp_File, point[c_box, 0], point[c_box, 1], city[point[c_box, 2]], travel3[step, i * 4 + 1], travel3[step, i * 4 + 2], travel3[step, i * 4 + 3], Color.Black);
                                int box_1 = sch_cbox_from_dis(select_city2[step - 1, 3]);
                                Bmp_File = draw_line_fn(Bmp_File, point[box_1, 0] + 45, point[box_1, 1] + 40, point[c_box, 0] + 45, point[c_box, 1], 2, Color.Black);
                                c_box++;
                            }
                            pictureBox1.Image = Bmp_File;
                            step++;
                        }
                        else if (c_per_lv[travel3[step, 16]] == 1)
                        {
                            int city_per_time = sch_city_per_time(step);
                            for (int i = 0; i < city_per_time; i++)
                            {
                                point[c_box, 0] = 450 - city_per_time * 45 + (i * 110);
                                point[c_box, 1] = 10 + between_y * travel3[step, 16];
                                point[c_box, 2] = travel3[step, i * 4];
                                point[c_box, 3] = travel3[step, i * 4 + 3];
                                Bmp_File = drawbox(Bmp_File, point[c_box, 0], point[c_box, 1], city[point[c_box, 2]], travel3[step, i * 4 + 1], travel3[step, i * 4 + 2], travel3[step, i * 4 + 3], Color.Black);
                                int box_1 = sch_cbox_from_dis(select_city2[step - 1, 3]);
                                Bmp_File = draw_line_fn(Bmp_File, point[box_1, 0] + 45, point[box_1, 1] + 40, point[c_box, 0] + 45, point[c_box, 1], 2, Color.Black);
                                c_box++;
                            }
                            pictureBox1.Image = Bmp_File;
                            step++;
                        }
                        else if (c_per_lv[travel3[step, 16]] == 2)
                        {
                            int city_per_time = sch_city_per_time(step);
                            for (int i = 0; i < city_per_time; i++)
                            {
                                point[c_box, 0] = 750 - city_per_time * 45 + (i * 110);
                                point[c_box, 1] = 10 + between_y * travel3[step, 16];
                                point[c_box, 2] = travel3[step, i * 4];
                                point[c_box, 3] = travel3[step, i * 4 + 3];
                                Bmp_File = drawbox(Bmp_File, point[c_box, 0], point[c_box, 1], city[point[c_box, 2]], travel3[step, i * 4 + 1], travel3[step, i * 4 + 2], travel3[step, i * 4 + 3], Color.Black);
                                int box_1 = sch_cbox_from_dis(select_city2[step - 1, 3]);
                                Bmp_File = draw_line_fn(Bmp_File, point[box_1, 0] + 45, point[box_1, 1] + 40, point[c_box, 0] + 45, point[c_box, 1], 2, Color.Black);
                                c_box++;
                            }
                            pictureBox1.Image = Bmp_File;
                            step++;
                        }
                        else if (c_per_lv[travel3[step, 16]] == 3)
                        {
                            int city_per_time = sch_city_per_time(step);
                            for (int i = 0; i < city_per_time; i++)
                            {
                                point[c_box, 0] = 1050 - city_per_time * 45 + (i * 110);
                                point[c_box, 1] = 10 + between_y * travel3[step, 16];
                                point[c_box, 2] = travel3[step, i * 4];
                                point[c_box, 3] = travel3[step, i * 4 + 3];
                                Bmp_File = drawbox(Bmp_File, point[c_box, 0], point[c_box, 1], city[point[c_box, 2]], travel3[step, i * 4 + 1], travel3[step, i * 4 + 2], travel3[step, i * 4 + 3], Color.Black);
                                int box_1 = sch_cbox_from_dis(select_city2[step - 1, 3]);
                                Bmp_File = draw_line_fn(Bmp_File, point[box_1, 0] + 45, point[box_1, 1] + 40, point[c_box, 0] + 45, point[c_box, 1], 2, Color.Black);
                                c_box++;
                            }
                            pictureBox1.Image = Bmp_File;
                            step++;
                        }
                    }
                    c_per_lv[travel3[step - 1, 16]]++;
                }

                if (time % 2 == 1)
                {
                    ////////ลากเส้นทางที่ทำการเลือก/////////
                    int box1 = sch_cbox_from_dis(select_city2[step - 2, 3]);
                    int box2 = sch_cbox_from_dis(travel3[step - 1, 3]);
                    Bmp_File = draw_line_fn(Bmp_File, point[box1, 0] + 45, point[box1, 1] + 40, point[box2, 0] + 45, point[box2, 1], 4, Color.Blue);
                    Bmp_File = drawboxx(Bmp_File, point[box1, 0], point[box1, 1], point[box2, 0], point[box2, 1], Color.Red);
                    pictureBox1.Image = Bmp_File;
                }
            }
            if (time == sum_step * 2)
            {
                timer1.Stop();
                pictureBox1.Image = string_end(Bmp_File, 550, 600, "Finished");
            }
            time++;
        }
    }
}
