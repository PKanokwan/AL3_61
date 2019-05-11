namespace ai_project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.source = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.Label();
            this.Floor = new System.Windows.Forms.SplitContainer();
            this.town_e = new System.Windows.Forms.PictureBox();
            this.town_h = new System.Windows.Forms.PictureBox();
            this.town_u = new System.Windows.Forms.PictureBox();
            this.town_v = new System.Windows.Forms.PictureBox();
            this.town_i = new System.Windows.Forms.PictureBox();
            this.town_n = new System.Windows.Forms.PictureBox();
            this.town_g = new System.Windows.Forms.PictureBox();
            this.town_b = new System.Windows.Forms.PictureBox();
            this.town_f = new System.Windows.Forms.PictureBox();
            this.town_p = new System.Windows.Forms.PictureBox();
            this.town_r = new System.Windows.Forms.PictureBox();
            this.town_c = new System.Windows.Forms.PictureBox();
            this.town_d = new System.Windows.Forms.PictureBox();
            this.town_m = new System.Windows.Forms.PictureBox();
            this.town_l = new System.Windows.Forms.PictureBox();
            this.town_t = new System.Windows.Forms.PictureBox();
            this.town_s = new System.Windows.Forms.PictureBox();
            this.town_a = new System.Windows.Forms.PictureBox();
            this.town_z = new System.Windows.Forms.PictureBox();
            this.town_o = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_path = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pn_show = new System.Windows.Forms.Panel();
            this.timer_draw = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Floor)).BeginInit();
            this.Floor.Panel1.SuspendLayout();
            this.Floor.Panel2.SuspendLayout();
            this.Floor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.town_e)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_u)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_i)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_f)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_d)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_l)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_o)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // source
            // 
            this.source.DropDownHeight = 215;
            this.source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.source.FormattingEnabled = true;
            this.source.IntegralHeight = false;
            this.source.ItemHeight = 21;
            this.source.Items.AddRange(new object[] {
            "select town",
            "Arad",
            "Craiova",
            "Dobreta",
            "Eforie",
            "Fagaras",
            "Giurgiu",
            "Hirsova",
            "Iasi",
            "Lugoj",
            "Mehadia",
            "Neamt",
            "Oradea",
            "Pitesti",
            "Rimnicu",
            "Sibiu",
            "Timisoara",
            "Urziceni",
            "Vaslui",
            "Zerind"});
            this.source.Location = new System.Drawing.Point(132, 342);
            this.source.Margin = new System.Windows.Forms.Padding(5);
            this.source.MaxDropDownItems = 5;
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(199, 29);
            this.source.TabIndex = 0;
            this.source.SelectedIndexChanged += new System.EventHandler(this.source_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 345);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source :";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(132, 439);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(94, 31);
            this.search.TabIndex = 4;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 394);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination :";
            // 
            // destination
            // 
            this.destination.AutoSize = true;
            this.destination.Location = new System.Drawing.Point(128, 394);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(88, 21);
            this.destination.TabIndex = 6;
            this.destination.Text = "Bucharest";
            // 
            // Floor
            // 
            this.Floor.BackColor = System.Drawing.Color.Transparent;
            this.Floor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Floor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Floor.IsSplitterFixed = true;
            this.Floor.Location = new System.Drawing.Point(0, 0);
            this.Floor.Name = "Floor";
            // 
            // Floor.Panel1
            // 
            this.Floor.Panel1.AutoScroll = true;
            this.Floor.Panel1.Controls.Add(this.town_e);
            this.Floor.Panel1.Controls.Add(this.town_h);
            this.Floor.Panel1.Controls.Add(this.town_u);
            this.Floor.Panel1.Controls.Add(this.town_v);
            this.Floor.Panel1.Controls.Add(this.town_i);
            this.Floor.Panel1.Controls.Add(this.town_n);
            this.Floor.Panel1.Controls.Add(this.town_g);
            this.Floor.Panel1.Controls.Add(this.town_b);
            this.Floor.Panel1.Controls.Add(this.town_f);
            this.Floor.Panel1.Controls.Add(this.town_p);
            this.Floor.Panel1.Controls.Add(this.town_r);
            this.Floor.Panel1.Controls.Add(this.town_c);
            this.Floor.Panel1.Controls.Add(this.town_d);
            this.Floor.Panel1.Controls.Add(this.town_m);
            this.Floor.Panel1.Controls.Add(this.town_l);
            this.Floor.Panel1.Controls.Add(this.town_t);
            this.Floor.Panel1.Controls.Add(this.town_s);
            this.Floor.Panel1.Controls.Add(this.town_a);
            this.Floor.Panel1.Controls.Add(this.town_z);
            this.Floor.Panel1.Controls.Add(this.town_o);
            this.Floor.Panel1.Controls.Add(this.label4);
            this.Floor.Panel1.Controls.Add(this.label1);
            this.Floor.Panel1.Controls.Add(this.destination);
            this.Floor.Panel1.Controls.Add(this.source);
            this.Floor.Panel1.Controls.Add(this.pictureBox1);
            this.Floor.Panel1.Controls.Add(this.label2);
            this.Floor.Panel1.Controls.Add(this.search);
            // 
            // Floor.Panel2
            // 
            this.Floor.Panel2.AutoScroll = true;
            this.Floor.Panel2.Controls.Add(this.lb_path);
            this.Floor.Panel2.Controls.Add(this.label3);
            this.Floor.Panel2.Controls.Add(this.pn_show);
            this.Floor.Size = new System.Drawing.Size(1284, 612);
            this.Floor.SplitterDistance = 610;
            this.Floor.TabIndex = 7;
            // 
            // town_e
            // 
            this.town_e.BackColor = System.Drawing.Color.White;
            this.town_e.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.town_e.Location = new System.Drawing.Point(435, 261);
            this.town_e.Name = "town_e";
            this.town_e.Size = new System.Drawing.Size(16, 16);
            this.town_e.TabIndex = 26;
            this.town_e.TabStop = false;
            // 
            // town_h
            // 
            this.town_h.BackColor = System.Drawing.Color.White;
            this.town_h.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.town_h.Location = new System.Drawing.Point(409, 223);
            this.town_h.Name = "town_h";
            this.town_h.Size = new System.Drawing.Size(16, 16);
            this.town_h.TabIndex = 25;
            this.town_h.TabStop = false;
            // 
            // town_u
            // 
            this.town_u.BackColor = System.Drawing.Color.White;
            this.town_u.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.town_u.Location = new System.Drawing.Point(347, 217);
            this.town_u.Name = "town_u";
            this.town_u.Size = new System.Drawing.Size(16, 16);
            this.town_u.TabIndex = 24;
            this.town_u.TabStop = false;
            // 
            // town_v
            // 
            this.town_v.BackColor = System.Drawing.Color.White;
            this.town_v.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_v.BackgroundImage")));
            this.town_v.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.town_v.Location = new System.Drawing.Point(388, 149);
            this.town_v.Name = "town_v";
            this.town_v.Size = new System.Drawing.Size(16, 16);
            this.town_v.TabIndex = 23;
            this.town_v.TabStop = false;
            // 
            // town_i
            // 
            this.town_i.BackColor = System.Drawing.Color.White;
            this.town_i.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_i.BackgroundImage")));
            this.town_i.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.town_i.Location = new System.Drawing.Point(357, 104);
            this.town_i.Name = "town_i";
            this.town_i.Size = new System.Drawing.Size(16, 16);
            this.town_i.TabIndex = 22;
            this.town_i.TabStop = false;
            // 
            // town_n
            // 
            this.town_n.BackColor = System.Drawing.Color.White;
            this.town_n.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_n.BackgroundImage")));
            this.town_n.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.town_n.Location = new System.Drawing.Point(305, 82);
            this.town_n.Name = "town_n";
            this.town_n.Size = new System.Drawing.Size(16, 16);
            this.town_n.TabIndex = 21;
            this.town_n.TabStop = false;
            // 
            // town_g
            // 
            this.town_g.BackColor = System.Drawing.Color.White;
            this.town_g.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.town_g.Location = new System.Drawing.Point(278, 285);
            this.town_g.Name = "town_g";
            this.town_g.Size = new System.Drawing.Size(16, 16);
            this.town_g.TabIndex = 20;
            this.town_g.TabStop = false;
            // 
            // town_b
            // 
            this.town_b.BackColor = System.Drawing.Color.Transparent;
            this.town_b.BackgroundImage = global::ai_project.Properties.Resources.flag_green_16;
            this.town_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.town_b.Location = new System.Drawing.Point(301, 235);
            this.town_b.Name = "town_b";
            this.town_b.Size = new System.Drawing.Size(16, 16);
            this.town_b.TabIndex = 19;
            this.town_b.TabStop = false;
            // 
            // town_f
            // 
            this.town_f.BackColor = System.Drawing.Color.White;
            this.town_f.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_f.BackgroundImage")));
            this.town_f.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.town_f.Location = new System.Drawing.Point(221, 149);
            this.town_f.Name = "town_f";
            this.town_f.Size = new System.Drawing.Size(16, 16);
            this.town_f.TabIndex = 18;
            this.town_f.TabStop = false;
            // 
            // town_p
            // 
            this.town_p.BackColor = System.Drawing.Color.White;
            this.town_p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_p.BackgroundImage")));
            this.town_p.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.town_p.Location = new System.Drawing.Point(232, 210);
            this.town_p.Name = "town_p";
            this.town_p.Size = new System.Drawing.Size(16, 16);
            this.town_p.TabIndex = 17;
            this.town_p.TabStop = false;
            // 
            // town_r
            // 
            this.town_r.BackColor = System.Drawing.Color.White;
            this.town_r.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_r.BackgroundImage")));
            this.town_r.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.town_r.Location = new System.Drawing.Point(158, 178);
            this.town_r.Name = "town_r";
            this.town_r.Size = new System.Drawing.Size(16, 16);
            this.town_r.TabIndex = 16;
            this.town_r.TabStop = false;
            // 
            // town_c
            // 
            this.town_c.BackColor = System.Drawing.Color.White;
            this.town_c.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_c.BackgroundImage")));
            this.town_c.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.town_c.Location = new System.Drawing.Point(170, 267);
            this.town_c.Name = "town_c";
            this.town_c.Size = new System.Drawing.Size(16, 16);
            this.town_c.TabIndex = 15;
            this.town_c.TabStop = false;
            // 
            // town_d
            // 
            this.town_d.BackColor = System.Drawing.Color.White;
            this.town_d.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_d.BackgroundImage")));
            this.town_d.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.town_d.Location = new System.Drawing.Point(99, 262);
            this.town_d.Name = "town_d";
            this.town_d.Size = new System.Drawing.Size(16, 16);
            this.town_d.TabIndex = 14;
            this.town_d.TabStop = false;
            // 
            // town_m
            // 
            this.town_m.BackColor = System.Drawing.Color.White;
            this.town_m.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_m.BackgroundImage")));
            this.town_m.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.town_m.Location = new System.Drawing.Point(99, 227);
            this.town_m.Name = "town_m";
            this.town_m.Size = new System.Drawing.Size(16, 16);
            this.town_m.TabIndex = 13;
            this.town_m.TabStop = false;
            // 
            // town_l
            // 
            this.town_l.BackColor = System.Drawing.Color.White;
            this.town_l.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_l.BackgroundImage")));
            this.town_l.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.town_l.Location = new System.Drawing.Point(95, 196);
            this.town_l.Name = "town_l";
            this.town_l.Size = new System.Drawing.Size(16, 16);
            this.town_l.TabIndex = 12;
            this.town_l.TabStop = false;
            // 
            // town_t
            // 
            this.town_t.BackColor = System.Drawing.Color.White;
            this.town_t.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_t.BackgroundImage")));
            this.town_t.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.town_t.Location = new System.Drawing.Point(34, 178);
            this.town_t.Name = "town_t";
            this.town_t.Size = new System.Drawing.Size(16, 16);
            this.town_t.TabIndex = 11;
            this.town_t.TabStop = false;
            // 
            // town_s
            // 
            this.town_s.BackColor = System.Drawing.Color.White;
            this.town_s.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_s.BackgroundImage")));
            this.town_s.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.town_s.Location = new System.Drawing.Point(136, 142);
            this.town_s.Name = "town_s";
            this.town_s.Size = new System.Drawing.Size(16, 16);
            this.town_s.TabIndex = 10;
            this.town_s.TabStop = false;
            // 
            // town_a
            // 
            this.town_a.BackColor = System.Drawing.Color.White;
            this.town_a.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_a.BackgroundImage")));
            this.town_a.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.town_a.Location = new System.Drawing.Point(36, 113);
            this.town_a.Name = "town_a";
            this.town_a.Size = new System.Drawing.Size(16, 16);
            this.town_a.TabIndex = 9;
            this.town_a.TabStop = false;
            // 
            // town_z
            // 
            this.town_z.BackColor = System.Drawing.Color.White;
            this.town_z.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_z.BackgroundImage")));
            this.town_z.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.town_z.Location = new System.Drawing.Point(48, 82);
            this.town_z.Name = "town_z";
            this.town_z.Size = new System.Drawing.Size(16, 16);
            this.town_z.TabIndex = 8;
            this.town_z.TabStop = false;
            // 
            // town_o
            // 
            this.town_o.BackColor = System.Drawing.Color.White;
            this.town_o.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_o.BackgroundImage")));
            this.town_o.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.town_o.Location = new System.Drawing.Point(67, 50);
            this.town_o.Name = "town_o";
            this.town_o.Size = new System.Drawing.Size(16, 16);
            this.town_o.TabIndex = 0;
            this.town_o.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Map and Straight-line distance to Bucharest";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ai_project.Properties.Resources.map;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(11, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(584, 284);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lb_path
            // 
            this.lb_path.AutoSize = true;
            this.lb_path.Location = new System.Drawing.Point(64, 8);
            this.lb_path.Name = "lb_path";
            this.lb_path.Size = new System.Drawing.Size(0, 21);
            this.lb_path.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Path :";
            // 
            // pn_show
            // 
            this.pn_show.AutoScroll = true;
            this.pn_show.BackColor = System.Drawing.Color.Transparent;
            this.pn_show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_show.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_show.Location = new System.Drawing.Point(0, 32);
            this.pn_show.Margin = new System.Windows.Forms.Padding(0);
            this.pn_show.Name = "pn_show";
            this.pn_show.Size = new System.Drawing.Size(668, 578);
            this.pn_show.TabIndex = 0;
            // 
            // timer_draw
            // 
            this.timer_draw.Interval = 500;
            this.timer_draw.Tick += new System.EventHandler(this.timer_draw_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 612);
            this.Controls.Add(this.Floor);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Greedy Best-First Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Floor.Panel1.ResumeLayout(false);
            this.Floor.Panel1.PerformLayout();
            this.Floor.Panel2.ResumeLayout(false);
            this.Floor.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Floor)).EndInit();
            this.Floor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.town_e)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_u)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_i)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_f)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_d)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_l)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.town_o)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox source;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.SplitContainer Floor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox town_s;
        private System.Windows.Forms.PictureBox town_a;
        private System.Windows.Forms.PictureBox town_z;
        private System.Windows.Forms.PictureBox town_o;
        private System.Windows.Forms.PictureBox town_c;
        private System.Windows.Forms.PictureBox town_d;
        private System.Windows.Forms.PictureBox town_m;
        private System.Windows.Forms.PictureBox town_l;
        private System.Windows.Forms.PictureBox town_t;
        private System.Windows.Forms.PictureBox town_b;
        private System.Windows.Forms.PictureBox town_f;
        private System.Windows.Forms.PictureBox town_p;
        private System.Windows.Forms.PictureBox town_r;
        private System.Windows.Forms.PictureBox town_e;
        private System.Windows.Forms.PictureBox town_h;
        private System.Windows.Forms.PictureBox town_u;
        private System.Windows.Forms.PictureBox town_v;
        private System.Windows.Forms.PictureBox town_i;
        private System.Windows.Forms.PictureBox town_n;
        private System.Windows.Forms.PictureBox town_g;
        private System.Windows.Forms.Panel pn_show;
        private System.Windows.Forms.Label lb_path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer_draw;
    }
}

