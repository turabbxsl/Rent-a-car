namespace MasinKirayesi
{
    partial class frmMusteriListeleme
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
            this.formDropShadow1 = new XanderUI.FormDropShadow();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnlegvet = new XanderUI.XUIButton();
            this.btnguncelle = new XanderUI.XUIButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.txtaze = new System.Windows.Forms.TextBox();
            this.btnsil = new XanderUI.XUIButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // formDropShadow1
            // 
            this.formDropShadow1.EffectedForm = this;
            this.formDropShadow1.ShadowAngle = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(498, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(822, 424);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnlegvet
            // 
            this.btnlegvet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnlegvet.ButtonImage = global::MasinKirayesi.Properties.Resources.legv;
            this.btnlegvet.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnlegvet.ButtonText = "Legv Et";
            this.btnlegvet.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnlegvet.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnlegvet.CornerRadius = 20;
            this.btnlegvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnlegvet.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnlegvet.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnlegvet.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnlegvet.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnlegvet.Location = new System.Drawing.Point(305, 314);
            this.btnlegvet.Name = "btnlegvet";
            this.btnlegvet.Size = new System.Drawing.Size(165, 50);
            this.btnlegvet.TabIndex = 23;
            this.btnlegvet.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnlegvet.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnlegvet.Click += new System.EventHandler(this.xuiButton2_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnguncelle.ButtonImage = global::MasinKirayesi.Properties.Resources.us;
            this.btnguncelle.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnguncelle.ButtonText = "Guncellemek";
            this.btnguncelle.ClickBackColor = System.Drawing.Color.YellowGreen;
            this.btnguncelle.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnguncelle.CornerRadius = 20;
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnguncelle.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnguncelle.HoverBackgroundColor = System.Drawing.Color.OldLace;
            this.btnguncelle.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnguncelle.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnguncelle.Location = new System.Drawing.Point(92, 314);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(169, 50);
            this.btnguncelle.TabIndex = 22;
            this.btnguncelle.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnguncelle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(12, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 33);
            this.label5.TabIndex = 21;
            this.label5.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 33);
            this.label3.TabIndex = 19;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ad/Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "AZE No";
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(172, 195);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(254, 22);
            this.txtadres.TabIndex = 16;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(172, 253);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(254, 22);
            this.txtemail.TabIndex = 15;
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(172, 138);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(254, 22);
            this.txttelefon.TabIndex = 14;
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(172, 72);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(254, 22);
            this.txtadsoyad.TabIndex = 13;
            // 
            // txtaze
            // 
            this.txtaze.Location = new System.Drawing.Point(172, 16);
            this.txtaze.Name = "txtaze";
            this.txtaze.Size = new System.Drawing.Size(254, 22);
            this.txtaze.TabIndex = 12;
            // 
            // btnsil
            // 
            this.btnsil.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnsil.ButtonImage = null;
            this.btnsil.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnsil.ButtonText = "Sil";
            this.btnsil.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnsil.ClickTextColor = System.Drawing.Color.Crimson;
            this.btnsil.CornerRadius = 5;
            this.btnsil.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnsil.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.btnsil.HoverTextColor = System.Drawing.Color.LightCyan;
            this.btnsil.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnsil.Location = new System.Drawing.Point(1326, 72);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(68, 131);
            this.btnsil.TabIndex = 24;
            this.btnsil.TextColor = System.Drawing.Color.Red;
            this.btnsil.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(528, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 33);
            this.label6.TabIndex = 26;
            this.label6.Text = "AZE No-ne Gore Axtar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(860, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 22);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton1.ButtonImage = null;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton1.ButtonText = "Axtar";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.AntiqueWhite;
            this.xuiButton1.ClickTextColor = System.Drawing.Color.MediumSeaGreen;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.BurlyWood;
            this.xuiButton1.HoverTextColor = System.Drawing.Color.DarkSlateGray;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(1141, 16);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(116, 35);
            this.xuiButton1.TabIndex = 27;
            this.xuiButton1.TextColor = System.Drawing.Color.LightSeaGreen;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::MasinKirayesi.Properties.Resources.Actions_edit_delete_icon;
            this.button1.Location = new System.Drawing.Point(1347, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 40);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMusteriListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1396, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xuiButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnlegvet);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.txtaze);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMusteriListeleme";
            this.Text = "Musterilerin Gosterilmesi";
            this.Load += new System.EventHandler(this.frmMusteriListeleme_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.FormDropShadow formDropShadow1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private XanderUI.XUIButton btnlegvet;
        private XanderUI.XUIButton btnguncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.TextBox txtaze;
        private XanderUI.XUIButton btnsil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private XanderUI.XUIButton xuiButton1;
        private System.Windows.Forms.Button button1;
    }
}