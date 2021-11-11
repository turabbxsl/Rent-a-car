namespace MasinKirayesi
{
    partial class frmMasinElavesi
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
            this.nomretxt = new System.Windows.Forms.TextBox();
            this.markacmb = new System.Windows.Forms.ComboBox();
            this.seriacmb = new System.Windows.Forms.ComboBox();
            this.Iltxt = new System.Windows.Forms.TextBox();
            this.rengtxt = new System.Windows.Forms.TextBox();
            this.KMtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.odenistxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsekil = new XanderUI.XUIButton();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.button1 = new System.Windows.Forms.Button();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.yanacagcmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 LtEx BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Masinlarin Qeydiyyati";
            // 
            // nomretxt
            // 
            this.nomretxt.Location = new System.Drawing.Point(174, 67);
            this.nomretxt.Name = "nomretxt";
            this.nomretxt.Size = new System.Drawing.Size(275, 22);
            this.nomretxt.TabIndex = 2;
            // 
            // markacmb
            // 
            this.markacmb.FormattingEnabled = true;
            this.markacmb.Items.AddRange(new object[] {
            "Mersedes Benz",
            "BMW",
            "Nissan",
            "Tayota",
            "VAZ",
            "Ford",
            "Renault",
            "Fiat",
            "Opel"});
            this.markacmb.Location = new System.Drawing.Point(174, 128);
            this.markacmb.Name = "markacmb";
            this.markacmb.Size = new System.Drawing.Size(275, 24);
            this.markacmb.TabIndex = 3;
            this.markacmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // seriacmb
            // 
            this.seriacmb.FormattingEnabled = true;
            this.seriacmb.Location = new System.Drawing.Point(174, 191);
            this.seriacmb.Name = "seriacmb";
            this.seriacmb.Size = new System.Drawing.Size(275, 24);
            this.seriacmb.TabIndex = 5;
            // 
            // Iltxt
            // 
            this.Iltxt.Location = new System.Drawing.Point(174, 254);
            this.Iltxt.Name = "Iltxt";
            this.Iltxt.Size = new System.Drawing.Size(275, 22);
            this.Iltxt.TabIndex = 6;
            // 
            // rengtxt
            // 
            this.rengtxt.Location = new System.Drawing.Point(174, 315);
            this.rengtxt.Name = "rengtxt";
            this.rengtxt.Size = new System.Drawing.Size(275, 22);
            this.rengtxt.TabIndex = 7;
            // 
            // KMtxt
            // 
            this.KMtxt.Location = new System.Drawing.Point(174, 382);
            this.KMtxt.Name = "KMtxt";
            this.KMtxt.Size = new System.Drawing.Size(275, 22);
            this.KMtxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nomresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Markasi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Seriasi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "il";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Rengi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "KM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Yanacag";
            // 
            // odenistxt
            // 
            this.odenistxt.Location = new System.Drawing.Point(174, 502);
            this.odenistxt.Name = "odenistxt";
            this.odenistxt.Size = new System.Drawing.Size(275, 22);
            this.odenistxt.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Kiraye Odenisi";
            // 
            // btnsekil
            // 
            this.btnsekil.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnsekil.ButtonImage = null;
            this.btnsekil.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnsekil.ButtonText = "Sekil Elave Et";
            this.btnsekil.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.btnsekil.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnsekil.CornerRadius = 5;
            this.btnsekil.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsekil.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnsekil.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnsekil.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnsekil.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnsekil.Location = new System.Drawing.Point(516, 315);
            this.btnsekil.Name = "btnsekil";
            this.btnsekil.Size = new System.Drawing.Size(239, 50);
            this.btnsekil.TabIndex = 20;
            this.btnsekil.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnsekil.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnsekil.Click += new System.EventHandler(this.btnsekil_Click);
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton1.ButtonImage = null;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.xuiButton1.ButtonText = "Legv Et";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.DarkRed;
            this.xuiButton1.ClickTextColor = System.Drawing.Color.DarkRed;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.DarkRed;
            this.xuiButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(328, 644);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(156, 50);
            this.xuiButton1.TabIndex = 22;
            this.xuiButton1.TextColor = System.Drawing.Color.DarkRed;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::MasinKirayesi.Properties.Resources.Actions_edit_delete_icon;
            this.button1.Location = new System.Drawing.Point(761, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 40);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xuiButton2
            // 
            this.xuiButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton2.ButtonImage = null;
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.xuiButton2.ButtonText = "Qeydiyyat";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.OliveDrab;
            this.xuiButton2.ClickTextColor = System.Drawing.Color.OliveDrab;
            this.xuiButton2.CornerRadius = 5;
            this.xuiButton2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.OliveDrab;
            this.xuiButton2.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(139, 644);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(158, 50);
            this.xuiButton2.TabIndex = 21;
            this.xuiButton2.TextColor = System.Drawing.Color.OliveDrab;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.Click += new System.EventHandler(this.xuiButton2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(475, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(52, 554);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "Veziyyeti";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bos",
            "Dolu"});
            this.comboBox1.Location = new System.Drawing.Point(174, 551);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(275, 24);
            this.comboBox1.TabIndex = 51;
            // 
            // yanacagcmb
            // 
            this.yanacagcmb.FormattingEnabled = true;
            this.yanacagcmb.Items.AddRange(new object[] {
            "Dizel",
            "Benzin"});
            this.yanacagcmb.Location = new System.Drawing.Point(174, 443);
            this.yanacagcmb.Name = "yanacagcmb";
            this.yanacagcmb.Size = new System.Drawing.Size(275, 24);
            this.yanacagcmb.TabIndex = 4;
            // 
            // frmMasinElavesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(126)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(826, 721);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.xuiButton1);
            this.Controls.Add(this.xuiButton2);
            this.Controls.Add(this.btnsekil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.odenistxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KMtxt);
            this.Controls.Add(this.rengtxt);
            this.Controls.Add(this.Iltxt);
            this.Controls.Add(this.seriacmb);
            this.Controls.Add(this.yanacagcmb);
            this.Controls.Add(this.markacmb);
            this.Controls.Add(this.nomretxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMasinElavesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMasinElavesi";
            this.Load += new System.EventHandler(this.frmMasinElavesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomretxt;
        private System.Windows.Forms.ComboBox markacmb;
        private System.Windows.Forms.ComboBox seriacmb;
        private System.Windows.Forms.TextBox Iltxt;
        private System.Windows.Forms.TextBox rengtxt;
        private System.Windows.Forms.TextBox KMtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox odenistxt;
        private System.Windows.Forms.Label label4;
        private XanderUI.XUIButton btnsekil;
        private XanderUI.XUIButton xuiButton1;
        private XanderUI.XUIButton xuiButton2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox yanacagcmb;
    }
}