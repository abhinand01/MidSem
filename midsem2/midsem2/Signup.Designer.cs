namespace midsem2
{
    partial class Signup
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(26, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "E M A I L               :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(24, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "U S E R N A M E    :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(25, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "P A S S W O R D    :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "S I G N U P  P A G E";
            this.label1.UseMnemonic = false;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(225, 134);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(153, 20);
            this.email.TabIndex = 10;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(225, 183);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(153, 20);
            this.name.TabIndex = 11;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(225, 231);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(153, 20);
            this.username.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(147, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 48);
            this.button1.TabIndex = 13;
            this.button1.Text = "S I G N U P";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(25, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "N A M E                 :";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(225, 294);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(153, 20);
            this.password.TabIndex = 15;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 410);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.name);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.Text = "Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
    }
}