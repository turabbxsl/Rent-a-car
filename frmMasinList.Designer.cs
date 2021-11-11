namespace MasinKirayesi
{
    partial class frmMasinList
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.combomasinlar = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlegv = new XanderUI.XUIButton();
            this.btnguncelle = new XanderUI.XUIButton();
            this.label4 = new System.Windows.Forms.Label();
            this.odenistxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KMtxt = new System.Windows.Forms.TextBox();
            this.rengtxt = new System.Windows.Forms.TextBox();
            this.Iltxt = new System.Windows.Forms.TextBox();
            this.seriacmb = new System.Windows.Forms.ComboBox();
            this.yanacagcmb = new System.Windows.Forms.ComboBox();
            this.markacmb = new System.Windows.Forms.ComboBox();
            this.nomretxt = new System.Windows.Forms.TextBox();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.btnsil = new XanderUI.XUIButton();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::MasinKirayesi.Properties.Resources.Actions_edit_delete_icon;
            this.button1.Location = new System.Drawing.Point(1177, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 40);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(535, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Masinlarin Siyahisi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(470, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 423);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // combomasinlar
            // 
            this.combomasinlar.FormattingEnabled = true;
            this.combomasinlar.Items.AddRange(new object[] {
            "Butun Masinlar",
            "Bos Masinlar",
            "Dolu Masinlar"});
            this.combomasinlar.Location = new System.Drawing.Point(999, 90);
            this.combomasinlar.Name = "combomasinlar";
            this.combomasinlar.Size = new System.Drawing.Size(235, 24);
            this.combomasinlar.TabIndex = 4;
            this.combomasinlar.SelectedIndexChanged += new System.EventHandler(this.combomasinlar_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(168, 412);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btnlegv
            // 
            this.btnlegv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnlegv.ButtonImage = null;
            this.btnlegv.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnlegv.ButtonText = "Legv Et";
            this.btnlegv.ClickBackColor = System.Drawing.Color.DarkRed;
            this.btnlegv.ClickTextColor = System.Drawing.Color.DarkRed;
            this.btnlegv.CornerRadius = 5;
            this.btnlegv.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlegv.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnlegv.HoverBackgroundColor = System.Drawing.Color.DarkRed;
            this.btnlegv.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnlegv.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnlegv.Location = new System.Drawing.Point(314, 637);
            this.btnlegv.Name = "btnlegv";
            this.btnlegv.Size = new System.Drawing.Size(156, 50);
            this.btnlegv.TabIndex = 43;
            this.btnlegv.TextColor = System.Drawing.Color.DarkRed;
            this.btnlegv.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnguncelle.ButtonImage = null;
            this.btnguncelle.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnguncelle.ButtonText = "Guncelle";
            this.btnguncelle.ClickBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnguncelle.ClickTextColor = System.Drawing.Color.DarkSlateGray;
            this.btnguncelle.CornerRadius = 5;
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnguncelle.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnguncelle.HoverBackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.btnguncelle.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnguncelle.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnguncelle.Location = new System.Drawing.Point(136, 637);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(158, 50);
            this.btnguncelle.TabIndex = 42;
            this.btnguncelle.TextColor = System.Drawing.Color.DarkSlateGray;
            this.btnguncelle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Kiraye Odenisi";
            // 
            // odenistxt
            // 
            this.odenistxt.Location = new System.Drawing.Point(168, 384);
            this.odenistxt.Name = "odenistxt";
            this.odenistxt.Size = new System.Drawing.Size(275, 22);
            this.odenistxt.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Yanacag";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "KM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Rengi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "il";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Seriasi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Markasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nomresi";
            // 
            // KMtxt
            // 
            this.KMtxt.Location = new System.Drawing.Point(168, 291);
            this.KMtxt.Name = "KMtxt";
            this.KMtxt.Size = new System.Drawing.Size(275, 22);
            this.KMtxt.TabIndex = 31;
            // 
            // rengtxt
            // 
            this.rengtxt.Location = new System.Drawing.Point(168, 240);
            this.rengtxt.Name = "rengtxt";
            this.rengtxt.Size = new System.Drawing.Size(275, 22);
            this.rengtxt.TabIndex = 30;
            // 
            // Iltxt
            // 
            this.Iltxt.Location = new System.Drawing.Point(168, 191);
            this.Iltxt.Name = "Iltxt";
            this.Iltxt.Size = new System.Drawing.Size(275, 22);
            this.Iltxt.TabIndex = 29;
            // 
            // seriacmb
            // 
            this.seriacmb.FormattingEnabled = true;
            this.seriacmb.Location = new System.Drawing.Point(168, 145);
            this.seriacmb.Name = "seriacmb";
            this.seriacmb.Size = new System.Drawing.Size(275, 24);
            this.seriacmb.TabIndex = 28;
            // 
            // yanacagcmb
            // 
            this.yanacagcmb.FormattingEnabled = true;
            this.yanacagcmb.Items.AddRange(new object[] {
            "Dizel",
            "Benzin"});
            this.yanacagcmb.Location = new System.Drawing.Point(168, 334);
            this.yanacagcmb.Name = "yanacagcmb";
            this.yanacagcmb.Size = new System.Drawing.Size(275, 24);
            this.yanacagcmb.TabIndex = 27;
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
            this.markacmb.Location = new System.Drawing.Point(168, 101);
            this.markacmb.Name = "markacmb";
            this.markacmb.Size = new System.Drawing.Size(275, 24);
            this.markacmb.TabIndex = 26;
            // 
            // nomretxt
            // 
            this.nomretxt.Location = new System.Drawing.Point(168, 63);
            this.nomretxt.Name = "nomretxt";
            this.nomretxt.Size = new System.Drawing.Size(275, 22);
            this.nomretxt.TabIndex = 25;
            // 
            // xuiButton3
            // 
            this.xuiButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton3.ButtonImage = null;
            this.xuiButton3.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton3.ButtonText = "Sekili Deyisdir";
            this.xuiButton3.ClickBackColor = System.Drawing.Color.WhiteSmoke;
            this.xuiButton3.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton3.CornerRadius = 10;
            this.xuiButton3.Font = new System.Drawing.Font("Monospac821 BT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton3.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton3.Location = new System.Drawing.Point(12, 539);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(145, 50);
            this.xuiButton3.TabIndex = 45;
            this.xuiButton3.TextColor = System.Drawing.Color.RoyalBlue;
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.Click += new System.EventHandler(this.xuiButton3_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnsil.ButtonImage = null;
            this.btnsil.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnsil.ButtonText = "Sil";
            this.btnsil.ClickBackColor = System.Drawing.Color.Red;
            this.btnsil.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnsil.CornerRadius = 200;
            this.btnsil.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnsil.HoverBackgroundColor = System.Drawing.Color.Wheat;
            this.btnsil.HoverTextColor = System.Drawing.Color.Brown;
            this.btnsil.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnsil.Location = new System.Drawing.Point(1071, 560);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(153, 50);
            this.btnsil.TabIndex = 46;
            this.btnsil.TextColor = System.Drawing.Color.Coral;
            this.btnsil.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(471, 589);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 50;
            this.label11.Text = "Veziyyeti";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bos",
            "Dolu"});
            this.comboBox1.Location = new System.Drawing.Point(593, 586);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(275, 24);
            this.comboBox1.TabIndex = 49;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMasinList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1236, 781);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.xuiButton3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlegv);
            this.Controls.Add(this.btnguncelle);
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
            this.Controls.Add(this.combomasinlar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMasinList";
            this.Text = "frmMasinList";
            this.Load += new System.EventHandler(this.frmMasinList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combomasinlar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private XanderUI.XUIButton btnlegv;
        private XanderUI.XUIButton btnguncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox odenistxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KMtxt;
        private System.Windows.Forms.TextBox rengtxt;
        private System.Windows.Forms.TextBox Iltxt;
        private System.Windows.Forms.ComboBox seriacmb;
        private System.Windows.Forms.ComboBox yanacagcmb;
        private System.Windows.Forms.ComboBox markacmb;
        private System.Windows.Forms.TextBox nomretxt;
        private XanderUI.XUIButton xuiButton3;
        private XanderUI.XUIButton btnsil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}