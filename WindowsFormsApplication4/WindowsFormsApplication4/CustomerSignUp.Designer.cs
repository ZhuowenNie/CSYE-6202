namespace WindowsFormsApplication4
{
    partial class CustomerSignUp
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
            this.cidtb = new System.Windows.Forms.TextBox();
            this.loginNametb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelCheck1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cidtb
            // 
            this.cidtb.Location = new System.Drawing.Point(142, 51);
            this.cidtb.Name = "cidtb";
            this.cidtb.Size = new System.Drawing.Size(100, 20);
            this.cidtb.TabIndex = 0;
            // 
            // loginNametb
            // 
            this.loginNametb.Location = new System.Drawing.Point(142, 92);
            this.loginNametb.Name = "loginNametb";
            this.loginNametb.Size = new System.Drawing.Size(100, 20);
            this.loginNametb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // passwordtb
            // 
            this.passwordtb.Location = new System.Drawing.Point(142, 132);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(100, 20);
            this.passwordtb.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "email";
            // 
            // emailtb
            // 
            this.emailtb.Location = new System.Drawing.Point(142, 176);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(100, 20);
            this.emailtb.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelCheck1
            // 
            this.labelCheck1.AutoSize = true;
            this.labelCheck1.Location = new System.Drawing.Point(276, 51);
            this.labelCheck1.Name = "labelCheck1";
            this.labelCheck1.Size = new System.Drawing.Size(110, 13);
            this.labelCheck1.TabIndex = 10;
            this.labelCheck1.Text = "CID cannot be empty!";
            this.labelCheck1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Login cannot be empty!";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email cannot be empty!";
            this.label7.Visible = false;
            // 
            // CustomerSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 395);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelCheck1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emailtb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginNametb);
            this.Controls.Add(this.cidtb);
            this.Name = "CustomerSignUp";
            this.Text = "CustomerSignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cidtb;
        private System.Windows.Forms.TextBox loginNametb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCheck1;
    }
}