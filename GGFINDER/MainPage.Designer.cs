namespace GGFINDER
{
    partial class MainPage
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
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.registerlbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TESTLABEL = new System.Windows.Forms.Label();
            this.usernamehidden = new System.Windows.Forms.Label();
            this.passwordhidden = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(406, 244);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(180, 20);
            this.usernametxt.TabIndex = 2;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(406, 296);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(180, 20);
            this.passwordtxt.TabIndex = 3;
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(406, 349);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(180, 26);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // registerlbl
            // 
            this.registerlbl.AutoSize = true;
            this.registerlbl.Location = new System.Drawing.Point(540, 378);
            this.registerlbl.Name = "registerlbl";
            this.registerlbl.Size = new System.Drawing.Size(46, 13);
            this.registerlbl.TabIndex = 5;
            this.registerlbl.Text = "Register";
            this.registerlbl.Click += new System.EventHandler(this.registerlbl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Forgot My Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(342, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 134);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // TESTLABEL
            // 
            this.TESTLABEL.AutoSize = true;
            this.TESTLABEL.ForeColor = System.Drawing.Color.Green;
            this.TESTLABEL.Location = new System.Drawing.Point(798, 130);
            this.TESTLABEL.Name = "TESTLABEL";
            this.TESTLABEL.Size = new System.Drawing.Size(68, 13);
            this.TESTLABEL.TabIndex = 8;
            this.TESTLABEL.Text = "TESTLABEL";
            // 
            // usernamehidden
            // 
            this.usernamehidden.AutoSize = true;
            this.usernamehidden.ForeColor = System.Drawing.Color.Red;
            this.usernamehidden.Location = new System.Drawing.Point(413, 267);
            this.usernamehidden.Name = "usernamehidden";
            this.usernamehidden.Size = new System.Drawing.Size(41, 13);
            this.usernamehidden.TabIndex = 9;
            this.usernamehidden.Text = "Hidden";
            this.usernamehidden.Visible = false;
            // 
            // passwordhidden
            // 
            this.passwordhidden.AutoSize = true;
            this.passwordhidden.ForeColor = System.Drawing.Color.Red;
            this.passwordhidden.Location = new System.Drawing.Point(413, 319);
            this.passwordhidden.Name = "passwordhidden";
            this.passwordhidden.Size = new System.Drawing.Size(41, 13);
            this.passwordhidden.TabIndex = 10;
            this.passwordhidden.Text = "Hidden";
            this.passwordhidden.Visible = false;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.ForeColor = System.Drawing.Color.Red;
            this.result.Location = new System.Drawing.Point(403, 418);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(41, 13);
            this.result.TabIndex = 11;
            this.result.Text = "Hidden";
            this.result.Visible = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 574);
            this.Controls.Add(this.result);
            this.Controls.Add(this.passwordhidden);
            this.Controls.Add(this.usernamehidden);
            this.Controls.Add(this.TESTLABEL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.registerlbl);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainPage";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label registerlbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TESTLABEL;
        private System.Windows.Forms.Label usernamehidden;
        private System.Windows.Forms.Label passwordhidden;
        private System.Windows.Forms.Label result;
    }
}

