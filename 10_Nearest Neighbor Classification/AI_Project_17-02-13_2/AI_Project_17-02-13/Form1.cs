using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AI_Project_17_02_13
{
    public partial class Form1 : Form
    {
        public List<animals> category;        
        private animals[] anList;
        private int[] myProp;
        private double[] distances;        
        private string[] sp = new string[] { "สัตว์ครึ่งบกครึ่งน้ำ", "สัตว์จำพวกนก", "สัตว์เลี้ยงลูกด้วยนม",
                                             "สัตว์เลื้อยคลาน","สัตว์จำพวกปลา", "สัตว์เลื้อยคลาน",
                                             "สัตว์เลี้ยงลูกด้วยนม", "สัตว์จำพวกนก" };
        public Form1()
        {
            InitializeComponent();
            category = new List<animals>();
        }
        private void assign_Prop(animals an, string type, string species,
                                 int p1, int p2, int p3, int p4, int p5,
                                 int p6, int p7, int p8, int p9)
        {
            an.Type = type;
            an.Species = species;
            an.PROP_1 = p1;
            an.PROP_2 = p2;
            an.PROP_3 = p3;
            an.PROP_4 = p4;
            an.PROP_5 = p5;
            an.PROP_6 = p6;
            an.PROP_7 = p7;
            an.PROP_8 = p8;
            an.PROP_9 = p9;
            category.Add(an);
            string[] data = new string[] { an.Type,
                                            an.Species, 
                                            an.PROP_1+"",
                                            an.PROP_2+"",
                                            an.PROP_3+"",
                                            an.PROP_4+"",
                                            an.PROP_5+"",
                                            an.PROP_6+"",
                                            an.PROP_7+"", 
                                            an.PROP_8+"", 
                                            an.PROP_9+""};
            ListViewItem set = new ListViewItem(data);
            listView1.Items.Add(set);            
        }
        private void check_Prop()
        {

            if(prop_chkb1.Checked == true){
                myProp[0] = 1;
            }else{
                myProp[0] = 0;
            }

            if (prop_chkb2.Checked == true)
            {
                myProp[1] = 1;
            }
            else
            {
                myProp[1] = 0;
            }

            if (prop_chkb3.Checked == true)
            {
                myProp[2] = 1;
            }
            else
            {
                myProp[2] = 0;
            }

            if (prop_chkb4.Checked == true)
            {
                myProp[3] = 1;
            }
            else
            {
                myProp[3] = 0;
            }

            if (prop_chkb5.Checked == true)
            {
                myProp[4] = 1;
            }
            else
            {
                myProp[4] = 0;
            }

            if (prop_chkb6.Checked == true)
            {
                myProp[5] = 1;
            }
            else
            {
                myProp[5] = 0;
            }

            if (prop_chkb7.Checked == true)
            {
                myProp[6] = 1;
            }
            else
            {
                myProp[6] = 0;
            }

            if (prop_chkb8.Checked == true)
            {
                myProp[7] = 1;
            }
            else
            {
                myProp[7] = 0;
            }

            if (prop_chkb9.Checked == true)
            {
                myProp[8] = 1;
            }
            else
            {
                myProp[8] = 0;
            }
        }
        
        private string checkSpecies(string[] values)
        {
            if (values[0] == values[1])
                return values[0];
            if (values[1] == values[2])
                return values[1];
            if (values[0] == values[2])
                return values[0];
            return "1. "+values[0]+"\r\n2. "+values[1]+"\r\n3. "+values[2];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            anList = new animals[7];
            
            for (int i = 0; i < 7;i++)
                anList[i] = new animals();
            myProp = new int[9];            
            listView1.Columns.Add("ชนิด",80);
            listView1.Columns.Add("สายพันธุ์",105);
            listView1.Columns.Add("ออกลูกเป็นตัว", 80, HorizontalAlignment.Center);
            listView1.Columns.Add("ออกลูกเป็นไข่", 80, HorizontalAlignment.Center);
            listView1.Columns.Add("เลี้ยงลูกด้วยนม", 90, HorizontalAlignment.Center);
            listView1.Columns.Add("มีขนตามร่างกาย", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("ผิวหยาบหรือเกล็ด", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("สัตว์เลือดอุ่น", 80, HorizontalAlignment.Center);
            listView1.Columns.Add("สัตว์เลือดเย็น", 80, HorizontalAlignment.Center);
            listView1.Columns.Add("อยู่ทั้งในน้ำและบนบก", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("หายใจด้วยเหงือก", 110, HorizontalAlignment.Center);

            assign_Prop(anList[0], "กบ", "สัตว์ครึ่งบกครึ่งน้ำ",0,1,0,0,0,0,1,1,0);
            assign_Prop(anList[1], "ปลาหมอ", "สัตว์จำพวกปลา", 0,1,0,0,1,0,1,0,1);
            assign_Prop(anList[2], "จระเข้", "สัตว์เลื้อยคลาน", 0,1,0,0,1,0,1,0,0);
            assign_Prop(anList[3], "ปลาทอง", "สัตว์จำพวกปลา", 0,0,0,0,1,0,1,0,1);
            assign_Prop(anList[4], "เต่า", "สัตว์เลื้อยคลาน", 0,1,0,0,0,0,1,0,0);
            assign_Prop(anList[5], "สุนัข", "สัตว์เลี้ยงลูกด้วยนม", 1,0,1,1,0,1,0,0,0);
            assign_Prop(anList[6], "นกกระจอกเทศ", "สัตว์จำพวกนก", 1,0,0,1,0,1,0,0,0);           
                        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            check_Prop();
            distances = new double[category.Count];
            for (int i = 0; i < category.Count; i++)
            {
              category[i].dis = Math.Sqrt(Math.Pow(myProp[0] - category[i].PROP_1, 2)
                                        + Math.Pow(myProp[1] - category[i].PROP_2, 2)
                                        + Math.Pow(myProp[2] - category[i].PROP_3, 2) 
                                        + Math.Pow(myProp[3] - category[i].PROP_4, 2)
                                        + Math.Pow(myProp[4] - category[i].PROP_5, 2) 
                                        + Math.Pow(myProp[5] - category[i].PROP_6, 2)
                                        + Math.Pow(myProp[6] - category[i].PROP_7, 2)
                                        + Math.Pow(myProp[7] - category[i].PROP_8, 2)
                                        + Math.Pow(myProp[8] - category[i].PROP_9, 2));
                distances[i] = category[i].dis;
            }
            string result = "";
            int jj = 1;
            foreach(animals n in category){
                result += "d"+jj+" = "+String.Format
                    ("{0:0.000}",n.dis)+" สายพันธ์"+n.Species+"\r\n";
                jj++;
            }
            Array.Sort(distances);
            double minDistance = distances[0];
            for (int ii = 0; ii < category.Count;ii++ )
            {
                if (category[ii].dis == minDistance)
                {
                    result += "สรุปได้ว่าสัตว์ปริศนาชนิดนี้มีสายพันธุ์เป็น\r\n"+category[ii].Species;
                    break;
                }
            }
            MessageBox.Show(result,"สายพันธุ์ของสัตว์ปริศนา");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            check_Prop();
            distances = new double[category.Count];
            for (int i = 0; i < category.Count; i++)
            {
              category[i].dis = Math.Sqrt(Math.Pow(myProp[0] - category[i].PROP_1, 2)
                                        + Math.Pow(myProp[1] - category[i].PROP_2, 2)
                                        + Math.Pow(myProp[2] - category[i].PROP_3, 2)
                                        + Math.Pow(myProp[3] - category[i].PROP_4, 2)
                                        + Math.Pow(myProp[4] - category[i].PROP_5, 2)
                                        + Math.Pow(myProp[5] - category[i].PROP_6, 2)
                                        + Math.Pow(myProp[6] - category[i].PROP_7, 2)
                                        + Math.Pow(myProp[7] - category[i].PROP_8, 2)
                                        + Math.Pow(myProp[8] - category[i].PROP_9, 2));
                distances[i] = category[i].dis;
            }
            string result = "";
            int jj = 1;
            foreach (animals n in category)
            {
                result += "d" + jj + " = " + String.Format
                    ("{0:0.000}", n.dis) + " สายพันธ์" + n.Species + "\r\n";
                jj++;
            }
            Array.Sort(distances);                   
            string[] species = new string[3];
            int index = 0;
            for (int ii = 0; ii < distances.Length;ii++ )
            {
                if (distances[0] == category[ii].dis || 
                    distances[1] == category[ii].dis || 
                    distances[2] == category[ii].dis)
                {
                    species[index] = category[ii].Species;
                    index++;
                }
                if (index > 2) break;
            }                   
            result += "สรุปได้ว่าสัตว์ปริศนาชนิดนี้มีสายพันธุ์เป็น \r\n"+checkSpecies(species);
            MessageBox.Show(result, "สรุปสายพันธุ์ปริศนา");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {          
            this.MaximumSize = new System.Drawing.Size(1085, 600);
            this.MinimumSize = new System.Drawing.Size(1085, 600);            
            this.create_bn.Enabled = false;
        }

        private void add_bn_Click(object sender, EventArgs e)
        {
            if (type_tv.Text != "" && species_tv.Text != "")
            {
                if (add_1.Checked == true)
                    myProp[0] = 1;
                else
                    myProp[0] = 0;
                if (add_2.Checked == true)
                    myProp[1] = 1;
                else
                    myProp[1] = 0;
                if (add_3.Checked == true)
                    myProp[2] = 1;
                else
                    myProp[2] = 0;
                if (add_4.Checked == true)
                    myProp[3] = 1;
                else
                    myProp[3] = 0;
                if (add_5.Checked == true)
                    myProp[4] = 1;
                else
                    myProp[4] = 0;
                if (add_6.Checked == true)
                    myProp[5] = 1;
                else
                    myProp[5] = 0;
                if (add_7.Checked == true)
                    myProp[6] = 1;
                else
                    myProp[6] = 0;
                if (add_8.Checked == true)
                    myProp[7] = 1;
                else
                    myProp[7] = 0;
                if (add_9.Checked == true)
                    myProp[8] = 1;
                else
                    myProp[8] = 0;

                string tname = type_tv.Text;
                string sname = species_tv.Text;
                if (MessageBox.Show("ยืนยันการเพิ่มข้อมูลสัตว์", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    assign_Prop(new animals(), tname, sname, myProp[0],
                                myProp[1], myProp[2], myProp[3], myProp[4],
                                myProp[5], myProp[6], myProp[7], myProp[8]);
                    type_tv.Text = "";
                    species_tv.Text = "";
                    add_1.Checked = false; 
                    add_2.Checked = false; 
                    add_3.Checked = false;
                    add_4.Checked = false;
                    add_5.Checked = false;
                    add_6.Checked = false;
                    add_7.Checked = false;
                    add_8.Checked = false;
                    add_9.Checked = false;
                    this.MaximumSize = new System.Drawing.Size(1085, 400);
                    this.MinimumSize = new System.Drawing.Size(1085, 400);
                    this.create_bn.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Enter textbox please !!!","Warning");
            }
        }

        private void cancel_bn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ยกเลิกการเพิ่มข้อมูลสัตว์", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                type_tv.Text = "";
                species_tv.Text = "";
                add_1.Checked = false;
                add_2.Checked = false;
                add_3.Checked = false;
                add_4.Checked = false;
                add_5.Checked = false;
                add_6.Checked = false;
                add_7.Checked = false; 
                add_8.Checked = false; 
                add_9.Checked = false;
                this.MaximumSize = new System.Drawing.Size(1085, 400);
                this.MinimumSize = new System.Drawing.Size(1085, 400);
                this.create_bn.Enabled = true;
            }
        }
      
       
    }
}
