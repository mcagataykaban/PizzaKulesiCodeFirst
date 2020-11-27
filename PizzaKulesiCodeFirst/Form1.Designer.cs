
namespace PizzaKulesiCodeFirst
{
    partial class Form1
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
            if (disposing)
            {
                db.Dispose();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chkTeslimEdilenleriGizle = new System.Windows.Forms.CheckBox();
            this.chkTeslim = new System.Windows.Forms.CheckBox();
            this.btnEkstraMalzeme = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnPizzaCesidi = new System.Windows.Forms.Button();
            this.cboPizzaCesidi = new System.Windows.Forms.ComboBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtMusteriAdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clbMalzeme = new System.Windows.Forms.CheckedListBox();
            this.cboMusteri = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSiparis = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnMusteriDuzenle = new System.Windows.Forms.Button();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparis)).BeginInit();
            this.SuspendLayout();
            // 
            // chkTeslimEdilenleriGizle
            // 
            this.chkTeslimEdilenleriGizle.AutoSize = true;
            this.chkTeslimEdilenleriGizle.Location = new System.Drawing.Point(682, 26);
            this.chkTeslimEdilenleriGizle.Name = "chkTeslimEdilenleriGizle";
            this.chkTeslimEdilenleriGizle.Size = new System.Drawing.Size(127, 17);
            this.chkTeslimEdilenleriGizle.TabIndex = 37;
            this.chkTeslimEdilenleriGizle.Text = "Teslim Edilenleri Gizle";
            this.chkTeslimEdilenleriGizle.UseVisualStyleBackColor = true;
            this.chkTeslimEdilenleriGizle.CheckedChanged += new System.EventHandler(this.chkTeslimEdilenleriGizle_CheckedChanged);
            // 
            // chkTeslim
            // 
            this.chkTeslim.AutoSize = true;
            this.chkTeslim.Location = new System.Drawing.Point(21, 483);
            this.chkTeslim.Name = "chkTeslim";
            this.chkTeslim.Size = new System.Drawing.Size(84, 17);
            this.chkTeslim.TabIndex = 36;
            this.chkTeslim.Text = "Teslim Edildi";
            this.chkTeslim.UseVisualStyleBackColor = true;
            // 
            // btnEkstraMalzeme
            // 
            this.btnEkstraMalzeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkstraMalzeme.Location = new System.Drawing.Point(208, 339);
            this.btnEkstraMalzeme.Name = "btnEkstraMalzeme";
            this.btnEkstraMalzeme.Size = new System.Drawing.Size(61, 23);
            this.btnEkstraMalzeme.TabIndex = 31;
            this.btnEkstraMalzeme.Text = "+";
            this.btnEkstraMalzeme.UseVisualStyleBackColor = true;
            this.btnEkstraMalzeme.Click += new System.EventHandler(this.btnEkstraMalzeme_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzenle.BackColor = System.Drawing.Color.Black;
            this.btnDuzenle.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnDuzenle.Location = new System.Drawing.Point(736, 473);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(75, 34);
            this.btnDuzenle.TabIndex = 30;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.BackColor = System.Drawing.Color.Black;
            this.btnSil.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnSil.Location = new System.Drawing.Point(655, 473);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 34);
            this.btnSil.TabIndex = 29;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Black;
            this.btnEkle.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnEkle.Location = new System.Drawing.Point(194, 471);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 34);
            this.btnEkle.TabIndex = 28;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnPizzaCesidi
            // 
            this.btnPizzaCesidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPizzaCesidi.Location = new System.Drawing.Point(208, 282);
            this.btnPizzaCesidi.Name = "btnPizzaCesidi";
            this.btnPizzaCesidi.Size = new System.Drawing.Size(61, 23);
            this.btnPizzaCesidi.TabIndex = 27;
            this.btnPizzaCesidi.Text = "+";
            this.btnPizzaCesidi.UseVisualStyleBackColor = true;
            this.btnPizzaCesidi.Click += new System.EventHandler(this.btnPizzaCesidi_Click);
            // 
            // cboPizzaCesidi
            // 
            this.cboPizzaCesidi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPizzaCesidi.FormattingEnabled = true;
            this.cboPizzaCesidi.Location = new System.Drawing.Point(20, 308);
            this.cboPizzaCesidi.Name = "cboPizzaCesidi";
            this.cboPizzaCesidi.Size = new System.Drawing.Size(249, 21);
            this.cboPizzaCesidi.TabIndex = 26;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(19, 98);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(250, 80);
            this.txtAdres.TabIndex = 25;
            // 
            // txtMusteriAdSoyad
            // 
            this.txtMusteriAdSoyad.Location = new System.Drawing.Point(19, 53);
            this.txtMusteriAdSoyad.Name = "txtMusteriAdSoyad";
            this.txtMusteriAdSoyad.Size = new System.Drawing.Size(250, 20);
            this.txtMusteriAdSoyad.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Teslimat Adresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Eksta Malzemeler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Pizza Çeşidi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Müşteri Ekle";
            // 
            // clbMalzeme
            // 
            this.clbMalzeme.CheckOnClick = true;
            this.clbMalzeme.FormattingEnabled = true;
            this.clbMalzeme.Location = new System.Drawing.Point(20, 371);
            this.clbMalzeme.Name = "clbMalzeme";
            this.clbMalzeme.Size = new System.Drawing.Size(249, 94);
            this.clbMalzeme.TabIndex = 38;
            // 
            // cboMusteri
            // 
            this.cboMusteri.DisplayMember = "AdSoyad";
            this.cboMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMusteri.FormattingEnabled = true;
            this.cboMusteri.Location = new System.Drawing.Point(21, 252);
            this.cboMusteri.Name = "cboMusteri";
            this.cboMusteri.Size = new System.Drawing.Size(248, 21);
            this.cboMusteri.TabIndex = 39;
            this.cboMusteri.ValueMember = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Müşteri Seç";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(20, 184);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(116, 23);
            this.btnMusteriEkle.TabIndex = 41;
            this.btnMusteriEkle.Text = "Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Ad Soyad";
            // 
            // dgvSiparis
            // 
            this.dgvSiparis.AllowUserToAddRows = false;
            this.dgvSiparis.AllowUserToDeleteRows = false;
            this.dgvSiparis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSiparis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSiparis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSiparis.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSiparis.Location = new System.Drawing.Point(275, 49);
            this.dgvSiparis.MultiSelect = false;
            this.dgvSiparis.Name = "dgvSiparis";
            this.dgvSiparis.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSiparis.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSiparis.RowHeadersVisible = false;
            this.dgvSiparis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparis.Size = new System.Drawing.Size(534, 416);
            this.dgvSiparis.TabIndex = 45;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Id";
            this.Column5.HeaderText = "Id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Musteri";
            this.Column1.HeaderText = "AdSoyad";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Pizza";
            this.Column2.HeaderText = "Pizza";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "VirgulluMalzeme";
            this.Column3.HeaderText = "EkstraMalzemler";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TeslimDurumu";
            this.Column4.HeaderText = "TeslimDurumu";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "AdresiYaz";
            this.Column6.HeaderText = "Adres";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(17, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Sipariş Ekle";
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Black;
            this.btnIptal.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnIptal.Location = new System.Drawing.Point(113, 471);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 34);
            this.btnIptal.TabIndex = 47;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnMusteriDuzenle
            // 
            this.btnMusteriDuzenle.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnMusteriDuzenle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMusteriDuzenle.Location = new System.Drawing.Point(175, 227);
            this.btnMusteriDuzenle.Name = "btnMusteriDuzenle";
            this.btnMusteriDuzenle.Size = new System.Drawing.Size(94, 23);
            this.btnMusteriDuzenle.TabIndex = 48;
            this.btnMusteriDuzenle.Text = "Müşteri Düzenle";
            this.btnMusteriDuzenle.UseVisualStyleBackColor = false;
            this.btnMusteriDuzenle.Click += new System.EventHandler(this.btnMusteriDuzenle_Click);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Enabled = false;
            this.btnMusteriSil.Location = new System.Drawing.Point(153, 184);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(116, 23);
            this.btnMusteriSil.TabIndex = 49;
            this.btnMusteriSil.Text = "Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 519);
            this.Controls.Add(this.btnMusteriSil);
            this.Controls.Add(this.btnMusteriDuzenle);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvSiparis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboMusteri);
            this.Controls.Add(this.clbMalzeme);
            this.Controls.Add(this.chkTeslimEdilenleriGizle);
            this.Controls.Add(this.chkTeslim);
            this.Controls.Add(this.btnEkstraMalzeme);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnPizzaCesidi);
            this.Controls.Add(this.cboPizzaCesidi);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtMusteriAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(837, 558);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Kulesi ( Pizza Sipariş Takip Sistemi )";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkTeslimEdilenleriGizle;
        private System.Windows.Forms.CheckBox chkTeslim;
        private System.Windows.Forms.Button btnEkstraMalzeme;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnPizzaCesidi;
        private System.Windows.Forms.ComboBox cboPizzaCesidi;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtMusteriAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbMalzeme;
        private System.Windows.Forms.ComboBox cboMusteri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvSiparis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnMusteriDuzenle;
        private System.Windows.Forms.Button btnMusteriSil;
    }
}

