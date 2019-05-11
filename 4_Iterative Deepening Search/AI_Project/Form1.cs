using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AI_Project
{
    public partial class Form1 : Form
    {
        private int Limit = 0, Time = 1000, Step = 0;
        private string Node = "A";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox_Node.SelectedIndex = 0;
            Button_Speed2.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Interval = Time;
            ++Step;
            TextBox_Limit.Text = Limit.ToString();
            if (Step == 1)
            {
                Line_Level0.Visible = true;
                Line_Level1.Visible = false;
                Line_Level2.Visible = false;
                Line_Level3.Visible = false;
            }
            if (Step == 2)
            {
                Label_pA.Visible = true;
                Node_A.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 3)
            {
                if (Node == "A")
                {
                    NodeFounded(Node);
                }
                else
                {
                    Node_A.FillColor = System.Drawing.Color.Black;
                    Label_A.BackColor = System.Drawing.Color.Black;
                    Label_A.ForeColor = System.Drawing.Color.Black;
                    Limit++;
                }
                Label_pA.Visible = false;
            }
            if (Step == 4)
            {
                ClearAll();
                Line_Level0.Visible = false;
                Line_Level1.Visible = true;
                Line_Level2.Visible = false;
                Line_Level3.Visible = false;
            }
            if (Step == 5)
            {
                Label_pA.Visible = true;
                Node_A.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 6)
            {
                Node_A.FillColor = System.Drawing.Color.DarkGray;
                Label_A.BackColor = System.Drawing.Color.DarkGray;
                Label_A.ForeColor = System.Drawing.Color.Black;
                Label_pA.Visible = false;
                Node_A.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                Line_AB.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                Line_AC.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 7)
            {
                Label_pB.Visible = true;
                Node_B.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 8)
            {
                if (Node == "B")
                {
                    NodeFounded(Node);
                }
                else
                {
                    Node_B.FillColor = System.Drawing.Color.Black;
                    Label_B.BackColor = System.Drawing.Color.Black;
                    Label_B.ForeColor = System.Drawing.Color.Black;
                }
                Label_pB.Visible = false;
            }
            if (Step == 9)
            {
                Label_pC.Visible = true;
                Node_C.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 10)
            {
                if (Node == "C")
                {
                    NodeFounded(Node);
                }
                else
                {
                    Node_A.FillColor = System.Drawing.Color.Black;
                    Label_A.BackColor = System.Drawing.Color.Black;
                    Label_A.ForeColor = System.Drawing.Color.Black;
                    Node_C.FillColor = System.Drawing.Color.Black;
                    Label_C.BackColor = System.Drawing.Color.Black;
                    Label_C.ForeColor = System.Drawing.Color.Black;
                    Limit++;
                }
                Label_pC.Visible = false;
            }
            if (Step == 11)
            {
                ClearAll();

                Line_Level0.Visible = false;
                Line_Level1.Visible = false;
                Line_Level2.Visible = true;
                Line_Level3.Visible = false;
            }
            if (Step == 12)
            {
                Label_pA.Visible = true;
                Node_A.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 13)
            {
                Node_A.FillColor = System.Drawing.Color.DarkGray;
                Label_A.BackColor = System.Drawing.Color.DarkGray;
                Label_A.ForeColor = System.Drawing.Color.Black;
                Label_pA.Visible = false;
                Line_AB.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                Line_AC.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 14)
            {
                Label_pB.Visible = true;
                Node_B.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 15)
            {
                Node_B.FillColor = System.Drawing.Color.DarkGray;
                Label_B.BackColor = System.Drawing.Color.DarkGray;
                Label_B.ForeColor = System.Drawing.Color.Black;
                Label_pB.Visible = false;
                Line_BD.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                Line_BE.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 16)
            {
                Label_pD.Visible = true;
                Node_D.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 17)
            {
                if (Node == "D")
                {
                    NodeFounded(Node);
                }
                else
                {
                    Node_D.FillColor = System.Drawing.Color.Black;
                    Label_D.BackColor = System.Drawing.Color.Black;
                    Label_D.ForeColor = System.Drawing.Color.Black;
                }
                Label_pD.Visible = false;
            }
            if (Step == 18)
            {
                Label_pE.Visible = true;
                Node_E.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 19)
            {
                if (Node == "E")
                {
                    NodeFounded(Node);
                }
                else
                {
                    Node_B.FillColor = System.Drawing.Color.Black;
                    Label_B.BackColor = System.Drawing.Color.Black;
                    Label_B.ForeColor = System.Drawing.Color.Black;
                    Node_E.FillColor = System.Drawing.Color.Black;
                    Label_E.BackColor = System.Drawing.Color.Black;
                    Label_E.ForeColor = System.Drawing.Color.Black;
                }
                Label_pE.Visible = false;
            }
            if (Step == 20)
            {
                Label_pC.Visible = true;
                Node_C.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 21)
            {
                Node_C.FillColor = System.Drawing.Color.DarkGray;
                Label_C.BackColor = System.Drawing.Color.DarkGray;
                Label_C.ForeColor = System.Drawing.Color.Black;
                Label_pC.Visible = false;
                Line_CF.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                Line_CG.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 22)
            {
                Label_pF.Visible = true;
                Node_F.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 23)
            {
                if (Node == "F")
                {
                    NodeFounded(Node);
                }
                else
                {
                    Node_F.FillColor = System.Drawing.Color.Black;
                    Label_F.BackColor = System.Drawing.Color.Black;
                    Label_F.ForeColor = System.Drawing.Color.Black;
                }
                Label_pF.Visible = false;
            }
            if (Step == 24)
            {
                Label_pG.Visible = true;
                Node_G.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 25)
            {
                if (Node == "G")
                {
                    NodeFounded(Node);
                }
                else
                {
                    Node_A.FillColor = System.Drawing.Color.Black;
                    Label_A.BackColor = System.Drawing.Color.Black;
                    Label_A.ForeColor = System.Drawing.Color.Black;
                    Node_C.FillColor = System.Drawing.Color.Black;
                    Label_C.BackColor = System.Drawing.Color.Black;
                    Label_C.ForeColor = System.Drawing.Color.Black;
                    Node_G.FillColor = System.Drawing.Color.Black;
                    Label_G.BackColor = System.Drawing.Color.Black;
                    Label_G.ForeColor = System.Drawing.Color.Black;
                    Limit++;
                }
                Label_pG.Visible = false;
            }
            if (Step == 26)
            {
                ClearAll();
                Line_Level0.Visible = false;
                Line_Level1.Visible = false;
                Line_Level2.Visible = false;
                Line_Level3.Visible = true;
            }
            if (Step == 27)
            {
                Label_pA.Visible = true;
                Node_A.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 28)
            {
                Node_A.FillColor = System.Drawing.Color.DarkGray;
                Label_A.BackColor = System.Drawing.Color.DarkGray;
                Label_A.ForeColor = System.Drawing.Color.Black;
                Label_pA.Visible = false;
                Line_AB.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                Line_AC.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 29)
            {
                Label_pB.Visible = true;
                Node_B.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 30)
            {
                Node_B.FillColor = System.Drawing.Color.DarkGray;
                Label_B.BackColor = System.Drawing.Color.DarkGray;
                Label_B.ForeColor = System.Drawing.Color.Black;
                Label_pB.Visible = false;
                Line_BD.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                Line_BE.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 31)
            {
                Label_pD.Visible = true;
                Node_D.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 32)
            {
                Node_D.FillColor = System.Drawing.Color.DarkGray;
                Label_D.BackColor = System.Drawing.Color.DarkGray;
                Label_D.ForeColor = System.Drawing.Color.Black;
                Label_pD.Visible = false;
                Line_DH.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                Line_DI.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 33)
            {
                Label_pH.Visible = true;
                Node_H.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 34)
            {
                if (Node == "H")
                {
                    NodeFounded(Node);
                }
                else
                {
                    Node_H.FillColor = System.Drawing.Color.Black;
                    Label_H.BackColor = System.Drawing.Color.Black;
                    Label_H.ForeColor = System.Drawing.Color.Black;
                }
                Label_pH.Visible = false;
            }
            if (Step == 35)
            {
                Label_pI.Visible = true;
                Node_I.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 36)
            {
                if (Node == "I")
                {
                    NodeFounded(Node);
                }
                else
                {
                    Node_D.FillColor = System.Drawing.Color.Black;
                    Label_D.BackColor = System.Drawing.Color.Black;
                    Label_D.ForeColor = System.Drawing.Color.Black;
                    Node_I.FillColor = System.Drawing.Color.Black;
                    Label_I.BackColor = System.Drawing.Color.Black;
                    Label_I.ForeColor = System.Drawing.Color.Black;
                }
                Label_pI.Visible = false;
            }
            if (Step == 37)
            {
                Label_pE.Visible = true;
                Node_E.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 38)
            {
                Node_E.FillColor = System.Drawing.Color.DarkGray;
                Label_E.BackColor = System.Drawing.Color.DarkGray;
                Label_E.ForeColor = System.Drawing.Color.Black;
                Label_pE.Visible = false;
                Line_EJ.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                Line_EK.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 39)
            {
                Label_pJ.Visible = true;
                Node_J.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 40)
            {
                if (Node == "J")
                {
                    NodeFounded(Node);
                }
                else
                {
                    Node_J.FillColor = System.Drawing.Color.Black;
                    Label_J.BackColor = System.Drawing.Color.Black;
                    Label_J.ForeColor = System.Drawing.Color.Black;
                }
                Label_pJ.Visible = false;
            }
            if (Step == 41)
            {
                Label_pK.Visible = true;
                Node_K.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 42)
            {
                if (Node == "K")
                {
                    NodeFounded(Node);
                }
                else
                {
                    Node_B.FillColor = System.Drawing.Color.Black;
                    Label_B.BackColor = System.Drawing.Color.Black;
                    Label_B.ForeColor = System.Drawing.Color.Black;
                    Node_E.FillColor = System.Drawing.Color.Black;
                    Label_E.BackColor = System.Drawing.Color.Black;
                    Label_E.ForeColor = System.Drawing.Color.Black;
                    Node_K.FillColor = System.Drawing.Color.Black;
                    Label_K.BackColor = System.Drawing.Color.Black;
                    Label_K.ForeColor = System.Drawing.Color.Black;
                }
                Label_pK.Visible = false;
            }
            if (Step == 43)
            {
                Label_pC.Visible = true;
                Node_C.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 44)
            {
                Node_C.FillColor = System.Drawing.Color.DarkGray;
                Label_C.BackColor = System.Drawing.Color.DarkGray;
                Label_C.ForeColor = System.Drawing.Color.Black;
                Label_pC.Visible = false;
                Line_CF.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                Line_CG.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 45)
            {
                Label_pF.Visible = true;
                Node_F.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 46)
            {
                Node_F.FillColor = System.Drawing.Color.DarkGray;
                Label_F.BackColor = System.Drawing.Color.DarkGray;
                Label_F.ForeColor = System.Drawing.Color.Black;
                Label_pF.Visible = false;
                Line_FL.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                Line_FM.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 47)
            {
                Label_pL.Visible = true;
                Node_L.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 48)
            {
                if (Node == "L")
                {
                    NodeFounded(Node);
                }
                else
                {
                    Node_L.FillColor = System.Drawing.Color.Black;
                    Label_L.BackColor = System.Drawing.Color.Black;
                    Label_L.ForeColor = System.Drawing.Color.Black;
                }
                Label_pL.Visible = false;
            }
            if (Step == 49)
            {
                Label_pM.Visible = true;
                Node_M.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 50)
            {
                if (Node == "M")
                {
                    NodeFounded(Node);
                }
                else
                {
                    Node_F.FillColor = System.Drawing.Color.Black;
                    Label_F.BackColor = System.Drawing.Color.Black;
                    Label_F.ForeColor = System.Drawing.Color.Black;
                    Node_M.FillColor = System.Drawing.Color.Black;
                    Label_M.BackColor = System.Drawing.Color.Black;
                    Label_M.ForeColor = System.Drawing.Color.Black;
                }
                Label_pM.Visible = false;
            }
            if (Step == 51)
            {
                Label_pG.Visible = true;
                Node_G.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 52)
            {
                Node_G.FillColor = System.Drawing.Color.DarkGray;
                Label_G.BackColor = System.Drawing.Color.DarkGray;
                Label_G.ForeColor = System.Drawing.Color.Black;
                Label_pG.Visible = false;
                Line_GN.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                Line_GO.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 53)
            {
                Label_pN.Visible = true;
                Node_N.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 54)
            {
                if (Node == "N")
                {
                    NodeFounded(Node);
                }
                else
                {
                    Node_N.FillColor = System.Drawing.Color.Black;
                    Label_N.BackColor = System.Drawing.Color.Black;
                    Label_N.ForeColor = System.Drawing.Color.Black;
                }
                Label_pN.Visible = false;
            }
            if (Step == 55)
            {
                Label_pO.Visible = true;
                Node_O.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            if (Step == 56)
            {
                if (Node == "O")
                {
                    NodeFounded(Node);
                }
                Label_pO.Visible = false;
            }
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true;
            Button_Search.Enabled = false;
            ComboBox_Node.Enabled = false;
            switch (ComboBox_Node.SelectedItem.ToString())
            {
                case "A":
                    Node = "A";
                    break;
                case "B":
                    Node = "B";
                    break;
                case "C":
                    Node = "C";
                    break;
                case "D":
                    Node = "D";
                    break;
                case "E":
                    Node = "E";
                    break;
                case "F":
                    Node = "F";
                    break;
                case "G":
                    Node = "G";
                    break;
                case "H":
                    Node = "H";
                    break;
                case "I":
                    Node = "I";
                    break;
                case "J":
                    Node = "J";
                    break;
                case "K":
                    Node = "K";
                    break;
                case "L":
                    Node = "L";
                    break;
                case "M":
                    Node = "M";
                    break;
                case "N":
                    Node = "N";
                    break;
                case "O":
                    Node = "O";
                    break;
            }
        }

        private void ClearAll()
        {
            Node_A.FillColor = System.Drawing.Color.White;
            Label_A.BackColor = System.Drawing.Color.White;
            Label_A.ForeColor = System.Drawing.Color.Black;
            Node_B.FillColor = System.Drawing.Color.White;
            Label_B.BackColor = System.Drawing.Color.White;
            Label_B.ForeColor = System.Drawing.Color.Black;
            Node_C.FillColor = System.Drawing.Color.White;
            Label_C.BackColor = System.Drawing.Color.White;
            Label_C.ForeColor = System.Drawing.Color.Black;
            Node_D.FillColor = System.Drawing.Color.White;
            Label_D.BackColor = System.Drawing.Color.White;
            Label_D.ForeColor = System.Drawing.Color.Black;
            Node_E.FillColor = System.Drawing.Color.White;
            Label_E.BackColor = System.Drawing.Color.White;
            Label_E.ForeColor = System.Drawing.Color.Black;
            Node_F.FillColor = System.Drawing.Color.White;
            Label_F.BackColor = System.Drawing.Color.White;
            Label_F.ForeColor = System.Drawing.Color.Black;
            Node_G.FillColor = System.Drawing.Color.White;
            Label_G.BackColor = System.Drawing.Color.White;
            Label_G.ForeColor = System.Drawing.Color.Black;
            Node_H.FillColor = System.Drawing.Color.White;
            Label_H.BackColor = System.Drawing.Color.White;
            Label_H.ForeColor = System.Drawing.Color.Black;
            Node_I.FillColor = System.Drawing.Color.White;
            Label_I.BackColor = System.Drawing.Color.White;
            Label_I.ForeColor = System.Drawing.Color.Black;
            Node_J.FillColor = System.Drawing.Color.White;
            Label_J.BackColor = System.Drawing.Color.White;
            Label_J.ForeColor = System.Drawing.Color.Black;
            Node_K.FillColor = System.Drawing.Color.White;
            Label_K.BackColor = System.Drawing.Color.White;
            Label_K.ForeColor = System.Drawing.Color.Black;
            Node_L.FillColor = System.Drawing.Color.White;
            Label_L.BackColor = System.Drawing.Color.White;
            Label_L.ForeColor = System.Drawing.Color.Black;
            Node_M.FillColor = System.Drawing.Color.White;
            Label_M.BackColor = System.Drawing.Color.White;
            Label_M.ForeColor = System.Drawing.Color.Black;
            Node_N.FillColor = System.Drawing.Color.White;
            Label_N.BackColor = System.Drawing.Color.White;
            Label_N.ForeColor = System.Drawing.Color.Black;
            Node_O.FillColor = System.Drawing.Color.White;
            Label_O.BackColor = System.Drawing.Color.White;
            Label_O.ForeColor = System.Drawing.Color.Black;
            Node_A.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Node_B.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Node_C.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Node_D.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Node_E.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Node_F.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Node_G.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Node_H.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Node_I.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Node_J.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Node_K.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Node_L.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Node_M.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Node_N.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Node_O.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Line_AB.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Line_AC.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Line_BD.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Line_BE.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Line_CF.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Line_CG.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Line_DH.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Line_DI.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Line_EJ.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Line_EK.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Line_FL.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Line_FM.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Line_GN.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Line_GO.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Line_Level0.Visible = false;
            Line_Level1.Visible = false;
            Line_Level2.Visible = false;
            Line_Level3.Visible = false;
        }

        private void SearchAgain()
        {
            Step = 0;
            Limit = 0;
            TextBox_Limit.Text = Limit.ToString();
            ComboBox_Node.SelectedIndex = 0;
            Button_Search.Enabled = true;
            ComboBox_Node.Enabled = true;
        }

        private void Button_Speed1_Click(object sender, EventArgs e)
        {
            Time = 2000;
            Button_Speed1.Enabled = false;
            Button_Speed2.Enabled = true;
            Button_Speed3.Enabled = true;
            Button_Speed4.Enabled = true;

        }

        private void Button_Speed2_Click(object sender, EventArgs e)
        {
            Time = 1000;
            Button_Speed1.Enabled = true;
            Button_Speed2.Enabled = false;
            Button_Speed3.Enabled = true;
            Button_Speed4.Enabled = true;
        }

        private void Button_Speed3_Click(object sender, EventArgs e)
        {
            Time = 500;
            Button_Speed1.Enabled = true;
            Button_Speed2.Enabled = true;
            Button_Speed3.Enabled = false;
            Button_Speed4.Enabled = true;
        }

        private void Button_Speed4_Click(object sender, EventArgs e)
        {
            Time = 250;
            Button_Speed1.Enabled = true;
            Button_Speed2.Enabled = true;
            Button_Speed3.Enabled = true;
            Button_Speed4.Enabled = false;
        }

        public void NodeFounded(string Node)
        {
            Timer.Enabled = false;
            if (MessageBox.Show("ค้นหาโหนด " + Node + " พบแล้ว คุณต้องการค้นหาโหนดอื่นหรือไม่?", "ในที่สุด...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearAll();
                SearchAgain();
            }
            else
            {
                this.Close();
            }
        }
    }
}

