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
            this.timeLabel = new System.Windows.Forms.Label();
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
            this.OralCheckBox.Location = new System.Drawing.Point(157, 577);
            this.OralCheckBox.Name = "OralCheckBox";
            this.OralCheckBox.Size = new System.Drawing.Size(159, 29);
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
            this.SexCheckBox.Location = new System.Drawing.Point(157, 542);
            this.SexCheckBox.Name = "SexCheckBox";
            this.SexCheckBox.Size = new System.Drawing.Size(113, 29);
            this.SexCheckBox.TabIndex = 6;
            this.SexCheckBox.Text = "Секс позы";
            this.SexCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.ExitButton.Location = new System.Drawing.Point(419, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(24, 23);
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
            this.PozImage.Location = new System.Drawing.Point(108, 162);
            this.PozImage.Name = "PozImage";
            this.PozImage.Size = new System.Drawing.Size(229, 191);
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
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(64, 36);
            this.BackButton.TabIndex = 15;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Generate
            // 
            this.Generate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Generate.BackgroundImage")));
            this.Generate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Generate.Location = new System.Drawing.Point(87, 449);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(272, 55);
            this.Generate.TabIndex = 2;
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // LogoTextImage
            // 
            this.LogoTextImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoTextImage.BackgroundImage")));
            this.LogoTextImage.Location = new System.Drawing.Point(54, 261);
            this.LogoTextImage.Name = "LogoTextImage";
            this.LogoTextImage.Size = new System.Drawing.Size(340, 68);
            this.LogoTextImage.TabIndex = 1;
            this.LogoTextImage.TabStop = false;
            // 
            // LogoImage
            // 
            this.LogoImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogoImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoImage.BackgroundImage")));
            this.LogoImage.ErrorImage = null;
            this.LogoImage.InitialImage = null;
            this.LogoImage.Location = new System.Drawing.Point(122, 12);
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.Size = new System.Drawing.Size(203, 192);
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
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(184, 356);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 13);
            this.timeLabel.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(443, 633);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.PozImage);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SexCheckBox);
            this.Controls.Add(this.OralCheckBox);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.LogoTextImage);
            this.Controls.Add(this.LogoImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label timeLabel;
    }
}

