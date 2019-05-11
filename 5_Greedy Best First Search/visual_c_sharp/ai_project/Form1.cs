using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ai_project
{
    public partial class Form1 : Form
    {
        /*Arad Bucharest Craiova Dobreta Eforie Fagaras Giurgiu Hirsova Iasi Lugoj Mehadia
Neamt Oradea Pitesti Rimnicu Sibiu Timisoara Urziceni Vaslui Zerind
         */
        private Dictionary<string, string[]> arr_neighbor = new Dictionary<string, string[]>()
        {
            {"a",new string[]{"s","t","z"}},            {"b",new string[]{"f","g","p","u"}},
            {"c",new string[]{"d","p","r"}},            {"d",new string[]{"c","m"}},
            {"e",new string[]{"h"}},            {"f",new string[]{"b","s"}},
            {"g",new string[]{"b"}},            {"h",new string[]{"e","u"}},
            {"i",new string[]{"n","v"}},            {"l",new string[]{"m","t"}},
            {"m",new string[]{"d","l"}},            {"n",new string[]{"i"}},
            {"o",new string[]{"s","z"}},            {"p",new string[]{"b","c","r"}},
            {"r",new string[]{"c","p","s"}},            {"s",new string[]{"a","f","o","r"}},
            {"t",new string[]{"a","l"}},            {"u",new string[]{"b","h","v"}},
            {"v",new string[]{"i","u"}},            {"z",new string[]{"a","o"}},
        };

        private Dictionary<string, int> arr_line = new Dictionary<string, int>()
        {
            {"a",366},            {"b",0},            {"c",160},            {"d",242},
            {"e",161},            {"f",176},            {"g",77},            {"h",151},
            {"i",226},            {"l",244},            {"m",241},            {"n",234},
            {"o",380},            {"p",10},            {"r",193},            {"s",253},
            {"t",329},            {"u",80},            {"v",199},            {"z",374},
        };

        private Dictionary<string, string> arr_short_name = new Dictionary<string, string>()
        {
            {"Arad","a"},            {"Bucharest","b"},            {"Craiova","c"},            {"Dobreta","d"},
            {"Eforie","e"},            {"Fagaras","f"},            {"Giurgiu","g"},            {"Hirsova","h"},
            {"Iasi","i"},            {"Lugoj","l"},            {"Mehadia","m"},            {"Neamt","n"},
            {"Oradea","o"},            {"Pitesti","p"},            {"Rimnicu","r"},            {"Sibiu","s"},
            {"Timisoara","t"},            {"Urziceni","u"},            {"Vaslui","v"},            {"Zerind","z"},
        };

        private Dictionary<string, string> arr_full_name = new Dictionary<string, string>()
        {
            {"a","Arad"},            {"b","Bucharest"},            {"c","Craiova"},            {"d","Dobreta"},
            {"e","Eforie"},            {"f","Fagaras"},            {"g","Giurgiu"},            {"h","Hirsova"},
            {"i","Iasi"},            {"l","Lugoj"},            {"m","Mehadia"},            {"n","Neamt"},
            {"o","Oradea"},            {"p","Pitesti"},            {"r","Rimnicu"},            {"s","Sibiu"},
            {"t","Timisoara"},            {"u","Urziceni"},            {"v","Vaslui"},            {"z","Zerind"},
        };

        private List<string> way = new List<string>();
        private string start = "", end = "", now = "";
        private int x = 50, y = 0;
        private int x1 = 0, y1 = 0, x2 = 0, y2 = 0, next_x = 120, next_y = 100, town_index = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            source.SelectedIndex = 0;
        }

        private void draw_path_town(Color c, float line_width)
        {
            System.Drawing.Pen myPen;
            myPen = new System.Drawing.Pen(c);
            myPen.Width = line_width;
            System.Drawing.Graphics formGraphics = pn_show.CreateGraphics();
            formGraphics.DrawLine(myPen, x1, y1, x2, y2);
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private void create_town(string town, int x, int y)
        {
            Label l = new Label();
            l.Name = arr_full_name[town] + town_index;
            l.Text = arr_full_name[town] + "\n" + arr_line[town];
            l.Size = new Size(100, 60);
            l.BorderStyle = BorderStyle.FixedSingle;
            l.TextAlign = ContentAlignment.MiddleCenter;
            pn_show.Controls.Add(l);
            l.Location = new Point(pn_show.Width / 2 - x, y);
        }

        private void find_neighbor(string old_town)
        {
            Dictionary<int, string> neighbor = new Dictionary<int, string>();
            int[] length = new int[arr_neighbor[old_town].Length];
            string town = "";

            //กำหนดจุดเริ่มเส้น
            x1 = pn_show.Controls[arr_full_name[old_town] + town_index].Left + 50;
            y1 = pn_show.Controls[arr_full_name[old_town] + town_index].Bottom;
            town_index++;

            x = arr_neighbor[old_town].Length * (-25); y += next_y;

            for (int i = 0; i < arr_neighbor[old_town].Length; i++)
            {
                town = arr_neighbor[old_town][i];
                neighbor[arr_line[town]] = town;
                length[i] = arr_line[town];
                create_town(town, x, y);
                //กำหนดจุดจบเส้น
                x2 = pn_show.Controls[arr_full_name[town] + town_index].Left + 50;
                y2 = pn_show.Controls[arr_full_name[town] + town_index].Top;
                //วาดเส้นทาง
                draw_path_town(Color.Red, 1.5F);

                x += next_x;
            }

            //หาเมืองที่ใกล้ที่สุด
            Array.Sort(length);
            town = neighbor[length[0]];
            //เพิ่มความหนาของเส้น
            x1 = pn_show.Controls[arr_full_name[old_town] + (town_index - 1)].Left + 50;
            y1 = pn_show.Controls[arr_full_name[old_town] + (town_index - 1)].Bottom;
            x2 = pn_show.Controls[arr_full_name[town] + town_index].Left + 50;
            y2 = pn_show.Controls[arr_full_name[town] + town_index].Top;
            draw_path_town(Color.Red, 3F);


            //ถ้ามาถึงที่หมาย ให้หยุดการค้นหา
            if (town.Equals(end))
            {
                pn_show.Controls[arr_full_name[town] + town_index].BackColor = Color.GreenYellow;
                lb_path.Text += arr_full_name[end];

                source.Enabled = true;
                search.Enabled = true;

                return;
            }
            //ถ้าวนกลับมาเมืองเดิม ให้หยุดการค้นหา
            else if (way.Contains(town))
            {
                pn_show.Controls[arr_full_name[town] + town_index].BackColor = Color.LightBlue;
                lb_path.Text += arr_full_name[town];

                source.Enabled = true;
                search.Enabled = true;

                return;
            }

            //เพิ่งเมืองที่เลือกเดินทางผ่าน
            way.Add(town);
            pn_show.Controls[arr_full_name[town] + town_index].BackColor = Color.LightBlue;
            Floor.Panel1.Controls["town_" + town].BackColor = Color.Blue;
            lb_path.Text += arr_full_name[town] + " -> ";

            //หาเมืองถัดไป
            now = town;
            timer_draw.Enabled = true;//เว้นระยะเวลาเพื่อแสดงข้อมูล
        }

        private void search_Click(object sender, EventArgs e)
        {
            source_SelectedIndexChanged(new object(), new EventArgs());
            
            way.Clear();
            pn_show.Refresh();
            start = ""; end = "";
            x = 50; y = 10;

            if (source.SelectedIndex == 0)
            {
                return;
            }

            pn_show.Controls.Clear();
            source.Enabled = false;
            search.Enabled = false;

            //กำหนดเมืองเริ่มต้น สิ้นสุด
            start = arr_short_name[source.SelectedItem.ToString()];
            next_y = start.Equals("t") ? 80 : 100;
            end = arr_short_name[destination.Text.ToString()];
            lb_path.Text = arr_full_name[start] + " -> ";
            way.Add(start);
            now = start;

            //สร้างเมืองเริ่ม
            Floor.Panel1.Controls["town_" + start].BackColor = Color.White;
            ((PictureBox)Floor.Panel1.Controls["town_" + start]).BorderStyle = BorderStyle.None;
            Floor.Panel1.Controls["town_" + start].BackgroundImage = global::ai_project.Properties.Resources.flag_red_16;
            create_town(start, x, y);
            pn_show.Controls[arr_full_name[start] + town_index].BackColor = Color.Pink;

            //ค้นหาเมืองถัดไป
            timer_draw.Enabled = true;//เว้นระยะเวลาเพื่อแสดงข้อมูล            
        }

        private void source_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Floor.Panel1.Controls.Count; i++)
            {
                if (Floor.Panel1.Controls[i].Name.Contains("town_"))
                {
                    Floor.Panel1.Controls[i].BackColor = Color.White;
                    Floor.Panel1.Controls[i].BackgroundImage = null;
                    ((PictureBox)Floor.Panel1.Controls[i]).BorderStyle = BorderStyle.Fixed3D;
                }
            }

            ((PictureBox)Floor.Panel1.Controls["town_b"]).BorderStyle = BorderStyle.None;
            Floor.Panel1.Controls["town_b"].BackgroundImage = global::ai_project.Properties.Resources.flag_green_16; ;

            if (source.SelectedIndex == 0)
            {
                return;
            }

            string town = arr_short_name[source.SelectedItem.ToString()];
            Floor.Panel1.Controls["town_" + town].BackColor = Color.Red;
        }

        private void timer_draw_Tick(object sender, EventArgs e)
        {
            timer_draw.Enabled = false;
            find_neighbor(now);
        }
    }
}
