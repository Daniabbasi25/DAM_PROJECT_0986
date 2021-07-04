namespace Train_Ticketing_System_VP
{
    partial class Loginform
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
            this.idlabel = new System.Windows.Forms.Label();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.PassworedLabel = new System.Windows.Forms.Label();
            this.Passwordtextbox = new System.Windows.Forms.TextBox();
            this.AdmincheckBox = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.Location = new System.Drawing.Point(149, 104);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(107, 20);
            this.idlabel.TabIndex = 1;
            this.idlabel.Text = "Enter Your ID";
            // 
            // idtextbox
            // 
            this.idtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtextbox.Location = new System.Drawing.Point(273, 104);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(202, 26);
            this.idtextbox.TabIndex = 2;
            this.idtextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PassworedLabel
            // 
            this.PassworedLabel.AutoSize = true;
            this.PassworedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassworedLabel.Location = new System.Drawing.Point(149, 173);
            this.PassworedLabel.Name = "PassworedLabel";
            this.PassworedLabel.Size = new System.Drawing.Size(78, 20);
            this.PassworedLabel.TabIndex = 3;
            this.PassworedLabel.Text = "Password";
            // 
            // Passwordtextbox
            // 
            this.Passwordtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtextbox.Location = new System.Drawing.Point(273, 170);
            this.Passwordtextbox.Name = "Passwordtextbox";
            this.Passwordtextbox.Size = new System.Drawing.Size(202, 26);
            this.Passwordtextbox.TabIndex = 4;
            this.Passwordtextbox.TextChanged += new System.EventHandler(this.Passwordtextbox_TextChanged);
            // 
            // AdmincheckBox
            // 
            this.AdmincheckBox.AutoSize = true;
            this.AdmincheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmincheckBox.Location = new System.Drawing.Point(273, 215);
            this.AdmincheckBox.Name = "AdmincheckBox";
            this.AdmincheckBox.Size = new System.Drawing.Size(119, 20);
            this.AdmincheckBox.TabIndex = 5;
            this.AdmincheckBox.Text = "Login as Admin";
            this.AdmincheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.DarkGreen;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(273, 257);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(133, 40);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(62, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sign up";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 456);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.AdmincheckBox);
            this.Controls.Add(this.Passwordtextbox);
            this.Controls.Add(this.PassworedLabel);
            this.Controls.Add(this.idtextbox);
            this.Controls.Add(this.idlabel);
            this.MaximizeBox = false;
            this.Name = "Loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.Label PassworedLabel;
        private System.Windows.Forms.TextBox Passwordtextbox;
        private System.Windows.Forms.CheckBox AdmincheckBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button button1;
    }
}

