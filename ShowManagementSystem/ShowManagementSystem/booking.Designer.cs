namespace ShowManagementSystem
{
    partial class booking
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.tickCb = new System.Windows.Forms.ComboBox();
            this.venuCb = new System.Windows.Forms.ComboBox();
            this.seatCb = new System.Windows.Forms.ComboBox();
            this.titleCb = new System.Windows.Forms.ComboBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.durCb = new System.Windows.Forms.ComboBox();
            this.buyBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.timeCb = new System.Windows.Forms.ComboBox();
            this.genreCb = new System.Windows.Forms.ComboBox();
            this.stageManagementSystemDataSet = new ShowManagementSystem.StageManagementSystemDataSet();
            this.stageManagementSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stageManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageManagementSystemDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Booking Dashboard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ticket Type";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Movie title";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(455, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Duration";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(471, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Genre";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(114, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Seat Number";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(158, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Venue";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(479, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Date";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(471, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Price";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox1.Location = new System.Drawing.Point(526, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(219, 113);
            this.nameTxt.Multiline = true;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(168, 24);
            this.nameTxt.TabIndex = 13;
            this.nameTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tickCb
            // 
            this.tickCb.FormattingEnabled = true;
            this.tickCb.Items.AddRange(new object[] {
            "Business",
            "Economy",
            "Regular",
            "Low budget"});
            this.tickCb.Location = new System.Drawing.Point(526, 158);
            this.tickCb.Name = "tickCb";
            this.tickCb.Size = new System.Drawing.Size(121, 21);
            this.tickCb.TabIndex = 14;
            this.tickCb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // venuCb
            // 
            this.venuCb.FormattingEnabled = true;
            this.venuCb.Items.AddRange(new object[] {
            "IMAX",
            "ANGAZA CINEMAX",
            "CINEMAPLEX",
            "NAIROBI THEATRE"});
            this.venuCb.Location = new System.Drawing.Point(219, 203);
            this.venuCb.Name = "venuCb";
            this.venuCb.Size = new System.Drawing.Size(121, 21);
            this.venuCb.TabIndex = 15;
            this.venuCb.SelectedIndexChanged += new System.EventHandler(this.venuCb_SelectedIndexChanged);
            // 
            // seatCb
            // 
            this.seatCb.FormattingEnabled = true;
            this.seatCb.Location = new System.Drawing.Point(219, 245);
            this.seatCb.Name = "seatCb";
            this.seatCb.Size = new System.Drawing.Size(121, 21);
            this.seatCb.TabIndex = 16;
            this.seatCb.SelectedIndexChanged += new System.EventHandler(this.seatCb_SelectedIndexChanged);
            // 
            // titleCb
            // 
            this.titleCb.FormattingEnabled = true;
            this.titleCb.Location = new System.Drawing.Point(219, 160);
            this.titleCb.Name = "titleCb";
            this.titleCb.Size = new System.Drawing.Size(121, 21);
            this.titleCb.TabIndex = 18;
            this.titleCb.SelectedIndexChanged += new System.EventHandler(this.titleCb_SelectedIndexChanged);
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(526, 202);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(121, 20);
            this.dateTime.TabIndex = 19;
            // 
            // durCb
            // 
            this.durCb.FormattingEnabled = true;
            this.durCb.Location = new System.Drawing.Point(526, 242);
            this.durCb.Name = "durCb";
            this.durCb.Size = new System.Drawing.Size(121, 21);
            this.durCb.TabIndex = 20;
            // 
            // buyBtn
            // 
            this.buyBtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.buyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buyBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buyBtn.Location = new System.Drawing.Point(549, 384);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(75, 23);
            this.buyBtn.TabIndex = 21;
            this.buyBtn.Text = "Buy ";
            this.buyBtn.UseVisualStyleBackColor = false;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(219, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(171, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Time";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timeCb
            // 
            this.timeCb.FormattingEnabled = true;
            this.timeCb.Location = new System.Drawing.Point(219, 284);
            this.timeCb.Name = "timeCb";
            this.timeCb.Size = new System.Drawing.Size(121, 21);
            this.timeCb.TabIndex = 25;
            this.timeCb.SelectedIndexChanged += new System.EventHandler(this.timeCb_SelectedIndexChanged);
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
            this.genreCb.Location = new System.Drawing.Point(528, 114);
            this.genreCb.Name = "genreCb";
            this.genreCb.Size = new System.Drawing.Size(121, 21);
            this.genreCb.TabIndex = 17;
            this.genreCb.SelectedIndexChanged += new System.EventHandler(this.genreCb_SelectedIndexChanged);
            // 
            // stageManagementSystemDataSet
            // 
            this.stageManagementSystemDataSet.DataSetName = "StageManagementSystemDataSet";
            this.stageManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stageManagementSystemDataSetBindingSource
            // 
            this.stageManagementSystemDataSetBindingSource.DataSource = this.stageManagementSystemDataSet;
            this.stageManagementSystemDataSetBindingSource.Position = 0;
            // 
            // booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timeCb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.durCb);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.titleCb);
            this.Controls.Add(this.genreCb);
            this.Controls.Add(this.seatCb);
            this.Controls.Add(this.venuCb);
            this.Controls.Add(this.tickCb);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "booking";
            this.Text = "booking";
            this.Load += new System.EventHandler(this.booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stageManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageManagementSystemDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.ComboBox tickCb;
        private System.Windows.Forms.ComboBox venuCb;
        private System.Windows.Forms.ComboBox seatCb;
        private System.Windows.Forms.ComboBox titleCb;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.ComboBox durCb;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox timeCb;
        private System.Windows.Forms.ComboBox genreCb;
        private StageManagementSystemDataSet stageManagementSystemDataSet;
        private System.Windows.Forms.BindingSource stageManagementSystemDataSetBindingSource;
    }
}