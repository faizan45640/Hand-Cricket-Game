namespace handcricket2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            LoginBTN = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            RegisterBTN = new Button();
            PlayAsGeustButton = new Button();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Russo One", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(30, 54, 63);
            label1.Location = new Point(129, 9);
            label1.Name = "label1";
            label1.Size = new Size(347, 57);
            label1.TabIndex = 0;
            label1.Text = "Hand Cricket";
            label1.Click += label1_Click;
            // 
            // LoginBTN
            // 
            LoginBTN.BackColor = Color.FromArgb(255, 142, 50);
            LoginBTN.FlatAppearance.BorderSize = 0;
            LoginBTN.FlatStyle = FlatStyle.Popup;
            LoginBTN.Font = new Font("Russo One", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBTN.ForeColor = Color.FromArgb(30, 54, 63);
            LoginBTN.Location = new Point(201, 156);
            LoginBTN.Name = "LoginBTN";
            LoginBTN.Size = new Size(208, 41);
            LoginBTN.TabIndex = 1;
            LoginBTN.Text = "Login";
            LoginBTN.UseVisualStyleBackColor = false;
            LoginBTN.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._171480955719903720;
            pictureBox1.Location = new Point(258, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 142, 50);
            pictureBox2.Image = Properties.Resources.loginicon_removebg_preview__1_;
            pictureBox2.Location = new Point(212, 163);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(255, 142, 50);
            pictureBox3.Image = Properties.Resources._1714809557199037201;
            pictureBox3.Location = new Point(212, 232);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // RegisterBTN
            // 
            RegisterBTN.BackColor = Color.FromArgb(255, 142, 50);
            RegisterBTN.FlatAppearance.BorderSize = 0;
            RegisterBTN.FlatStyle = FlatStyle.Popup;
            RegisterBTN.Font = new Font("Russo One", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterBTN.ForeColor = Color.FromArgb(30, 54, 63);
            RegisterBTN.Location = new Point(201, 225);
            RegisterBTN.Name = "RegisterBTN";
            RegisterBTN.Size = new Size(208, 41);
            RegisterBTN.TabIndex = 7;
            RegisterBTN.Text = "Register";
            RegisterBTN.UseVisualStyleBackColor = false;
            RegisterBTN.Click += RegisterBTN_Click;
            // 
            // PlayAsGeustButton
            // 
            PlayAsGeustButton.BackColor = Color.FromArgb(255, 142, 50);
            PlayAsGeustButton.FlatAppearance.BorderSize = 0;
            PlayAsGeustButton.FlatStyle = FlatStyle.Popup;
            PlayAsGeustButton.Font = new Font("Russo One", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlayAsGeustButton.ForeColor = Color.FromArgb(30, 54, 63);
            PlayAsGeustButton.Location = new Point(201, 294);
            PlayAsGeustButton.Name = "PlayAsGeustButton";
            PlayAsGeustButton.Size = new Size(208, 41);
            PlayAsGeustButton.TabIndex = 9;
            PlayAsGeustButton.Text = "Play As Guest";
            PlayAsGeustButton.UseVisualStyleBackColor = false;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 111, 81);
            ClientSize = new Size(616, 493);
            Controls.Add(pictureBox4);
            Controls.Add(PlayAsGeustButton);
            Controls.Add(pictureBox3);
            Controls.Add(RegisterBTN);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(LoginBTN);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hand Cricket";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button LoginBTN;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button RegisterBTN;
        private Button PlayAsGeustButton;
        private PictureBox pictureBox4;
    }
}
