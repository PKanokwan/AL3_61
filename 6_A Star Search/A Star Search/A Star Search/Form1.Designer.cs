namespace A_Star_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbbStart = new System.Windows.Forms.ComboBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Floor = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Floor)).BeginInit();
            this.Floor.Panel1.SuspendLayout();
            this.Floor.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // cbbStart
            // 
            this.cbbStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbbStart.FormattingEnabled = true;
            this.cbbStart.Items.AddRange(new object[] {
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
            this.cbbStart.Location = new System.Drawing.Point(74, 21);
            this.cbbStart.Name = "cbbStart";
            this.cbbStart.Size = new System.Drawing.Size(162, 24);
            this.cbbStart.TabIndex = 47;
            this.cbbStart.SelectedIndexChanged += new System.EventHandler(this.cbbStart_SelectedIndexChanged);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(16, 66);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(144, 16);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "Destination : Bucharest";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(16, 24);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(60, 16);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Source : ";
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHead.Location = new System.Drawing.Point(15, 9);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(270, 20);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "Traveling from any town to Bucharest";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.numericUpDown1.Location = new System.Drawing.Point(31, 29);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(63, 21);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox2.Location = new System.Drawing.Point(87, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 75);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show Speed";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSearch.Location = new System.Drawing.Point(87, 193);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 26);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Go";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Floor
            // 
            this.Floor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Floor.IsSplitterFixed = true;
            this.Floor.Location = new System.Drawing.Point(12, 12);
            this.Floor.Name = "Floor";
            // 
            // Floor.Panel1
            // 
            this.Floor.Panel1.BackColor = System.Drawing.Color.White;
            this.Floor.Panel1.Controls.Add(this.groupBox1);
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
            this.Floor.Panel1.Controls.Add(this.pictureBox1);
            this.Floor.Panel1.Controls.Add(this.lblHead);
            // 
            // Floor.Panel2
            // 
            this.Floor.Panel2.BackColor = System.Drawing.Color.White;
            this.Floor.Panel2Collapsed = true;
            this.Floor.Size = new System.Drawing.Size(1183, 457);
            this.Floor.SplitterDistance = 610;
            this.Floor.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbStart);
            this.groupBox1.Controls.Add(this.lblStart);
            this.groupBox1.Controls.Add(this.lblEnd);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(889, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 395);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // town_e
            // 
            this.town_e.BackColor = System.Drawing.Color.White;
            this.town_e.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_e.BackgroundImage")));
            this.town_e.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.town_e.Location = new System.Drawing.Point(644, 371);
            this.town_e.Name = "town_e";
            this.town_e.Size = new System.Drawing.Size(20, 20);
            this.town_e.TabIndex = 46;
            this.town_e.TabStop = false;
            // 
            // town_h
            // 
            this.town_h.BackColor = System.Drawing.Color.White;
            this.town_h.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_h.BackgroundImage")));
            this.town_h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.town_h.Location = new System.Drawing.Point(605, 310);
            this.town_h.Name = "town_h";
            this.town_h.Size = new System.Drawing.Size(20, 20);
            this.town_h.TabIndex = 45;
            this.town_h.TabStop = false;
            // 
            // town_u
            // 
            this.town_u.BackColor = System.Drawing.Color.White;
            this.town_u.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_u.BackgroundImage")));
            this.town_u.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.town_u.Location = new System.Drawing.Point(510, 306);
            this.town_u.Name = "town_u";
            this.town_u.Size = new System.Drawing.Size(20, 20);
            this.town_u.TabIndex = 44;
            this.town_u.TabStop = false;
            // 
            // town_v
            // 
            this.town_v.BackColor = System.Drawing.Color.White;
            this.town_v.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_v.BackgroundImage")));
            this.town_v.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.town_v.Location = new System.Drawing.Point(576, 202);
            this.town_v.Name = "town_v";
            this.town_v.Size = new System.Drawing.Size(20, 20);
            this.town_v.TabIndex = 43;
            this.town_v.TabStop = false;
            // 
            // town_i
            // 
            this.town_i.BackColor = System.Drawing.Color.White;
            this.town_i.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_i.BackgroundImage")));
            this.town_i.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.town_i.Location = new System.Drawing.Point(531, 131);
            this.town_i.Name = "town_i";
            this.town_i.Size = new System.Drawing.Size(20, 20);
            this.town_i.TabIndex = 42;
            this.town_i.TabStop = false;
            // 
            // town_n
            // 
            this.town_n.BackColor = System.Drawing.Color.White;
            this.town_n.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_n.BackgroundImage")));
            this.town_n.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.town_n.Location = new System.Drawing.Point(449, 101);
            this.town_n.Name = "town_n";
            this.town_n.Size = new System.Drawing.Size(20, 20);
            this.town_n.TabIndex = 41;
            this.town_n.TabStop = false;
            // 
            // town_g
            // 
            this.town_g.BackColor = System.Drawing.Color.White;
            this.town_g.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_g.BackgroundImage")));
            this.town_g.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.town_g.Location = new System.Drawing.Point(405, 398);
            this.town_g.Name = "town_g";
            this.town_g.Size = new System.Drawing.Size(20, 20);
            this.town_g.TabIndex = 40;
            this.town_g.TabStop = false;
            // 
            // town_b
            // 
            this.town_b.BackColor = System.Drawing.Color.Transparent;
            this.town_b.BackgroundImage = global::A_Star_Search.Properties.Resources.home;
            this.town_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.town_b.Location = new System.Drawing.Point(438, 319);
            this.town_b.Name = "town_b";
            this.town_b.Size = new System.Drawing.Size(31, 33);
            this.town_b.TabIndex = 39;
            this.town_b.TabStop = false;
            // 
            // town_f
            // 
            this.town_f.BackColor = System.Drawing.Color.White;
            this.town_f.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_f.BackgroundImage")));
            this.town_f.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.town_f.Location = new System.Drawing.Point(324, 196);
            this.town_f.Name = "town_f";
            this.town_f.Size = new System.Drawing.Size(20, 20);
            this.town_f.TabIndex = 38;
            this.town_f.TabStop = false;
            // 
            // town_p
            // 
            this.town_p.BackColor = System.Drawing.Color.White;
            this.town_p.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_p.BackgroundImage")));
            this.town_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.town_p.Location = new System.Drawing.Point(341, 292);
            this.town_p.Name = "town_p";
            this.town_p.Size = new System.Drawing.Size(20, 20);
            this.town_p.TabIndex = 37;
            this.town_p.TabStop = false;
            // 
            // town_r
            // 
            this.town_r.BackColor = System.Drawing.Color.White;
            this.town_r.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_r.BackgroundImage")));
            this.town_r.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.town_r.Location = new System.Drawing.Point(228, 241);
            this.town_r.Name = "town_r";
            this.town_r.Size = new System.Drawing.Size(20, 20);
            this.town_r.TabIndex = 36;
            this.town_r.TabStop = false;
            // 
            // town_c
            // 
            this.town_c.BackColor = System.Drawing.Color.White;
            this.town_c.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_c.BackgroundImage")));
            this.town_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.town_c.Location = new System.Drawing.Point(254, 380);
            this.town_c.Name = "town_c";
            this.town_c.Size = new System.Drawing.Size(20, 20);
            this.town_c.TabIndex = 35;
            this.town_c.TabStop = false;
            // 
            // town_d
            // 
            this.town_d.BackColor = System.Drawing.Color.White;
            this.town_d.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_d.BackgroundImage")));
            this.town_d.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.town_d.Location = new System.Drawing.Point(144, 367);
            this.town_d.Name = "town_d";
            this.town_d.Size = new System.Drawing.Size(20, 20);
            this.town_d.TabIndex = 34;
            this.town_d.TabStop = false;
            // 
            // town_m
            // 
            this.town_m.BackColor = System.Drawing.Color.White;
            this.town_m.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_m.BackgroundImage")));
            this.town_m.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.town_m.Location = new System.Drawing.Point(148, 320);
            this.town_m.Name = "town_m";
            this.town_m.Size = new System.Drawing.Size(20, 20);
            this.town_m.TabIndex = 33;
            this.town_m.TabStop = false;
            // 
            // town_l
            // 
            this.town_l.BackColor = System.Drawing.Color.White;
            this.town_l.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_l.BackgroundImage")));
            this.town_l.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.town_l.Location = new System.Drawing.Point(145, 276);
            this.town_l.Name = "town_l";
            this.town_l.Size = new System.Drawing.Size(20, 20);
            this.town_l.TabIndex = 32;
            this.town_l.TabStop = false;
            // 
            // town_t
            // 
            this.town_t.BackColor = System.Drawing.Color.White;
            this.town_t.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_t.BackgroundImage")));
            this.town_t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.town_t.Location = new System.Drawing.Point(53, 239);
            this.town_t.Name = "town_t";
            this.town_t.Size = new System.Drawing.Size(20, 20);
            this.town_t.TabIndex = 31;
            this.town_t.TabStop = false;
            // 
            // town_s
            // 
            this.town_s.BackColor = System.Drawing.Color.White;
            this.town_s.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_s.BackgroundImage")));
            this.town_s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.town_s.Location = new System.Drawing.Point(196, 192);
            this.town_s.Name = "town_s";
            this.town_s.Size = new System.Drawing.Size(20, 20);
            this.town_s.TabIndex = 30;
            this.town_s.TabStop = false;
            // 
            // town_a
            // 
            this.town_a.BackColor = System.Drawing.Color.White;
            this.town_a.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_a.BackgroundImage")));
            this.town_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.town_a.Location = new System.Drawing.Point(54, 153);
            this.town_a.Name = "town_a";
            this.town_a.Size = new System.Drawing.Size(20, 20);
            this.town_a.TabIndex = 29;
            this.town_a.TabStop = false;
            // 
            // town_z
            // 
            this.town_z.BackColor = System.Drawing.Color.White;
            this.town_z.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_z.BackgroundImage")));
            this.town_z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.town_z.Location = new System.Drawing.Point(73, 104);
            this.town_z.Name = "town_z";
            this.town_z.Size = new System.Drawing.Size(20, 20);
            this.town_z.TabIndex = 28;
            this.town_z.TabStop = false;
            // 
            // town_o
            // 
            this.town_o.BackColor = System.Drawing.Color.White;
            this.town_o.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("town_o.BackgroundImage")));
            this.town_o.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.town_o.Location = new System.Drawing.Point(100, 60);
            this.town_o.Name = "town_o";
            this.town_o.Size = new System.Drawing.Size(20, 20);
            this.town_o.TabIndex = 27;
            this.town_o.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::A_Star_Search.Properties.Resources.Map;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(18, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(856, 395);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1207, 484);
            this.Controls.Add(this.Floor);
            this.Font = new System.Drawing.Font("TH Sarabun New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A Star Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.Floor.Panel1.ResumeLayout(false);
            this.Floor.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Floor)).EndInit();
            this.Floor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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

        private System.Windows.Forms.PictureBox town_e;
        private System.Windows.Forms.PictureBox town_h;
        private System.Windows.Forms.PictureBox town_u;
        private System.Windows.Forms.PictureBox town_v;
        private System.Windows.Forms.PictureBox town_i;
        private System.Windows.Forms.PictureBox town_n;
        private System.Windows.Forms.PictureBox town_g;
        private System.Windows.Forms.PictureBox town_b;
        private System.Windows.Forms.PictureBox town_f;
        private System.Windows.Forms.PictureBox town_p;
        private System.Windows.Forms.PictureBox town_r;
        private System.Windows.Forms.PictureBox town_c;
        private System.Windows.Forms.PictureBox town_d;
        private System.Windows.Forms.PictureBox town_m;
        private System.Windows.Forms.PictureBox town_l;
        private System.Windows.Forms.PictureBox town_t;
        private System.Windows.Forms.PictureBox town_s;
        private System.Windows.Forms.PictureBox town_a;
        private System.Windows.Forms.PictureBox town_z;
        private System.Windows.Forms.PictureBox town_o;
        private System.Windows.Forms.ComboBox cbbStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.SplitContainer Floor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}

