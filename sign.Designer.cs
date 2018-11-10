namespace hanuman
{
    partial class sign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sign));
            this.createacountlbl = new System.Windows.Forms.LinkLabel();
            this.signbtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createacountlbl
            // 
            this.createacountlbl.AutoSize = true;
            this.createacountlbl.Location = new System.Drawing.Point(343, 380);
            this.createacountlbl.Name = "createacountlbl";
            this.createacountlbl.Size = new System.Drawing.Size(112, 13);
            this.createacountlbl.TabIndex = 13;
            this.createacountlbl.TabStop = true;
            this.createacountlbl.Text = "Create a new account";
            // 
            // signbtn
            // 
            this.signbtn.Location = new System.Drawing.Point(343, 301);
            this.signbtn.Name = "signbtn";
            this.signbtn.Size = new System.Drawing.Size(112, 36);
            this.signbtn.TabIndex = 12;
            this.signbtn.Text = "Sign in";
            this.signbtn.UseVisualStyleBackColor = true;
            this.signbtn.Click += new System.EventHandler(this.signbtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(324, 252);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 11;
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Location = new System.Drawing.Point(375, 227);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(53, 13);
            this.passwordlbl.TabIndex = 10;
            this.passwordlbl.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(301, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 9;
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Location = new System.Drawing.Point(351, 158);
            this.usernamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(97, 13);
            this.usernamelbl.TabIndex = 8;
            this.usernamelbl.Text = "Username or e-mail";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(343, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createacountlbl);
            this.Controls.Add(this.signbtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "sign";
            this.Text = "sign";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel createacountlbl;
        private System.Windows.Forms.Button signbtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}