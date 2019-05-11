using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Breadth_First_Search
{
    public partial class Form1 : Form
    {
        int l = 0;
        int b = 0;

        public Form1()
        {
            InitializeComponent();
            pa1.BorderColor = Color.MintCream;  pa2.BorderColor = Color.MintCream;  pa3.BorderColor = Color.MintCream;
            pb1.BorderColor = Color.MintCream;  pb2.BorderColor = Color.MintCream;  pb3.BorderColor = Color.MintCream;
            pc1.BorderColor = Color.MintCream;  pc2.BorderColor = Color.MintCream;  pc3.BorderColor = Color.MintCream;
            pd1.BorderColor = Color.MintCream;  pd2.BorderColor = Color.MintCream;  pd3.BorderColor = Color.MintCream;
            pe1.BorderColor = Color.MintCream;  pe2.BorderColor = Color.MintCream;  pe3.BorderColor = Color.MintCream;
            pf1.BorderColor = Color.MintCream;  pf2.BorderColor = Color.MintCream;  pf3.BorderColor = Color.MintCream;
            pg1.BorderColor = Color.MintCream;  pg2.BorderColor = Color.MintCream;  pg3.BorderColor = Color.MintCream;
            ph1.BorderColor = Color.MintCream;  ph2.BorderColor = Color.MintCream;  ph3.BorderColor = Color.MintCream;
            pi1.BorderColor = Color.MintCream;  pi2.BorderColor = Color.MintCream;  pi3.BorderColor = Color.MintCream;
            pj1.BorderColor = Color.MintCream;  pj2.BorderColor = Color.MintCream;  pj3.BorderColor = Color.MintCream;
            pk1.BorderColor = Color.MintCream;  pk2.BorderColor = Color.MintCream;  pk3.BorderColor = Color.MintCream;
            pl1.BorderColor = Color.MintCream;  pl2.BorderColor = Color.MintCream;  pl3.BorderColor = Color.MintCream;
            pm1.BorderColor = Color.MintCream;  pm2.BorderColor = Color.MintCream;  pm3.BorderColor = Color.MintCream;
            pn1.BorderColor = Color.MintCream;  pn2.BorderColor = Color.MintCream;  pn3.BorderColor = Color.MintCream;
            po1.BorderColor = Color.MintCream;  po2.BorderColor = Color.MintCream;  po3.BorderColor = Color.MintCream;
            start.Enabled = true ;back.Enabled = false; next.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            String c = job_node.Text;
            switch (c)
            {
                case "a": job_node.Text = "A"; break;
                case "b": job_node.Text = "B"; break;
                case "c": job_node.Text = "C"; break;
                case "d": job_node.Text = "D"; break;
                case "e": job_node.Text = "E"; break;
                case "f": job_node.Text = "F"; break;
                case "g": job_node.Text = "G"; break;
                case "h": job_node.Text = "H"; break;
                case "i": job_node.Text = "I"; break;
                case "j": job_node.Text = "J"; break;
                case "k": job_node.Text = "K"; break;
                case "l": job_node.Text = "L"; break;
                case "m": job_node.Text = "M"; break;
                case "n": job_node.Text = "N"; break;
                case "o": job_node.Text = "O"; break;
            }
            if (automatic.Checked == true && start.Text.Equals("START"))
            {
                start.Enabled = false;
                run.Enabled = true;
            }
            else if (automatic.Checked == true && start.Text.Equals("FINISH"))
            {
                job_node.Enabled = true;
                start.Text = "START";
                Del_Search();
            }
            else {
                if (start.Text.Equals("START")) 
                {
                    job_node.Enabled = false;
                    start.Text = "RESET";
                    next.Enabled = true;
                    Next_Search();
                }
                else if (start.Text.Equals("RESET"))
                {
                    job_node.Enabled = true;
                    start.Text = "START";
                    back.Enabled = false;
                    next.Enabled = false;
                    Del_Search();
                }
                else
                {
                    job_node.Enabled = true;
                    start.Text = "START";
                    Del_Search();
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Back_Search();
        }

        private void next_Click(object sender, EventArgs e)
        {
            back.Enabled = true;
            Next_Search();
        }

        private void Del_Search()
        {
            int chk = tlist.Rows.Count;
            for (int i = 1; i < chk;i++) {
                //MessageBox.Show(chk+" - "+i+"");
                tlist.Rows.RemoveAt(0);
            }
            node_a.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;node_a.BorderColor = Color.Lime;node_a.FillColor = Color.White;
            node_b.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;node_b.BorderColor = Color.Lime;node_b.FillColor = Color.White;
            node_c.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;node_c.BorderColor = Color.Lime;node_c.FillColor = Color.White;
            node_d.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;node_d.BorderColor = Color.Lime;node_d.FillColor = Color.White;
            node_e.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;node_e.BorderColor = Color.Lime;node_e.FillColor = Color.White;
            node_f.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;node_f.BorderColor = Color.Lime;node_f.FillColor = Color.White;
            node_g.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;node_g.BorderColor = Color.Lime;node_g.FillColor = Color.White;
            node_h.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;node_h.BorderColor = Color.Lime;node_h.FillColor = Color.White;
            node_i.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;node_i.BorderColor = Color.Lime;node_i.FillColor = Color.White;
            node_j.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;node_j.BorderColor = Color.Lime;node_j.FillColor = Color.White;
            node_k.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;node_k.BorderColor = Color.Lime;node_k.FillColor = Color.White;
            node_l.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;node_l.BorderColor = Color.Lime;node_l.FillColor = Color.White;
            node_m.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;node_m.BorderColor = Color.Lime;node_m.FillColor = Color.White;
            node_n.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;node_n.BorderColor = Color.Lime;node_n.FillColor = Color.White;
            node_o.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;node_o.BorderColor = Color.Lime;node_o.FillColor = Color.White;
            pa1.BorderColor = Color.MintCream; pa2.BorderColor = Color.MintCream; pa3.BorderColor = Color.MintCream;
            pb1.BorderColor = Color.MintCream; pb2.BorderColor = Color.MintCream; pb3.BorderColor = Color.MintCream;
            pc1.BorderColor = Color.MintCream; pc2.BorderColor = Color.MintCream; pc3.BorderColor = Color.MintCream;
            pd1.BorderColor = Color.MintCream; pd2.BorderColor = Color.MintCream; pd3.BorderColor = Color.MintCream;
            pe1.BorderColor = Color.MintCream; pe2.BorderColor = Color.MintCream; pe3.BorderColor = Color.MintCream;
            pf1.BorderColor = Color.MintCream; pf2.BorderColor = Color.MintCream; pf3.BorderColor = Color.MintCream;
            pg1.BorderColor = Color.MintCream; pg2.BorderColor = Color.MintCream; pg3.BorderColor = Color.MintCream;
            ph1.BorderColor = Color.MintCream; ph2.BorderColor = Color.MintCream; ph3.BorderColor = Color.MintCream;
            pi1.BorderColor = Color.MintCream; pi2.BorderColor = Color.MintCream; pi3.BorderColor = Color.MintCream;
            pj1.BorderColor = Color.MintCream; pj2.BorderColor = Color.MintCream; pj3.BorderColor = Color.MintCream;
            pk1.BorderColor = Color.MintCream; pk2.BorderColor = Color.MintCream; pk3.BorderColor = Color.MintCream;
            pl1.BorderColor = Color.MintCream; pl2.BorderColor = Color.MintCream; pl3.BorderColor = Color.MintCream;
            pm1.BorderColor = Color.MintCream; pm2.BorderColor = Color.MintCream; pm3.BorderColor = Color.MintCream;
            pn1.BorderColor = Color.MintCream; pn2.BorderColor = Color.MintCream; pn3.BorderColor = Color.MintCream;
            po1.BorderColor = Color.MintCream; po2.BorderColor = Color.MintCream; po3.BorderColor = Color.MintCream;
            line_b.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;line_b.BorderColor = Color.Lime;
            line_c.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;line_c.BorderColor = Color.Lime;
            line_d.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;line_d.BorderColor = Color.Lime;
            line_e.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;line_e.BorderColor = Color.Lime;
            line_f.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;line_f.BorderColor = Color.Lime;
            line_g.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;line_g.BorderColor = Color.Lime;
            line_h.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;line_h.BorderColor = Color.Lime;
            line_i.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;line_i.BorderColor = Color.Lime;
            line_j.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;line_j.BorderColor = Color.Lime;
            line_k.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;line_k.BorderColor = Color.Lime;
            line_l.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;line_l.BorderColor = Color.Lime;
            line_m.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;line_m.BorderColor = Color.Lime;
            line_n.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;line_n.BorderColor = Color.Lime;
            line_o.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;line_o.BorderColor = Color.Lime;
            lb_a.BackColor = Color.White;lb_b.BackColor = Color.White;lb_c.BackColor = Color.White;
            lb_d.BackColor = Color.White;lb_e.BackColor = Color.White;lb_f.BackColor = Color.White;
            lb_g.BackColor = Color.White;lb_h.BackColor = Color.White;lb_i.BackColor = Color.White;
            lb_j.BackColor = Color.White;lb_k.BackColor = Color.White;lb_l.BackColor = Color.White;
            lb_m.BackColor = Color.White;lb_n.BackColor = Color.White;lb_o.BackColor = Color.White;
            l = 0;
        }

        private void Back_Search()
        {
            String s = tlist[0, l - 1].Value + "";
            //MessageBox.Show(s);
            if (s == "B")
            {
                tlist.Rows.RemoveAt(l-1);
                pb1.BorderColor = Color.MintCream; pb2.BorderColor = Color.MintCream; pb3.BorderColor = Color.MintCream;
                pa1.BorderColor = Color.Red; pa2.BorderColor = Color.Red; pa3.BorderColor = Color.Red;
                node_a.FillColor = Color.White;
                lb_a.BackColor = Color.White;

                node_b.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                node_b.BorderColor = Color.Lime;
                line_b.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                line_b.BorderColor = Color.Lime;
                node_c.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                node_c.BorderColor = Color.Lime;
                line_c.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                line_c.BorderColor = Color.Lime;
                back.Enabled = false;
            }
            else if (s == "C")
            {
                tlist.Rows.RemoveAt(l - 1);
                pc1.BorderColor = Color.MintCream; pc2.BorderColor = Color.MintCream; pc3.BorderColor = Color.MintCream;
                pb1.BorderColor = Color.Red; pb2.BorderColor = Color.Red; pb3.BorderColor = Color.Red;
                node_b.FillColor = Color.White;
                lb_b.BackColor = Color.White;

                node_d.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                node_d.BorderColor = Color.Lime;
                line_d.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                line_d.BorderColor = Color.Lime;
                node_e.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                node_e.BorderColor = Color.Lime;
                line_e.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                line_e.BorderColor = Color.Lime;
            }
            else if (s == "D")
            {
                tlist.Rows.RemoveAt(l - 1);
                pd1.BorderColor = Color.MintCream; pd2.BorderColor = Color.MintCream; pd3.BorderColor = Color.MintCream;
                pc1.BorderColor = Color.Red; pc2.BorderColor = Color.Red; pc3.BorderColor = Color.Red;
                node_c.FillColor = Color.White;
                lb_c.BackColor = Color.White;

                node_f.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                node_f.BorderColor = Color.Lime;
                line_f.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                line_f.BorderColor = Color.Lime;
                node_g.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                node_g.BorderColor = Color.Lime;
                line_g.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                line_g.BorderColor = Color.Lime;
            }
            else if (s == "E")
            {
                tlist.Rows.RemoveAt(l - 1);
                pe1.BorderColor = Color.MintCream; pe2.BorderColor = Color.MintCream; pe3.BorderColor = Color.MintCream;
                pd1.BorderColor = Color.Red; pd2.BorderColor = Color.Red; pd3.BorderColor = Color.Red;
                node_d.FillColor = Color.White;
                lb_d.BackColor = Color.White;

                node_h.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                node_h.BorderColor = Color.Lime;
                line_h.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                line_h.BorderColor = Color.Lime;
                node_i.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                node_i.BorderColor = Color.Lime;
                line_i.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                line_i.BorderColor = Color.Lime;
            }
            else if (s == "F")
            {
                tlist.Rows.RemoveAt(l - 1);
                pf1.BorderColor = Color.MintCream; pf2.BorderColor = Color.MintCream; pf3.BorderColor = Color.MintCream;
                pe1.BorderColor = Color.Red; pe2.BorderColor = Color.Red; pe3.BorderColor = Color.Red;
                node_e.FillColor = Color.White;
                lb_e.BackColor = Color.White;


                node_j.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                node_j.BorderColor = Color.Lime;
                line_j.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                line_j.BorderColor = Color.Lime;
                node_k.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                node_k.BorderColor = Color.Lime;
                line_k.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                line_k.BorderColor = Color.Lime;
            }
            else if (s == "G")
            {
                tlist.Rows.RemoveAt(l - 1);
                pg1.BorderColor = Color.MintCream; pg2.BorderColor = Color.MintCream; pg3.BorderColor = Color.MintCream;
                pf1.BorderColor = Color.Red; pf2.BorderColor = Color.Red; pf3.BorderColor = Color.Red;
                node_f.FillColor = Color.White;
                lb_f.BackColor = Color.White;


                node_l.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                node_l.BorderColor = Color.Lime;
                line_l.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                line_l.BorderColor = Color.Lime;
                node_m.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                node_m.BorderColor = Color.Lime;
                line_m.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                line_m.BorderColor = Color.Lime;
            }
            else if (s == "H")
            {
                tlist.Rows.RemoveAt(l - 1);
                ph1.BorderColor = Color.MintCream; ph2.BorderColor = Color.MintCream; ph3.BorderColor = Color.MintCream;
                pg1.BorderColor = Color.Red; pg2.BorderColor = Color.Red; pg3.BorderColor = Color.Red;
                node_g.FillColor = Color.White;
                lb_g.BackColor = Color.White;


                node_n.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                node_n.BorderColor = Color.Lime;
                line_n.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                line_n.BorderColor = Color.Lime;
                node_o.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                node_o.BorderColor = Color.Lime;
                line_o.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                line_o.BorderColor = Color.Lime;
            }
            else if (s == "I")
            {
                tlist.Rows.RemoveAt(l - 1);
                pi1.BorderColor = Color.MintCream; pi2.BorderColor = Color.MintCream; pi3.BorderColor = Color.MintCream;
                ph1.BorderColor = Color.Red; ph2.BorderColor = Color.Red; ph3.BorderColor = Color.Red;
                node_h.FillColor = Color.White;
                lb_h.BackColor = Color.White;
            }
            else if (s == "J")
            {
                tlist.Rows.RemoveAt(l - 1);
                pj1.BorderColor = Color.MintCream; pj2.BorderColor = Color.MintCream; pj3.BorderColor = Color.MintCream;
                pi1.BorderColor = Color.Red; pi2.BorderColor = Color.Red; pi3.BorderColor = Color.Red;
                node_i.FillColor = Color.White;
                lb_i.BackColor = Color.White;
            }
            else if (s == "K")
            {
                tlist.Rows.RemoveAt(l - 1);
                pk1.BorderColor = Color.MintCream; pk2.BorderColor = Color.MintCream; pk3.BorderColor = Color.MintCream;
                pj1.BorderColor = Color.Red; pj2.BorderColor = Color.Red; pj3.BorderColor = Color.Red;
                node_j.FillColor = Color.White;
                lb_j.BackColor = Color.White;
            }
            else if (s == "L")
            {
                tlist.Rows.RemoveAt(l - 1);
                pl1.BorderColor = Color.MintCream; pl2.BorderColor = Color.MintCream; pl3.BorderColor = Color.MintCream;
                pk1.BorderColor = Color.Red; pk2.BorderColor = Color.Red; pk3.BorderColor = Color.Red;
                node_k.FillColor = Color.White;
                lb_k.BackColor = Color.White;
            }
            else if (s == "M")
            {
                tlist.Rows.RemoveAt(l - 1);
                pm1.BorderColor = Color.MintCream; pm2.BorderColor = Color.MintCream; pm3.BorderColor = Color.MintCream;
                pl1.BorderColor = Color.Red; pl2.BorderColor = Color.Red; pl3.BorderColor = Color.Red;
                node_l.FillColor = Color.White;
                lb_l.BackColor = Color.White;
            }
            else if (s == "N")
            {
                tlist.Rows.RemoveAt(l - 1);
                pn1.BorderColor = Color.MintCream; pn2.BorderColor = Color.MintCream; pn3.BorderColor = Color.MintCream;
                pm1.BorderColor = Color.Red; pm2.BorderColor = Color.Red; pm3.BorderColor = Color.Red;
                node_m.FillColor = Color.White;
                lb_m.BackColor = Color.White;
            }
            else if (s == "O")
            {
                tlist.Rows.RemoveAt(l - 1);
                po1.BorderColor = Color.MintCream; po2.BorderColor = Color.MintCream; po3.BorderColor = Color.MintCream;
                pn1.BorderColor = Color.Red; pn2.BorderColor = Color.Red; pn3.BorderColor = Color.Red;
                node_n.FillColor = Color.White;
                lb_n.BackColor = Color.White;
            }

            l--;
        }

        private void Next_Search(){
            if (tlist[0, 0].Value+""=="")
            {
                pa1.BorderColor = Color.Red; pa2.BorderColor = Color.Red; pa3.BorderColor = Color.Red;
                node_a.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                node_a.BorderColor = Color.Black;
                tlist.Rows.Add("A","B C");
            }
            else {
                String s = tlist[1, l - 1].Value + "";
                if (s.Substring(0, 1)=="B") {
                    tlist.Rows.Add("B", "C D E");
                    pa1.BorderColor = Color.MintCream; pa2.BorderColor = Color.MintCream; pa3.BorderColor = Color.MintCream;
                    pb1.BorderColor = Color.Red; pb2.BorderColor = Color.Red; pb3.BorderColor = Color.Red;
                    node_a.FillColor = Color.DarkGray;
                    lb_a.BackColor = Color.DarkGray;

                    node_b.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    node_b.BorderColor = Color.Black;
                    line_b.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    line_b.BorderColor = Color.Black;
                    node_c.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    node_c.BorderColor = Color.Black;
                    line_c.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    line_c.BorderColor = Color.Black;
                }
                else if (s.Substring(0, 1) == "C")
                {
                    tlist.Rows.Add("C", "D E F G");
                    pb1.BorderColor = Color.MintCream; pb2.BorderColor = Color.MintCream; pb3.BorderColor = Color.MintCream;
                    pc1.BorderColor = Color.Red; pc2.BorderColor = Color.Red; pc3.BorderColor = Color.Red;
                    node_b.FillColor = Color.DarkGray;
                    lb_b.BackColor = Color.DarkGray;

                    node_d.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    node_d.BorderColor = Color.Black;
                    line_d.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    line_d.BorderColor = Color.Black;
                    node_e.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    node_e.BorderColor = Color.Black;
                    line_e.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    line_e.BorderColor = Color.Black;
                }
                else if (s.Substring(0, 1) == "D")
                {
                    tlist.Rows.Add("D", "E F G H I");
                    pc1.BorderColor = Color.MintCream; pc2.BorderColor = Color.MintCream; pc3.BorderColor = Color.MintCream;
                    pd1.BorderColor = Color.Red; pd2.BorderColor = Color.Red; pd3.BorderColor = Color.Red;
                    node_c.FillColor = Color.DarkGray;
                    lb_c.BackColor = Color.DarkGray;

                    node_f.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    node_f.BorderColor = Color.Black;
                    line_f.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    line_f.BorderColor = Color.Black;
                    node_g.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    node_g.BorderColor = Color.Black;
                    line_g.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    line_g.BorderColor = Color.Black;
                }
                else if (s.Substring(0, 1) == "E")
                {
                    tlist.Rows.Add("E", "F G H I J K");
                    pd1.BorderColor = Color.MintCream; pd2.BorderColor = Color.MintCream; pd3.BorderColor = Color.MintCream;
                    pe1.BorderColor = Color.Red; pe2.BorderColor = Color.Red; pe3.BorderColor = Color.Red;
                    node_d.FillColor = Color.DarkGray;
                    lb_d.BackColor = Color.DarkGray;

                    node_h.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    node_h.BorderColor = Color.Black;
                    line_h.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    line_h.BorderColor = Color.Black;
                    node_i.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    node_i.BorderColor = Color.Black;
                    line_i.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    line_i.BorderColor = Color.Black;
                }
                else if (s.Substring(0, 1) == "F")
                {
                    tlist.Rows.Add("F", "G H I J K L M");
                    pe1.BorderColor = Color.MintCream; pe2.BorderColor = Color.MintCream; pe3.BorderColor = Color.MintCream;
                    pf1.BorderColor = Color.Red; pf2.BorderColor = Color.Red; pf3.BorderColor = Color.Red;
                    node_e.FillColor = Color.DarkGray;
                    lb_e.BackColor = Color.DarkGray;

                    node_j.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    node_j.BorderColor = Color.Black;
                    line_j.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    line_j.BorderColor = Color.Black;
                    node_k.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    node_k.BorderColor = Color.Black;
                    line_k.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    line_k.BorderColor = Color.Black;
                }
                else if (s.Substring(0, 1) == "G")
                {
                    tlist.Rows.Add("G", "H I J K L M N O");
                    pf1.BorderColor = Color.MintCream; pf2.BorderColor = Color.MintCream; pf3.BorderColor = Color.MintCream;
                    pg1.BorderColor = Color.Red; pg2.BorderColor = Color.Red; pg3.BorderColor = Color.Red;
                    node_f.FillColor = Color.DarkGray;
                    lb_f.BackColor = Color.DarkGray;

                    node_l.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    node_l.BorderColor = Color.Black;
                    line_l.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    line_l.BorderColor = Color.Black;
                    node_m.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    node_m.BorderColor = Color.Black;
                    line_m.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    line_m.BorderColor = Color.Black;
                }
                else if (s.Substring(0, 1) == "H")
                {
                    tlist.Rows.Add("H", "I J K L M N O");
                    pg1.BorderColor = Color.MintCream; pg2.BorderColor = Color.MintCream; pg3.BorderColor = Color.MintCream;
                    ph1.BorderColor = Color.Red; ph2.BorderColor = Color.Red; ph3.BorderColor = Color.Red;
                    node_g.FillColor = Color.DarkGray;
                    lb_g.BackColor = Color.DarkGray;

                    node_n.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    node_n.BorderColor = Color.Black;
                    line_n.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    line_n.BorderColor = Color.Black;
                    node_o.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    node_o.BorderColor = Color.Black;
                    line_o.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    line_o.BorderColor = Color.Black;
                }
                else if (s.Substring(0, 1) == "I")
                {
                    tlist.Rows.Add("I", "J K L M N O");
                    ph1.BorderColor = Color.MintCream; ph2.BorderColor = Color.MintCream; ph3.BorderColor = Color.MintCream;
                    pi1.BorderColor = Color.Red; pi2.BorderColor = Color.Red; pi3.BorderColor = Color.Red;
                    node_h.FillColor = Color.DarkGray;
                    lb_h.BackColor = Color.DarkGray;
                }
                else if (s.Substring(0, 1) == "J")
                {
                    tlist.Rows.Add("J", "K L M N O");
                    pi1.BorderColor = Color.MintCream; pi2.BorderColor = Color.MintCream; pi3.BorderColor = Color.MintCream;
                    pj1.BorderColor = Color.Red; pj2.BorderColor = Color.Red; pj3.BorderColor = Color.Red;
                    node_i.FillColor = Color.DarkGray;
                    lb_i.BackColor = Color.DarkGray;
                }
                else if (s.Substring(0, 1) == "K")
                {
                    tlist.Rows.Add("K", "L M N O");
                    pj1.BorderColor = Color.MintCream; pj2.BorderColor = Color.MintCream; pj3.BorderColor = Color.MintCream;
                    pk1.BorderColor = Color.Red; pk2.BorderColor = Color.Red; pk3.BorderColor = Color.Red;
                    node_j.FillColor = Color.DarkGray;
                    lb_j.BackColor = Color.DarkGray;
                }
                else if (s.Substring(0, 1) == "L")
                {
                    tlist.Rows.Add("L", "M N O");
                    pk1.BorderColor = Color.MintCream; pk2.BorderColor = Color.MintCream; pk3.BorderColor = Color.MintCream;
                    pl1.BorderColor = Color.Red; pl2.BorderColor = Color.Red; pl3.BorderColor = Color.Red;
                    node_k.FillColor = Color.DarkGray;
                    lb_k.BackColor = Color.DarkGray;
                }
                else if (s.Substring(0, 1) == "M")
                {
                    tlist.Rows.Add("M", "N O");
                    pl1.BorderColor = Color.MintCream; pl2.BorderColor = Color.MintCream; pl3.BorderColor = Color.MintCream;
                    pm1.BorderColor = Color.Red; pm2.BorderColor = Color.Red; pm3.BorderColor = Color.Red;
                    node_l.FillColor = Color.DarkGray;
                    lb_l.BackColor = Color.DarkGray;
                }
                else if (s.Substring(0, 1) == "N")
                {
                    tlist.Rows.Add("N", "O");
                    pm1.BorderColor = Color.MintCream; pm2.BorderColor = Color.MintCream; pm3.BorderColor = Color.MintCream;
                    pn1.BorderColor = Color.Red; pn2.BorderColor = Color.Red; pn3.BorderColor = Color.Red;
                    node_m.FillColor = Color.DarkGray;
                    lb_m.BackColor = Color.DarkGray;
                }
                else if (s.Substring(0, 1) == "O")
                {
                    tlist.Rows.Add("O", "");
                    pn1.BorderColor = Color.MintCream; pn2.BorderColor = Color.MintCream; pn3.BorderColor = Color.MintCream;
                    po1.BorderColor = Color.Red; po2.BorderColor = Color.Red; po3.BorderColor = Color.Red;
                    node_n.FillColor = Color.DarkGray;
                    lb_n.BackColor = Color.DarkGray;
                }
            }
            l++;
            if(tlist[0,l-1].Value.ToString()==job_node.Text.ToString()){
                run.Enabled = false;
                MessageBox.Show("เจอโหนด " + job_node.Text + " ที่ค้นหาแล้ว","End",MessageBoxButtons.OK,MessageBoxIcon.Information);
                start.Text = "FINISH";
                start.Enabled = true;
                back.Enabled = false;
                next.Enabled = false;
            }
        }

        private void job_node_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'A' || e.KeyChar == 'B' || e.KeyChar == 'C' || e.KeyChar == 'D' || e.KeyChar == 'E' || e.KeyChar == 'F' || e.KeyChar == 'G' || e.KeyChar == 'H' || e.KeyChar == 'I' || e.KeyChar == 'J' || e.KeyChar == 'K' || e.KeyChar == 'L' || e.KeyChar == 'M' || e.KeyChar == 'N' || e.KeyChar == 'O')
            {
                start.Enabled = true;
            }
            else if (e.KeyChar == 'a' || e.KeyChar == 'b' || e.KeyChar == 'c' || e.KeyChar == 'd' || e.KeyChar == 'e' || e.KeyChar == 'f' || e.KeyChar == 'g' || e.KeyChar == 'h' || e.KeyChar == 'i' || e.KeyChar == 'j' || e.KeyChar == 'k' || e.KeyChar == 'l' || e.KeyChar == 'm' || e.KeyChar == 'n' || e.KeyChar == 'o')
            {
                //start.Enabled = false;
                //MessageBox.Show("กรุณากรอกเฉพาะตัวพิมย์ใหญ่เท่านั้น", "Select Node !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                start.Enabled = true;
            }
            else
            {
                start.Enabled = false;
                MessageBox.Show("กรุณากรอกเฉพาะโหนด A-O เท่านั้น", "Select Node !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void run_Tick(object sender, EventArgs e)
        {
            Next_Search();
        }

    }
}
