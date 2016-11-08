namespace Street_Lights
{
    partial class streetLights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(streetLights));
            this.leftArrow = new System.Windows.Forms.PictureBox();
            this.upArrow = new System.Windows.Forms.PictureBox();
            this.rightArrow = new System.Windows.Forms.PictureBox();
            this.downArrow = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trafficShow = new System.Windows.Forms.ToolStripMenuItem();
            this.speedShow = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.cbtb = new System.Windows.Forms.Label();
            this.uziTech = new System.Windows.Forms.Label();
            this.upArray = new System.Windows.Forms.PictureBox[numCars];
            this.downArray = new System.Windows.Forms.PictureBox[numCars];
            this.leftArray = new System.Windows.Forms.PictureBox[numCars];
            this.rightArray = new System.Windows.Forms.PictureBox[numCars];
            for (int i = 0; i < numCars; i++)
            {
                this.upArray[i] = new System.Windows.Forms.PictureBox();
                this.downArray[i] = new System.Windows.Forms.PictureBox();
                this.leftArray[i] = new System.Windows.Forms.PictureBox();
                this.rightArray[i] = new System.Windows.Forms.PictureBox();
            }
            for (int i = 0; i < numCars; i++)
            {
                ((System.ComponentModel.ISupportInitialize)(this.upArray[i])).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.downArray[i])).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.leftArray[i])).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.rightArray[i])).BeginInit();
            }
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            for (int i = 0; i < numCars; i++)
            {
                this.upArray[i].Image = ((System.Drawing.Image)(resources.GetObject("c" + i.ToString() + "u.Image")));
                this.upArray[i].Location = new System.Drawing.Point(170, 28);
                this.upArray[i].Name = "c"+ i.ToString() + "u";
                this.upArray[i].Size = new System.Drawing.Size(14, 21);
                this.upArray[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                this.upArray[i].TabIndex = 0;
                this.upArray[i].TabStop = false;
                this.upArray[i].Visible = false;
                this.upArray[i].Click += new System.EventHandler(this.car_Click);
                this.downArray[i].Image = ((System.Drawing.Image)(resources.GetObject("c" + i.ToString() + "d.Image")));
                this.downArray[i].Location = new System.Drawing.Point(170, 28);
                this.downArray[i].Name = "c" + i.ToString() + "d";
                this.downArray[i].Size = new System.Drawing.Size(14, 21);
                this.downArray[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                this.downArray[i].TabIndex = 0;
                this.downArray[i].TabStop = false;
                this.downArray[i].Visible = false;
                this.downArray[i].Click += new System.EventHandler(this.car_Click);
                this.leftArray[i].Image = ((System.Drawing.Image)(resources.GetObject("c" + i.ToString() + "l.Image")));
                this.leftArray[i].Location = new System.Drawing.Point(170, 28);
                this.leftArray[i].Name = "c" + i.ToString() + "l";
                this.leftArray[i].Size = new System.Drawing.Size(14, 21);
                this.leftArray[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                this.leftArray[i].TabIndex = 0;
                this.leftArray[i].TabStop = false;
                this.leftArray[i].Visible = false;
                this.leftArray[i].Click += new System.EventHandler(this.car_Click);
                this.rightArray[i].Image = ((System.Drawing.Image)(resources.GetObject("c" + i.ToString() + "r.Image")));
                this.rightArray[i].Location = new System.Drawing.Point(170, 28);
                this.rightArray[i].Name = "c" + i.ToString() + "r";
                this.rightArray[i].Size = new System.Drawing.Size(14, 21);
                this.rightArray[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                this.rightArray[i].TabIndex = 0;
                this.rightArray[i].TabStop = false;
                this.rightArray[i].Visible = false;
                this.rightArray[i].Click += new System.EventHandler(this.car_Click);
            }
            // 
            // leftArrow
            // 
            this.leftArrow.Image = ((System.Drawing.Image)(resources.GetObject("leftArrow.Image")));
            this.leftArrow.Location = new System.Drawing.Point(249, 195);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(21, 22);
            this.leftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftArrow.TabIndex = 11;
            this.leftArrow.TabStop = false;
            this.leftArrow.Click += new System.EventHandler(this.LRArrow_Click);
            // 
            // upArrow
            // 
            this.upArrow.Image = ((System.Drawing.Image)(resources.GetObject("upArrow.Image")));
            this.upArrow.Location = new System.Drawing.Point(190, 257);
            this.upArrow.Name = "upArrow";
            this.upArrow.Size = new System.Drawing.Size(22, 21);
            this.upArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.upArrow.TabIndex = 10;
            this.upArrow.TabStop = false;
            this.upArrow.Click += new System.EventHandler(this.UDArrow_Click);
            // 
            // rightArrow
            // 
            this.rightArrow.Image = ((System.Drawing.Image)(resources.GetObject("rightArrow.Image")));
            this.rightArrow.Location = new System.Drawing.Point(136, 195);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(21, 22);
            this.rightArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rightArrow.TabIndex = 9;
            this.rightArrow.TabStop = false;
            this.rightArrow.Click += new System.EventHandler(this.LRArrow_Click);
            // 
            // downArrow
            // 
            this.downArrow.Image = ((System.Drawing.Image)(resources.GetObject("downArrow.Image")));
            this.downArrow.Location = new System.Drawing.Point(190, 140);
            this.downArrow.Name = "downArrow";
            this.downArrow.Size = new System.Drawing.Size(22, 21);
            this.downArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.downArrow.TabIndex = 8;
            this.downArrow.TabStop = false;
            this.downArrow.Click += new System.EventHandler(this.UDArrow_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox7.Location = new System.Drawing.Point(0, 195);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(130, 10);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox8.Location = new System.Drawing.Point(0, 207);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(130, 10);
            this.pictureBox8.TabIndex = 6;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox5.Location = new System.Drawing.Point(276, 195);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(130, 10);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox6.Location = new System.Drawing.Point(276, 207);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(130, 10);
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox3.Location = new System.Drawing.Point(202, 285);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 128);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox4.Location = new System.Drawing.Point(190, 285);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 128);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox2.Location = new System.Drawing.Point(202, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 133);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Location = new System.Drawing.Point(190, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.trafficShow,
            this.speedShow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(406, 27);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // trafficShow
            // 
            this.trafficShow.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.trafficShow.Name = "trafficShow";
            this.trafficShow.Size = new System.Drawing.Size(26, 23);
            this.trafficShow.Text = "Traffic ";
            this.trafficShow.MouseDown += new System.Windows.Forms.MouseEventHandler(traffic_Click);
            // 
            // speedShow
            // 
            this.speedShow.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.speedShow.Name = "speedShow";
            this.speedShow.Size = new System.Drawing.Size(25, 23);
            this.speedShow.Text = "Speed ";
            this.speedShow.MouseDown += new System.Windows.Forms.MouseEventHandler(speed_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBox9.Location = new System.Drawing.Point(276, 27);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(130, 107);
            this.pictureBox9.TabIndex = 33;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBox10.Location = new System.Drawing.Point(276, 285);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(130, 132);
            this.pictureBox10.TabIndex = 34;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBox11.Location = new System.Drawing.Point(1, 27);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(129, 107);
            this.pictureBox11.TabIndex = 35;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBox12.Location = new System.Drawing.Point(1, 285);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(129, 132);
            this.pictureBox12.TabIndex = 36;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.LawnGreen;
            this.pictureBox13.Location = new System.Drawing.Point(82, 1);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(48, 36);
            this.pictureBox13.TabIndex = 37;
            this.pictureBox13.TabStop = false;
            // 
            // cbtb
            // 
            this.cbtb.AutoSize = true;
            this.cbtb.BackColor = System.Drawing.Color.LawnGreen;
            this.cbtb.ForeColor = System.Drawing.Color.Red;
            this.cbtb.Location = new System.Drawing.Point(289, 330);
            this.cbtb.Name = "cbtb";
            this.cbtb.Size = new System.Drawing.Size(105, 13);
            this.cbtb.TabIndex = 78;
            this.cbtb.Text = "Created by Tony Brix";
            // 
            // uziTech
            // 
            this.uziTech.AutoSize = true;
            this.uziTech.BackColor = System.Drawing.Color.LawnGreen;
            this.uziTech.ForeColor = System.Drawing.Color.Red;
            this.uziTech.Location = new System.Drawing.Point(308, 347);
            this.uziTech.Name = "uziTech";
            this.uziTech.Size = new System.Drawing.Size(70, 13);
            this.uziTech.TabIndex = 0;
            this.uziTech.Text = "UziTech.com";
            // 
            // streetLights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(406, 413);
            for (int i = 0; i < numCars; i++)
            {
                this.Controls.Add(this.upArray[i]);
                this.Controls.Add(this.downArray[i]);
                this.Controls.Add(this.leftArray[i]);
                this.Controls.Add(this.rightArray[i]);
            }
            this.Controls.Add(this.uziTech);
            this.Controls.Add(this.cbtb);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.leftArrow);
            this.Controls.Add(this.upArrow);
            this.Controls.Add(this.rightArrow);
            this.Controls.Add(this.downArrow);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "streetLights";
            this.ShowIcon = false;
            this.Text = "Street Lights";
            for (int i = 0; i < numCars; i++)
            {
                ((System.ComponentModel.ISupportInitialize)(this.upArray[i])).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.downArray[i])).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.leftArray[i])).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.rightArray[i])).EndInit();
            }
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox downArrow;
        private System.Windows.Forms.PictureBox rightArrow;
        private System.Windows.Forms.PictureBox upArrow;
        private System.Windows.Forms.PictureBox leftArrow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.ToolStripMenuItem trafficShow;
        private System.Windows.Forms.ToolStripMenuItem speedShow;
        private System.Windows.Forms.Label cbtb;
        private System.Windows.Forms.Label uziTech;
        private System.Windows.Forms.PictureBox[] upArray;
        private System.Windows.Forms.PictureBox[] downArray;
        private System.Windows.Forms.PictureBox[] leftArray;
        private System.Windows.Forms.PictureBox[] rightArray;
    }
}

