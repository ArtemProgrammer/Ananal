namespace sourse
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OralCheckBox = new System.Windows.Forms.CheckBox();
            this.SexCheckBox = new System.Windows.Forms.CheckBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PozImage = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.Generate = new System.Windows.Forms.Button();
            this.LogoTextImage = new System.Windows.Forms.PictureBox();
            this.LogoImage = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelMin = new System.Windows.Forms.Label();
            this.labelSec = new System.Windows.Forms.Label();
            this.labelMs = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.RegPassField = new System.Windows.Forms.TextBox();
            this.RegLogField = new System.Windows.Forms.TextBox();
            this.labelRegLog = new System.Windows.Forms.Label();
            this.labelRegPass = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PozImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoTextImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // OralCheckBox
            // 
            this.OralCheckBox.AutoSize = true;
            this.OralCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OralCheckBox.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OralCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(97)))), ((int)(((byte)(33)))));
            this.OralCheckBox.Location = new System.Drawing.Point(209, 710);
            this.OralCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.OralCheckBox.Name = "OralCheckBox";
            this.OralCheckBox.Size = new System.Drawing.Size(197, 36);
            this.OralCheckBox.TabIndex = 5;
            this.OralCheckBox.Text = "Оральные позы";
            this.OralCheckBox.UseVisualStyleBackColor = true;
            // 
            // SexCheckBox
            // 
            this.SexCheckBox.AutoSize = true;
            this.SexCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SexCheckBox.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SexCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(97)))), ((int)(((byte)(33)))));
            this.SexCheckBox.Location = new System.Drawing.Point(209, 667);
            this.SexCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.SexCheckBox.Name = "SexCheckBox";
            this.SexCheckBox.Size = new System.Drawing.Size(140, 36);
            this.SexCheckBox.TabIndex = 6;
            this.SexCheckBox.Text = "Секс позы";
            this.SexCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.ExitButton.Location = new System.Drawing.Point(559, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(32, 28);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button3_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // PozImage
            // 
            this.PozImage.ImageLocation = "";
            this.PozImage.Location = new System.Drawing.Point(150, 241);
            this.PozImage.Margin = new System.Windows.Forms.Padding(4);
            this.PozImage.Name = "PozImage";
            this.PozImage.Size = new System.Drawing.Size(305, 235);
            this.PozImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PozImage.TabIndex = 16;
            this.PozImage.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(-1, 0);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(85, 44);
            this.BackButton.TabIndex = 15;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Generate
            // 
            this.Generate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Generate.BackgroundImage")));
            this.Generate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Generate.Location = new System.Drawing.Point(116, 553);
            this.Generate.Margin = new System.Windows.Forms.Padding(4);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(363, 68);
            this.Generate.TabIndex = 2;
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // LogoTextImage
            // 
            this.LogoTextImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoTextImage.BackgroundImage")));
            this.LogoTextImage.Location = new System.Drawing.Point(72, 321);
            this.LogoTextImage.Margin = new System.Windows.Forms.Padding(4);
            this.LogoTextImage.Name = "LogoTextImage";
            this.LogoTextImage.Size = new System.Drawing.Size(453, 84);
            this.LogoTextImage.TabIndex = 1;
            this.LogoTextImage.TabStop = false;
            // 
            // LogoImage
            // 
            this.LogoImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogoImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoImage.BackgroundImage")));
            this.LogoImage.ErrorImage = null;
            this.LogoImage.InitialImage = null;
            this.LogoImage.Location = new System.Drawing.Point(167, 13);
            this.LogoImage.Margin = new System.Windows.Forms.Padding(4);
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.Size = new System.Drawing.Size(271, 220);
            this.LogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoImage.TabIndex = 0;
            this.LogoImage.TabStop = false;
            this.LogoImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.LogoImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(259, 502);
            this.labelMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(0, 17);
            this.labelMin.TabIndex = 17;
            // 
            // labelSec
            // 
            this.labelSec.AutoSize = true;
            this.labelSec.Location = new System.Drawing.Point(292, 502);
            this.labelSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(0, 17);
            this.labelSec.TabIndex = 18;
            // 
            // labelMs
            // 
            this.labelMs.AutoSize = true;
            this.labelMs.Location = new System.Drawing.Point(326, 502);
            this.labelMs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMs.Name = "labelMs";
            this.labelMs.Size = new System.Drawing.Size(0, 17);
            this.labelMs.TabIndex = 19;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.White;
            this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignIn.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignIn.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonSignIn.Location = new System.Drawing.Point(181, 558);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(236, 59);
            this.buttonSignIn.TabIndex = 20;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSingIn_Click);
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.BackColor = System.Drawing.Color.White;
            this.buttonSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignOut.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignOut.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonSignOut.Location = new System.Drawing.Point(181, 628);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(236, 59);
            this.buttonSignOut.TabIndex = 21;
            this.buttonSignOut.Text = "Sign Out";
            this.buttonSignOut.UseVisualStyleBackColor = false;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSingOut_Click);
            // 
            // loginField
            // 
            this.loginField.BackColor = System.Drawing.Color.White;
            this.loginField.ForeColor = System.Drawing.Color.OrangeRed;
            this.loginField.Location = new System.Drawing.Point(215, 480);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(202, 22);
            this.loginField.TabIndex = 22;
            // 
            // passField
            // 
            this.passField.BackColor = System.Drawing.Color.White;
            this.passField.ForeColor = System.Drawing.Color.OrangeRed;
            this.passField.Location = new System.Drawing.Point(215, 508);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(202, 22);
            this.passField.TabIndex = 23;
            this.passField.UseSystemPasswordChar = true;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelLogin.Location = new System.Drawing.Point(145, 472);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(60, 30);
            this.labelLogin.TabIndex = 24;
            this.labelLogin.Text = "Login";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelPass.Location = new System.Drawing.Point(111, 502);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(94, 30);
            this.labelPass.TabIndex = 25;
            this.labelPass.Text = "Password";
            // 
            // RegPassField
            // 
            this.RegPassField.BackColor = System.Drawing.Color.White;
            this.RegPassField.ForeColor = System.Drawing.Color.OrangeRed;
            this.RegPassField.Location = new System.Drawing.Point(262, 558);
            this.RegPassField.Name = "RegPassField";
            this.RegPassField.Size = new System.Drawing.Size(202, 22);
            this.RegPassField.TabIndex = 26;
            this.RegPassField.UseSystemPasswordChar = true;
            // 
            // RegLogField
            // 
            this.RegLogField.BackColor = System.Drawing.Color.White;
            this.RegLogField.ForeColor = System.Drawing.Color.OrangeRed;
            this.RegLogField.Location = new System.Drawing.Point(262, 530);
            this.RegLogField.Name = "RegLogField";
            this.RegLogField.Size = new System.Drawing.Size(202, 22);
            this.RegLogField.TabIndex = 27;
            // 
            // labelRegLog
            // 
            this.labelRegLog.AutoSize = true;
            this.labelRegLog.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegLog.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelRegLog.Location = new System.Drawing.Point(85, 524);
            this.labelRegLog.Name = "labelRegLog";
            this.labelRegLog.Size = new System.Drawing.Size(156, 30);
            this.labelRegLog.TabIndex = 28;
            this.labelRegLog.Text = "Enter your login";
            // 
            // labelRegPass
            // 
            this.labelRegPass.AutoSize = true;
            this.labelRegPass.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegPass.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelRegPass.Location = new System.Drawing.Point(46, 553);
            this.labelRegPass.Name = "labelRegPass";
            this.labelRegPass.Size = new System.Drawing.Size(195, 30);
            this.labelRegPass.TabIndex = 29;
            this.labelRegPass.Text = "Enter your password";
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.White;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonRegister.Location = new System.Drawing.Point(181, 601);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(236, 59);
            this.buttonRegister.TabIndex = 30;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(591, 779);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelRegPass);
            this.Controls.Add(this.labelRegLog);
            this.Controls.Add(this.RegLogField);
            this.Controls.Add(this.RegPassField);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.buttonSignOut);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.labelMs);
            this.Controls.Add(this.labelSec);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.PozImage);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SexCheckBox);
            this.Controls.Add(this.OralCheckBox);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.LogoTextImage);
            this.Controls.Add(this.LogoImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.PozImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoTextImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoImage;
        private System.Windows.Forms.PictureBox LogoTextImage;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.CheckBox OralCheckBox;
        private System.Windows.Forms.CheckBox SexCheckBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox PozImage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Label labelMs;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox RegPassField;
        private System.Windows.Forms.TextBox RegLogField;
        private System.Windows.Forms.Label labelRegLog;
        private System.Windows.Forms.Label labelRegPass;
        private System.Windows.Forms.Button buttonRegister;
    }
}

