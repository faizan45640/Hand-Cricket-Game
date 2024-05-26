namespace handcricket2
{
    partial class RegisterUser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterUser));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            UsernnameTXT = new TextBox();
            PasswordTXT = new TextBox();
            MaleRdioBTN = new RadioButton();
            FemaleRdioBTN = new RadioButton();
            label5 = new Label();
            RegisterBTN = new Button();
            usernamealreadylabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Russo One", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(30, 54, 63);
            label1.Location = new Point(159, 9);
            label1.Name = "label1";
            label1.Size = new Size(347, 57);
            label1.TabIndex = 0;
            label1.Text = "Hand Cricket";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._171480955719903720;
            pictureBox1.Location = new Point(276, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources._171664216376381694_removebg_preview;
            pictureBox4.Location = new Point(564, 453);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 54, 63);
            panel1.Location = new Point(27, 195);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 2);
            panel1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Russo One", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(30, 54, 63);
            label2.Location = new Point(245, 185);
            label2.Name = "label2";
            label2.Size = new Size(197, 25);
            label2.TabIndex = 14;
            label2.Text = "Register Account";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._1714809557199037201;
            pictureBox2.Location = new Point(211, 179);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 54, 63);
            panel2.Location = new Point(445, 195);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 2);
            panel2.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Russo One", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(30, 54, 63);
            label3.Location = new Point(179, 257);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 17;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Russo One", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(30, 54, 63);
            label4.Location = new Point(179, 302);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 18;
            label4.Text = "Password";
            // 
            // UsernnameTXT
            // 
            UsernnameTXT.BorderStyle = BorderStyle.FixedSingle;
            UsernnameTXT.Cursor = Cursors.IBeam;
            UsernnameTXT.Font = new Font("Russo One", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernnameTXT.ForeColor = Color.FromArgb(30, 54, 63);
            UsernnameTXT.Location = new Point(329, 256);
            UsernnameTXT.Name = "UsernnameTXT";
            UsernnameTXT.Size = new Size(147, 26);
            UsernnameTXT.TabIndex = 19;
            UsernnameTXT.TextChanged += textBox1_TextChanged;
            // 
            // PasswordTXT
            // 
            PasswordTXT.BorderStyle = BorderStyle.FixedSingle;
            PasswordTXT.Cursor = Cursors.IBeam;
            PasswordTXT.Font = new Font("Russo One", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTXT.ForeColor = Color.FromArgb(30, 54, 63);
            PasswordTXT.Location = new Point(329, 301);
            PasswordTXT.Name = "PasswordTXT";
            PasswordTXT.Size = new Size(147, 26);
            PasswordTXT.TabIndex = 20;
            PasswordTXT.UseSystemPasswordChar = true;
            // 
            // MaleRdioBTN
            // 
            MaleRdioBTN.AutoSize = true;
            MaleRdioBTN.Font = new Font("Russo One", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaleRdioBTN.ForeColor = Color.FromArgb(30, 54, 63);
            MaleRdioBTN.Location = new Point(329, 348);
            MaleRdioBTN.Name = "MaleRdioBTN";
            MaleRdioBTN.Size = new Size(62, 22);
            MaleRdioBTN.TabIndex = 21;
            MaleRdioBTN.TabStop = true;
            MaleRdioBTN.Text = "Male";
            MaleRdioBTN.UseVisualStyleBackColor = true;
            // 
            // FemaleRdioBTN
            // 
            FemaleRdioBTN.AutoSize = true;
            FemaleRdioBTN.Font = new Font("Russo One", 11.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FemaleRdioBTN.ForeColor = Color.FromArgb(30, 54, 63);
            FemaleRdioBTN.Location = new Point(414, 348);
            FemaleRdioBTN.Name = "FemaleRdioBTN";
            FemaleRdioBTN.Size = new Size(80, 22);
            FemaleRdioBTN.TabIndex = 22;
            FemaleRdioBTN.TabStop = true;
            FemaleRdioBTN.Text = "Female";
            FemaleRdioBTN.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Russo One", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(30, 54, 63);
            label5.Location = new Point(179, 345);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 23;
            label5.Text = "Gender";
            // 
            // RegisterBTN
            // 
            RegisterBTN.BackColor = Color.FromArgb(255, 142, 50);
            RegisterBTN.FlatAppearance.BorderSize = 0;
            RegisterBTN.FlatStyle = FlatStyle.Popup;
            RegisterBTN.Font = new Font("Russo One", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterBTN.ForeColor = Color.FromArgb(30, 54, 63);
            RegisterBTN.Location = new Point(276, 418);
            RegisterBTN.Name = "RegisterBTN";
            RegisterBTN.Size = new Size(147, 35);
            RegisterBTN.TabIndex = 24;
            RegisterBTN.Text = "Register";
            RegisterBTN.UseVisualStyleBackColor = false;
            RegisterBTN.Click += RegisterBTN_Click;
            // 
            // usernamealreadylabel
            // 
            usernamealreadylabel.AutoSize = true;
            usernamealreadylabel.Font = new Font("Russo One", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernamealreadylabel.ForeColor = Color.FromArgb(30, 54, 63);
            usernamealreadylabel.Location = new Point(331, 284);
            usernamealreadylabel.Name = "usernamealreadylabel";
            usernamealreadylabel.Size = new Size(163, 14);
            usernamealreadylabel.TabIndex = 25;
            usernamealreadylabel.Text = "Username already exists!";
            usernamealreadylabel.Visible = false;
            // 
            // RegisterUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 111, 81);
            ClientSize = new Size(616, 493);
            Controls.Add(usernamealreadylabel);
            Controls.Add(RegisterBTN);
            Controls.Add(label5);
            Controls.Add(FemaleRdioBTN);
            Controls.Add(MaleRdioBTN);
            Controls.Add(PasswordTXT);
            Controls.Add(UsernnameTXT);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hand Cricket";
            Load += RegisterUser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private TextBox UsernnameTXT;
        private TextBox PasswordTXT;
        private RadioButton MaleRdioBTN;
        private RadioButton FemaleRdioBTN;
        private Label label5;
        private Button RegisterBTN;
        private Label usernamealreadylabel;
    }
}
