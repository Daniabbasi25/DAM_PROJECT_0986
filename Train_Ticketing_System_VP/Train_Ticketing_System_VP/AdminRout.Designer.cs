namespace Train_Ticketing_System_VP
{
    partial class AdminRout
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
            this.Ridlabel = new System.Windows.Forms.Label();
            this.RidtextBox = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Rnamelabel = new System.Windows.Forms.Label();
            this.Sstationlabel = new System.Windows.Forms.Label();
            this.RnametextBox = new System.Windows.Forms.TextBox();
            this.Endinglabl = new System.Windows.Forms.Label();
            this.FCTrainlabel = new System.Windows.Forms.Label();
            this.FclasstextBox = new System.Windows.Forms.TextBox();
            this.BctextBox = new System.Windows.Forms.TextBox();
            this.Bclabel = new System.Windows.Forms.Label();
            this.Tnamelabel = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.Datelabl = new System.Windows.Forms.Label();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Deletbutton = new System.Windows.Forms.Button();
            this.SscomboBox = new System.Windows.Forms.ComboBox();
            this.EscomboBox = new System.Windows.Forms.ComboBox();
            this.TncomboBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewrout = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.DateTimePicker();
            this.Ecsp = new System.Windows.Forms.Label();
            this.EcsptextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrout)).BeginInit();
            this.SuspendLayout();
            // 
            // Ridlabel
            // 
            this.Ridlabel.AutoSize = true;
            this.Ridlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ridlabel.Location = new System.Drawing.Point(12, 35);
            this.Ridlabel.Name = "Ridlabel";
            this.Ridlabel.Size = new System.Drawing.Size(52, 16);
            this.Ridlabel.TabIndex = 1;
            this.Ridlabel.Text = "Rout ID";
            // 
            // RidtextBox
            // 
            this.RidtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RidtextBox.Location = new System.Drawing.Point(188, 32);
            this.RidtextBox.Name = "RidtextBox";
            this.RidtextBox.ReadOnly = true;
            this.RidtextBox.Size = new System.Drawing.Size(171, 22);
            this.RidtextBox.TabIndex = 5;
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.ForestGreen;
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.ForeColor = System.Drawing.Color.White;
            this.Addbutton.Location = new System.Drawing.Point(15, 481);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(101, 40);
            this.Addbutton.TabIndex = 9;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Rnamelabel
            // 
            this.Rnamelabel.AutoSize = true;
            this.Rnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rnamelabel.Location = new System.Drawing.Point(12, 80);
            this.Rnamelabel.Name = "Rnamelabel";
            this.Rnamelabel.Size = new System.Drawing.Size(90, 16);
            this.Rnamelabel.TabIndex = 10;
            this.Rnamelabel.Text = "Name of Rout";
            // 
            // Sstationlabel
            // 
            this.Sstationlabel.AutoSize = true;
            this.Sstationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sstationlabel.Location = new System.Drawing.Point(12, 125);
            this.Sstationlabel.Name = "Sstationlabel";
            this.Sstationlabel.Size = new System.Drawing.Size(97, 16);
            this.Sstationlabel.TabIndex = 11;
            this.Sstationlabel.Text = "Starting Station";
            // 
            // RnametextBox
            // 
            this.RnametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RnametextBox.Location = new System.Drawing.Point(188, 80);
            this.RnametextBox.Name = "RnametextBox";
            this.RnametextBox.Size = new System.Drawing.Size(171, 22);
            this.RnametextBox.TabIndex = 12;
            this.RnametextBox.TextChanged += new System.EventHandler(this.RnametextBox_TextChanged);
            // 
            // Endinglabl
            // 
            this.Endinglabl.AutoSize = true;
            this.Endinglabl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endinglabl.Location = new System.Drawing.Point(12, 174);
            this.Endinglabl.Name = "Endinglabl";
            this.Endinglabl.Size = new System.Drawing.Size(94, 16);
            this.Endinglabl.TabIndex = 14;
            this.Endinglabl.Text = "Ending Station";
            // 
            // FCTrainlabel
            // 
            this.FCTrainlabel.AutoSize = true;
            this.FCTrainlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCTrainlabel.Location = new System.Drawing.Point(12, 217);
            this.FCTrainlabel.Name = "FCTrainlabel";
            this.FCTrainlabel.Size = new System.Drawing.Size(135, 16);
            this.FCTrainlabel.TabIndex = 16;
            this.FCTrainlabel.Text = "First Class Seet Price";
            // 
            // FclasstextBox
            // 
            this.FclasstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FclasstextBox.Location = new System.Drawing.Point(188, 214);
            this.FclasstextBox.Name = "FclasstextBox";
            this.FclasstextBox.Size = new System.Drawing.Size(171, 22);
            this.FclasstextBox.TabIndex = 17;
            // 
            // BctextBox
            // 
            this.BctextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BctextBox.Location = new System.Drawing.Point(188, 254);
            this.BctextBox.Name = "BctextBox";
            this.BctextBox.Size = new System.Drawing.Size(171, 22);
            this.BctextBox.TabIndex = 18;
            // 
            // Bclabel
            // 
            this.Bclabel.AutoSize = true;
            this.Bclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bclabel.Location = new System.Drawing.Point(12, 260);
            this.Bclabel.Name = "Bclabel";
            this.Bclabel.Size = new System.Drawing.Size(165, 16);
            this.Bclabel.TabIndex = 19;
            this.Bclabel.Text = "Business Class Seet Price";
            // 
            // Tnamelabel
            // 
            this.Tnamelabel.AutoSize = true;
            this.Tnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tnamelabel.Location = new System.Drawing.Point(12, 350);
            this.Tnamelabel.Name = "Tnamelabel";
            this.Tnamelabel.Size = new System.Drawing.Size(93, 16);
            this.Tnamelabel.TabIndex = 20;
            this.Tnamelabel.Text = "Name of Train";
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(188, 391);
            this.date.MinDate = new System.DateTime(2021, 6, 28, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(171, 20);
            this.date.TabIndex = 22;
            // 
            // Datelabl
            // 
            this.Datelabl.AutoSize = true;
            this.Datelabl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabl.Location = new System.Drawing.Point(12, 391);
            this.Datelabl.Name = "Datelabl";
            this.Datelabl.Size = new System.Drawing.Size(37, 16);
            this.Datelabl.TabIndex = 23;
            this.Datelabl.Text = "Date";
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.ForeColor = System.Drawing.Color.White;
            this.Updatebutton.Location = new System.Drawing.Point(144, 481);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(101, 40);
            this.Updatebutton.TabIndex = 25;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Deletbutton
            // 
            this.Deletbutton.BackColor = System.Drawing.Color.Red;
            this.Deletbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletbutton.ForeColor = System.Drawing.Color.White;
            this.Deletbutton.Location = new System.Drawing.Point(283, 478);
            this.Deletbutton.Name = "Deletbutton";
            this.Deletbutton.Size = new System.Drawing.Size(101, 40);
            this.Deletbutton.TabIndex = 26;
            this.Deletbutton.Text = "Delete";
            this.Deletbutton.UseVisualStyleBackColor = false;
            this.Deletbutton.Click += new System.EventHandler(this.Deletbutton_Click);
            // 
            // SscomboBox
            // 
            this.SscomboBox.FormattingEnabled = true;
            this.SscomboBox.Location = new System.Drawing.Point(188, 125);
            this.SscomboBox.Name = "SscomboBox";
            this.SscomboBox.Size = new System.Drawing.Size(171, 21);
            this.SscomboBox.TabIndex = 27;
            // 
            // EscomboBox
            // 
            this.EscomboBox.FormattingEnabled = true;
            this.EscomboBox.Location = new System.Drawing.Point(188, 174);
            this.EscomboBox.Name = "EscomboBox";
            this.EscomboBox.Size = new System.Drawing.Size(171, 21);
            this.EscomboBox.TabIndex = 28;
            // 
            // TncomboBox
            // 
            this.TncomboBox.FormattingEnabled = true;
            this.TncomboBox.Location = new System.Drawing.Point(188, 350);
            this.TncomboBox.Name = "TncomboBox";
            this.TncomboBox.Size = new System.Drawing.Size(171, 21);
            this.TncomboBox.TabIndex = 29;
            // 
            // dataGridViewrout
            // 
            this.dataGridViewrout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewrout.Location = new System.Drawing.Point(378, 32);
            this.dataGridViewrout.Name = "dataGridViewrout";
            this.dataGridViewrout.Size = new System.Drawing.Size(506, 419);
            this.dataGridViewrout.TabIndex = 30;
            this.dataGridViewrout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewrout_CellContentClick);
            this.dataGridViewrout.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewrout_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Time of Train";
            // 
            // Time
            // 
            this.Time.AllowDrop = true;
            this.Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Time.Location = new System.Drawing.Point(188, 431);
            this.Time.MinDate = new System.DateTime(2021, 6, 28, 0, 0, 0, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(171, 20);
            this.Time.TabIndex = 31;
            // 
            // Ecsp
            // 
            this.Ecsp.AutoSize = true;
            this.Ecsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ecsp.Location = new System.Drawing.Point(12, 303);
            this.Ecsp.Name = "Ecsp";
            this.Ecsp.Size = new System.Drawing.Size(167, 16);
            this.Ecsp.TabIndex = 34;
            this.Ecsp.Text = "Economy Class Seet Price";
            // 
            // EcsptextBox
            // 
            this.EcsptextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EcsptextBox.Location = new System.Drawing.Point(188, 297);
            this.EcsptextBox.Name = "EcsptextBox";
            this.EcsptextBox.Size = new System.Drawing.Size(171, 22);
            this.EcsptextBox.TabIndex = 33;
            // 
            // AdminRout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 538);
            this.Controls.Add(this.Ecsp);
            this.Controls.Add(this.EcsptextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.dataGridViewrout);
            this.Controls.Add(this.TncomboBox);
            this.Controls.Add(this.EscomboBox);
            this.Controls.Add(this.SscomboBox);
            this.Controls.Add(this.Deletbutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Datelabl);
            this.Controls.Add(this.date);
            this.Controls.Add(this.Tnamelabel);
            this.Controls.Add(this.Bclabel);
            this.Controls.Add(this.BctextBox);
            this.Controls.Add(this.FclasstextBox);
            this.Controls.Add(this.FCTrainlabel);
            this.Controls.Add(this.Endinglabl);
            this.Controls.Add(this.RnametextBox);
            this.Controls.Add(this.Sstationlabel);
            this.Controls.Add(this.Rnamelabel);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.RidtextBox);
            this.Controls.Add(this.Ridlabel);
            this.Name = "AdminRout";
            this.Text = "AdminRout";
            this.Load += new System.EventHandler(this.AdminRout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ridlabel;
        private System.Windows.Forms.TextBox RidtextBox;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label Rnamelabel;
        private System.Windows.Forms.Label Sstationlabel;
        private System.Windows.Forms.TextBox RnametextBox;
        private System.Windows.Forms.Label Endinglabl;
        private System.Windows.Forms.Label FCTrainlabel;
        private System.Windows.Forms.TextBox FclasstextBox;
        private System.Windows.Forms.TextBox BctextBox;
        private System.Windows.Forms.Label Bclabel;
        private System.Windows.Forms.Label Tnamelabel;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label Datelabl;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Deletbutton;
        private System.Windows.Forms.ComboBox SscomboBox;
        private System.Windows.Forms.ComboBox EscomboBox;
        private System.Windows.Forms.ComboBox TncomboBox;
        private System.Windows.Forms.DataGridView dataGridViewrout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Time;
        private System.Windows.Forms.Label Ecsp;
        private System.Windows.Forms.TextBox EcsptextBox;
    }
}