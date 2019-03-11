namespace Matricula
{
    partial class FLogIn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.forgotBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logInBtn = new System.Windows.Forms.Button();
            this.passwrordTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(27)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.forgotBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logInBtn);
            this.panel1.Controls.Add(this.passwrordTxt);
            this.panel1.Controls.Add(this.usernameTxt);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 392);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(98, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(98, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "user";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // forgotBtn
            // 
            this.forgotBtn.FlatAppearance.BorderSize = 0;
            this.forgotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotBtn.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.forgotBtn.Location = new System.Drawing.Point(372, 355);
            this.forgotBtn.Margin = new System.Windows.Forms.Padding(4);
            this.forgotBtn.Name = "forgotBtn";
            this.forgotBtn.Size = new System.Drawing.Size(114, 33);
            this.forgotBtn.TabIndex = 4;
            this.forgotBtn.Text = "Forgot password?";
            this.forgotBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(174, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOMBRE DE LA APP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.pictureBox1.Image = global::Matricula.Properties.Resources.ulacit;
            this.pictureBox1.Location = new System.Drawing.Point(117, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // logInBtn
            // 
            this.logInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.logInBtn.Location = new System.Drawing.Point(218, 343);
            this.logInBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(72, 35);
            this.logInBtn.TabIndex = 2;
            this.logInBtn.Text = "LogIn";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // passwrordTxt
            // 
            this.passwrordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwrordTxt.Location = new System.Drawing.Point(178, 311);
            this.passwrordTxt.Margin = new System.Windows.Forms.Padding(4);
            this.passwrordTxt.Name = "passwrordTxt";
            this.passwrordTxt.Size = new System.Drawing.Size(148, 24);
            this.passwrordTxt.TabIndex = 1;
            this.passwrordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwrordTxt.UseWaitCursor = true;
            this.passwrordTxt.TextChanged += new System.EventHandler(this.passwrodTxt_TextChanged);
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(178, 269);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(148, 24);
            this.usernameTxt.TabIndex = 0;
            this.usernameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            // 
            // FLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(487, 395);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FLogIn";
            this.Text = "FLogIn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwrordTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button forgotBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}