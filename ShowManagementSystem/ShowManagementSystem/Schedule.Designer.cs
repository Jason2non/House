namespace ShowManagementSystem
{
    partial class Schedule
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.showTxt = new System.Windows.Forms.TextBox();
            this.genreCb = new System.Windows.Forms.ComboBox();
            this.duraTxt = new System.Windows.Forms.TextBox();
            this.castTxt = new System.Windows.Forms.TextBox();
            this.crewTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timeTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sectTxt = new System.Windows.Forms.TextBox();
            this.rowTxt = new System.Windows.Forms.TextBox();
            this.seatTxt = new System.Windows.Forms.TextBox();
            this.capTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.venueTxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.shoBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.showidtxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedule Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Show Title";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duration";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cast";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ticket type";
            // 
            // showTxt
            // 
            this.showTxt.Location = new System.Drawing.Point(129, 126);
            this.showTxt.Multiline = true;
            this.showTxt.Name = "showTxt";
            this.showTxt.Size = new System.Drawing.Size(245, 20);
            this.showTxt.TabIndex = 6;
            this.showTxt.TextChanged += new System.EventHandler(this.showTxt_TextChanged);
            // 
            // genreCb
            // 
            this.genreCb.FormattingEnabled = true;
            this.genreCb.Items.AddRange(new object[] {
            "Horror",
            "Comedy",
            "Action/Martial Arts",
            "Thriller",
            "Autobiography",
            "Biography",
            "Documentary",
            "Reality",
            "Pyschological"});
            this.genreCb.Location = new System.Drawing.Point(129, 167);
            this.genreCb.Name = "genreCb";
            this.genreCb.Size = new System.Drawing.Size(121, 21);
            this.genreCb.TabIndex = 7;
            this.genreCb.SelectedIndexChanged += new System.EventHandler(this.genreCb_SelectedIndexChanged);
            // 
            // duraTxt
            // 
            this.duraTxt.Location = new System.Drawing.Point(129, 210);
            this.duraTxt.Multiline = true;
            this.duraTxt.Name = "duraTxt";
            this.duraTxt.Size = new System.Drawing.Size(48, 20);
            this.duraTxt.TabIndex = 8;
            this.duraTxt.TextChanged += new System.EventHandler(this.duraTxt_TextChanged);
            // 
            // castTxt
            // 
            this.castTxt.Location = new System.Drawing.Point(129, 252);
            this.castTxt.Multiline = true;
            this.castTxt.Name = "castTxt";
            this.castTxt.Size = new System.Drawing.Size(245, 20);
            this.castTxt.TabIndex = 9;
            this.castTxt.TextChanged += new System.EventHandler(this.castTxt_TextChanged);
            // 
            // crewTxt
            // 
            this.crewTxt.Location = new System.Drawing.Point(130, 290);
            this.crewTxt.Multiline = true;
            this.crewTxt.Name = "crewTxt";
            this.crewTxt.Size = new System.Drawing.Size(245, 20);
            this.crewTxt.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(404, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Time";
            // 
            // timeTxt
            // 
            this.timeTxt.Location = new System.Drawing.Point(459, 87);
            this.timeTxt.Multiline = true;
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(199, 22);
            this.timeTxt.TabIndex = 12;
            this.timeTxt.TextChanged += new System.EventHandler(this.timeTxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(560, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Add Seat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(449, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Section";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(467, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Row";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(404, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Seat Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(437, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Capacity";
            // 
            // sectTxt
            // 
            this.sectTxt.Location = new System.Drawing.Point(521, 185);
            this.sectTxt.Multiline = true;
            this.sectTxt.Name = "sectTxt";
            this.sectTxt.Size = new System.Drawing.Size(168, 20);
            this.sectTxt.TabIndex = 18;
            this.sectTxt.TextChanged += new System.EventHandler(this.sectTxt_TextChanged);
            // 
            // rowTxt
            // 
            this.rowTxt.Location = new System.Drawing.Point(521, 224);
            this.rowTxt.Multiline = true;
            this.rowTxt.Name = "rowTxt";
            this.rowTxt.Size = new System.Drawing.Size(168, 20);
            this.rowTxt.TabIndex = 19;
            this.rowTxt.TextChanged += new System.EventHandler(this.rowTxt_TextChanged);
            // 
            // seatTxt
            // 
            this.seatTxt.Location = new System.Drawing.Point(521, 260);
            this.seatTxt.Multiline = true;
            this.seatTxt.Name = "seatTxt";
            this.seatTxt.Size = new System.Drawing.Size(168, 20);
            this.seatTxt.TabIndex = 20;
            this.seatTxt.TextChanged += new System.EventHandler(this.seatTxt_TextChanged);
            // 
            // capTxt
            // 
            this.capTxt.Location = new System.Drawing.Point(521, 297);
            this.capTxt.Multiline = true;
            this.capTxt.Name = "capTxt";
            this.capTxt.Size = new System.Drawing.Size(168, 20);
            this.capTxt.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(191, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Add Show";
            // 
            // venueTxt
            // 
            this.venueTxt.Location = new System.Drawing.Point(521, 150);
            this.venueTxt.Multiline = true;
            this.venueTxt.Name = "venueTxt";
            this.venueTxt.Size = new System.Drawing.Size(168, 20);
            this.venueTxt.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(454, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Venue";
            // 
            // shoBtn
            // 
            this.shoBtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.shoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.shoBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.shoBtn.Location = new System.Drawing.Point(130, 356);
            this.shoBtn.Name = "shoBtn";
            this.shoBtn.Size = new System.Drawing.Size(92, 35);
            this.shoBtn.TabIndex = 25;
            this.shoBtn.Text = "Add Show";
            this.shoBtn.UseVisualStyleBackColor = false;
            this.shoBtn.Click += new System.EventHandler(this.shoBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FloralWhite;
            this.button2.Location = new System.Drawing.Point(521, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 35);
            this.button2.TabIndex = 26;
            this.button2.Text = "Add Seat";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(282, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 27;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(369, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 35);
            this.button3.TabIndex = 28;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(611, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 35);
            this.button4.TabIndex = 29;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(130, 325);
            this.priceTxt.Multiline = true;
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(245, 20);
            this.priceTxt.TabIndex = 30;
            this.priceTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(68, 326);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Price";
            // 
            // showidtxt
            // 
            this.showidtxt.Location = new System.Drawing.Point(129, 89);
            this.showidtxt.Multiline = true;
            this.showidtxt.Name = "showidtxt";
            this.showidtxt.Size = new System.Drawing.Size(245, 20);
            this.showidtxt.TabIndex = 32;
            this.showidtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(48, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 20);
            this.label16.TabIndex = 33;
            this.label16.Text = "Show Id";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(183, 210);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 20);
            this.label17.TabIndex = 34;
            this.label17.Text = "hrs";
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.showidtxt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.shoBtn);
            this.Controls.Add(this.venueTxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.capTxt);
            this.Controls.Add(this.seatTxt);
            this.Controls.Add(this.rowTxt);
            this.Controls.Add(this.sectTxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timeTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.crewTxt);
            this.Controls.Add(this.castTxt);
            this.Controls.Add(this.duraTxt);
            this.Controls.Add(this.genreCb);
            this.Controls.Add(this.showTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox showTxt;
        private System.Windows.Forms.ComboBox genreCb;
        private System.Windows.Forms.TextBox duraTxt;
        private System.Windows.Forms.TextBox castTxt;
        private System.Windows.Forms.TextBox crewTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox timeTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox sectTxt;
        private System.Windows.Forms.TextBox rowTxt;
        private System.Windows.Forms.TextBox seatTxt;
        private System.Windows.Forms.TextBox capTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox venueTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button shoBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox showidtxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}