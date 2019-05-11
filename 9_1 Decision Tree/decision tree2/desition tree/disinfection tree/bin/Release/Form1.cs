using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accord.Controls;
using Accord.Math;
using Accord.Statistics.Kernels;
using Accord.Statistics.Filters;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.MachineLearning.Structures;
using AForge;
using TreeGenerator;
using System.Xml;
namespace disinfection_tree
{
    public partial class Form1 : Form
    {
        TreeBuilder myTree = null;
        int day = 1, c1, c2, c3, c4,c5;
        int row = 0;
        String[] n1,bn1;
        String[] n2,bn2;
        String[] n3,bn3;
        String[] n4,bn4;
        String[] n5,bn5;
        DataTable data;
        DecisionTree tree;
        int[][] inputs;
        int[] outputs;
        Codification codebook;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox4.Enabled = false;
            groupBox1.Enabled = false;
            data = new DataTable("Tennis");
            label10.Text = "";
            data.Columns.Add("Day");
            data.Columns.Add("Outlook");
            data.Columns.Add("Temp");
            data.Columns.Add("Humid");
            data.Columns.Add("Wind");
            data.Columns.Add("Tennis");

           data.Rows.Add("1", "Sunny", "Hot", "High", "Light", "No");
           data.Rows.Add("2", "Sunny", "Hot", "High", "Strong", "No");
           data.Rows.Add("3", "Overcast", "Hot", "High", "Light", "Yes");
           data.Rows.Add("4", "Rain", "Mild", "High", "Light", "Yes");
           data.Rows.Add("5", "Rain", "Cool", "Normal", "Light", "Yes");
           data.Rows.Add("6", "Rain", "Cool", "Normal", "Strong", "No");
           data.Rows.Add("7", "Overcast", "Cool", "Normal", "Strong", "Yes");
           data.Rows.Add("8", "Sunny", "Mild", "High", "Light", "No");
           data.Rows.Add("9", "Sunny", "Cool", "Normal", "Light", "Yes");
           data.Rows.Add("10", "Rain", "Mild", "Normal", "Light", "Yes");
           data.Rows.Add("11", "Sunny", "Mild", "Normal", "Strong", "Yes");
           data.Rows.Add("12", "Overcast", "Mild", "High", "Strong", "Yes");
           data.Rows.Add("13", "Overcast", "Hot", "Normal", "Light", "Yes");
           data.Rows.Add("14", "Rain", "Mild", "High", "Strong", "No");

            
            dataGridView1.DataSource = data;
            sty();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            c1 = 0; c2 = 0; c3 = 0; c4 = 0; c5 = 0;
            groupBox4.Enabled = true;
            codebook = new Codification(data);


            DataTable symbols = codebook.Apply(data);
            inputs = symbols.ToArray<int>("Outlook", "Temp", "Humid", "Wind");
            outputs = symbols.ToArray<int>("Tennis");

            row = dataGridView1.RowCount;
            n1 = new String[row];
            n2 = new String[row];
            n3 = new String[row];
            n4 = new String[row];
            n5 = new String[row];

            for (int i = 0; i < row; i++)
            { 
                n1[i] = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                n2[i] = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                n3[i] = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                n4[i] = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                n5[i] = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);
            }


            bn1 = n1.Distinct();
            bn2 = n2.Distinct();
            bn3 = n3.Distinct();
            bn4 = n4.Distinct();
            bn5 = n5.Distinct();

            foreach (String i in bn1)
            {
                c1 = c1 + 1;
            }
            foreach (String i in bn2)
            {
                c2 = c2 + 1;
                
            }
            foreach (String i in bn3)
            {
                c3 = c3 + 1;
            }
            foreach (String i in bn4)
            {
                c4 = c4 + 1;
            }
            foreach (String i in bn5)
            {
                c5 = c5 + 1;
            }

     
            DecisionVariable[] attributes =
            {
                new DecisionVariable("Outlook",3), 
                new DecisionVariable("Temp", 3),   
                new DecisionVariable("Humid",2),   
                new DecisionVariable("Wind",2)  
            };

            int classCount = 2;

            tree = new DecisionTree(attributes, classCount);
            ID3Learning id3learning = new ID3Learning(tree);
            id3learning.Run(inputs, outputs);
            inputs = null;
            outputs = null;


            myTree = new TreeBuilder(GetTreeData());
            myTree.BoxHeight = 30;
            myTree.BoxWidth = 90;
            myTree.VerticalSpace = 60;
            pict.Image = Image.FromStream(myTree.GenerateTree(-1, -1, "1", System.Drawing.Imaging.ImageFormat.Bmp));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label10.Text = "";
            data.Rows.Add(Convert.ToString(day), comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text);
            day = day + 1;
            dataGridView1.DataSource = data;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox4.Enabled = false;
                label10.Text = "";
                day = 1;
                label10.Text = "";
                groupBox1.Enabled = true;
                data.Clear();
                inputs = null;
                outputs = null;
                sty();
                pict.Image = null;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox4.Enabled = false;
                label10.Text = "";
                data.Clear();
                inputs = null;
                outputs = null;
                groupBox1.Enabled = false;
                data.Rows.Add("1", "Sunny", "Hot", "High", "Light", "No");
                data.Rows.Add("2", "Sunny", "Hot", "High", "Strong", "No");
                data.Rows.Add("3", "Overcast", "Hot", "High", "Light", "Yes");
                data.Rows.Add("4", "Rain", "Mild", "High", "Light", "Yes");
                data.Rows.Add("5", "Rain", "Cool", "Normal", "Light", "Yes");
                data.Rows.Add("6", "Rain", "Cool", "Normal", "Strong", "No");
                data.Rows.Add("7", "Overcast", "Cool", "Normal", "Strong", "Yes");
                data.Rows.Add("8", "Sunny", "Mild", "High", "Light", "No");
                data.Rows.Add("9", "Sunny", "Cool", "Normal", "Light", "Yes");
                data.Rows.Add("10", "Rain", "Mild", "Normal", "Light", "Yes");
                data.Rows.Add("11", "Sunny", "Mild", "Normal", "Strong", "Yes");
                data.Rows.Add("12", "Overcast", "Mild", "High", "Strong", "Yes");
                data.Rows.Add("13", "Overcast", "Hot", "Normal", "Light", "Yes");
                data.Rows.Add("14", "Rain", "Mild", "High", "Strong", "No");
                pict.Image = null;
                sty();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string answer = codebook.Translate("Tennis",
            tree.Compute(codebook.Translate(comboBox6.Text, comboBox7.Text, comboBox8.Text, comboBox9.Text)));
            label10.Text = answer;
        }



        private TreeData.TreeDataTableDataTable GetTreeData()
        {
            int ct = 1,cn=0,lv=0;
            String root;
            String[] roots;
            root = Convert.ToString(tree.Root.Branches[0]);
            roots=root.Split(' ');
            cn = tree.Root.Branches.Count;
            TreeData.TreeDataTableDataTable dt = new TreeData.TreeDataTableDataTable();
            dt.AddTreeDataTableRow(Convert.ToString(ct), "", "Root", roots[0]);
            lv = 1;
            for(int i=0;i<cn;i++){
            ct=ct+1;
            if(roots[0]=="Outlook")
            {
                lv = 1;
                if (tree.Root.Branches[i].IsLeaf == false)
                {
                    
                    String node = Convert.ToString(tree.Root.Branches[i].Branches[0]);
                    String[] nodes = node.Split(' ');
                    dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn1[i], nodes[0]);
                    lv = ct;
                    int cn2 = tree.Root.Branches[i].Branches.Count;
                    for (int j = 0; j < cn2; j++)
                    {
                        ct = ct + 1;
                        if (nodes[0] == "Outlook")
                        {
                            if (tree.Root.Branches[i].Branches[j].IsLeaf == true)
                            {
                                int oo1 = tree.Root.Branches[i].Branches[j].Output.Value;
                                dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn1[j], bn5[oo1]);
                            }
                        }
                        else if (nodes[0] == "Temp")
                        {
                            if (tree.Root.Branches[i].Branches[j].IsLeaf == true)
                            {
                                int oo1 = tree.Root.Branches[i].Branches[j].Output.Value;
                                dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn2[j], bn5[oo1]);
                            }
                        }
                        else if (nodes[0] == "Humid")
                        {
                            if (tree.Root.Branches[i].Branches[j].IsLeaf == true)
                            {
                                int oo1 = tree.Root.Branches[i].Branches[j].Output.Value;
                                dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn3[j], bn5[oo1]);
                            }
                        }
                        else if (nodes[0] == "Wind")
                        {
                            if (tree.Root.Branches[i].Branches[j].IsLeaf == true)
                            {
                                int oo1 = tree.Root.Branches[i].Branches[j].Output.Value;
                                dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn4[j], bn5[oo1]);
                            }
                        }
                    }
                }
                else
                {
                    int oo=tree.Root.Branches[i].Output.Value;
                    dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn1[i], bn5[oo]);
                }
            }
            else if (roots[0] == "Temp")
            {
                lv = 1;
                if (tree.Root.Branches[i].IsLeaf == false)
                {

                    String node = Convert.ToString(tree.Root.Branches[i].Branches[0]);
                    String[] nodes = node.Split(' ');
                    dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn2[i], nodes[0]);
                    lv = ct;
                    int cn2 = tree.Root.Branches[i].Branches.Count;
                    for (int j = 0; j < cn2; j++)
                    {
                        ct = ct + 1;
                        if (nodes[0] == "Outlook")
                        {
                            if (tree.Root.Branches[i].Branches[j].IsLeaf == true)
                            {
                                int oo1 = tree.Root.Branches[i].Branches[j].Output.Value;
                                dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn1[j], bn5[oo1]);
                            }
                        }
                        else if (nodes[0] == "Temp")
                        {
                            if (tree.Root.Branches[i].Branches[j].IsLeaf == true)
                            {
                                int oo1 = tree.Root.Branches[i].Branches[j].Output.Value;
                                dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn2[j], bn5[oo1]);
                            }
                        }
                        else if (nodes[0] == "Humid")
                        {
                            if (tree.Root.Branches[i].Branches[j].IsLeaf == true)
                            {
                                int oo1 = tree.Root.Branches[i].Branches[j].Output.Value;
                                dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn3[j], bn5[oo1]);
                            }
                        }
                        else if (nodes[0] == "Wind")
                        {
                            if (tree.Root.Branches[i].Branches[j].IsLeaf == true)
                            {
                                int oo1 = tree.Root.Branches[i].Branches[j].Output.Value;
                                dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn4[j], bn5[oo1]);
                            }
                        }
                    }
                }
                else
                {
                    int oo = tree.Root.Branches[i].Output.Value;
                    dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn2[i], bn5[oo]);
                }
            }
            else if (roots[0] == "Humid")
            {
                lv = 1;
                if (tree.Root.Branches[i].IsLeaf == false)
                {

                    String node = Convert.ToString(tree.Root.Branches[i].Branches[0]);
                    String[] nodes = node.Split(' ');
                    dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn3[i], nodes[0]);
                    lv = ct;
                    int cn2 = tree.Root.Branches[i].Branches.Count;
                    for (int j = 0; j < cn2; j++)
                    {
                        ct = ct + 1;
                        if (nodes[0] == "Outlook")
                        {
                            if (tree.Root.Branches[i].Branches[j].IsLeaf == true)
                            {
                                int oo1 = tree.Root.Branches[i].Branches[j].Output.Value;
                                dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn1[j], bn5[oo1]);
                            }
                        }
                        else if (nodes[0] == "Temp")
                        {
                            if (tree.Root.Branches[i].Branches[j].IsLeaf == true)
                            {
                                int oo1 = tree.Root.Branches[i].Branches[j].Output.Value;
                                dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn2[j], bn5[oo1]);
                            }
                        }
                        else if (nodes[0] == "Humid")
                        {
                            if (tree.Root.Branches[i].Branches[j].IsLeaf == true)
                            {
                                int oo1 = tree.Root.Branches[i].Branches[j].Output.Value;
                                dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn3[j], bn5[oo1]);
                            }
                        }
                        else if (nodes[0] == "Wind")
                        {
                            if (tree.Root.Branches[i].Branches[j].IsLeaf == true)
                            {
                                int oo1 = tree.Root.Branches[i].Branches[j].Output.Value;
                                dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn4[j], bn5[oo1]);
                            }
                        }
                    }
                }
                else
                {
                    int oo = tree.Root.Branches[i].Output.Value;
                    dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn3[i], bn5[oo]);
                }
            }
            else if (roots[0] == "Wind")
            {
                lv = 1;
                if (tree.Root.Branches[i].IsLeaf == false)
                {

                    String node = Convert.ToString(tree.Root.Branches[i].Branches[0]);
                    String[] nodes = node.Split(' ');
                    dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn4[i], nodes[0]);
                    lv = ct;
                    int cn2 = tree.Root.Branches[i].Branches.Count;
                    for (int j = 0; j < cn2; j++)
                    {
                        ct = ct + 1;
                        if (nodes[0] == "Outlook")
                        {
                            if (tree.Root.Branches[i].Branches[j].IsLeaf == true)
                            {
                                int oo1 = tree.Root.Branches[i].Branches[j].Output.Value;
                                dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn1[j], bn5[oo1]);
                            }
                        }
                        else if (nodes[0] == "Temp")
                        {
                            if (tree.Root.Branches[i].Branches[j].IsLeaf == true)
                            {
                                int oo1 = tree.Root.Branches[i].Branches[j].Output.Value;
                                dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn2[j], bn5[oo1]);
                            }
                        }
                        else if (nodes[0] == "Humid")
                        {
                            if (tree.Root.Branches[i].Branches[j].IsLeaf == true)
                            {
                                int oo1 = tree.Root.Branches[i].Branches[j].Output.Value;
                                dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn3[j], bn5[oo1]);
                            }
                        }
                        else if (nodes[0] == "Wind")
                        {
                            if (tree.Root.Branches[i].Branches[j].IsLeaf == true)
                            {
                                int oo1 = tree.Root.Branches[i].Branches[j].Output.Value;
                                dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn4[j], bn5[oo1]);
                            }
                        }
                    }
                }
                else
                {
                    int oo = tree.Root.Branches[i].Output.Value;
                    dt.AddTreeDataTableRow(Convert.ToString(ct), Convert.ToString(lv), bn4[i], bn5[oo]);
                }
            }
            }



            return dt;
        }


        public void sty()
        {

            dataGridView1.Columns[0].HeaderText = "Day";
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderText = "Outlook";
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderText = "Temp";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderText = "Humid";
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderText = "Wind";
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].HeaderText = "Tennis";
            dataGridView1.Columns[5].Width = 70;
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }


    }
}
