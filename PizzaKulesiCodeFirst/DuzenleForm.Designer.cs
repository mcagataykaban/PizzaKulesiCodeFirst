
namespace PizzaKulesiCodeFirst
{
    partial class DuzenleForm
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
            this.lstPizzalar = new System.Windows.Forms.ListBox();
            this.txtPizzaCesidi = new System.Windows.Forms.TextBox();
            this.btnPizzaEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnPizzaSil = new System.Windows.Forms.Button();
            this.lstMalzemeler = new System.Windows.Forms.ListBox();
            this.btnMalzemeSil = new System.Windows.Forms.Button();
            this.btnMalzemeEkle = new System.Windows.Forms.Button();
            this.txtMalzeme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPizzalar
            // 
            this.lstPizzalar.FormattingEnabled = true;
            this.lstPizzalar.Location = new System.Drawing.Point(12, 65);
            this.lstPizzalar.Name = "lstPizzalar";
            this.lstPizzalar.Size = new System.Drawing.Size(286, 186);
            this.lstPizzalar.TabIndex = 0;
            // 
            // txtPizzaCesidi
            // 
            this.txtPizzaCesidi.Location = new System.Drawing.Point(12, 39);
            this.txtPizzaCesidi.Name = "txtPizzaCesidi";
            this.txtPizzaCesidi.Size = new System.Drawing.Size(173, 20);
            this.txtPizzaCesidi.TabIndex = 1;
            // 
            // btnPizzaEkle
            // 
            this.btnPizzaEkle.BackColor = System.Drawing.Color.Black;
            this.btnPizzaEkle.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnPizzaEkle.Location = new System.Drawing.Point(191, 35);
            this.btnPizzaEkle.Name = "btnPizzaEkle";
            this.btnPizzaEkle.Size = new System.Drawing.Size(49, 26);
            this.btnPizzaEkle.TabIndex = 48;
            this.btnPizzaEkle.Text = "Ekle";
            this.btnPizzaEkle.UseVisualStyleBackColor = false;
            this.btnPizzaEkle.Click += new System.EventHandler(this.btnPizzaEkle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.Black;
            this.btnDuzenle.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnDuzenle.Location = new System.Drawing.Point(13, 266);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(595, 29);
            this.btnDuzenle.TabIndex = 50;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnPizzaSil
            // 
            this.btnPizzaSil.BackColor = System.Drawing.Color.Black;
            this.btnPizzaSil.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnPizzaSil.Location = new System.Drawing.Point(246, 35);
            this.btnPizzaSil.Name = "btnPizzaSil";
            this.btnPizzaSil.Size = new System.Drawing.Size(53, 26);
            this.btnPizzaSil.TabIndex = 49;
            this.btnPizzaSil.Text = "Sil";
            this.btnPizzaSil.UseVisualStyleBackColor = false;
            this.btnPizzaSil.Click += new System.EventHandler(this.btnPizzaSil_Click);
            // 
            // lstMalzemeler
            // 
            this.lstMalzemeler.FormattingEnabled = true;
            this.lstMalzemeler.Location = new System.Drawing.Point(321, 65);
            this.lstMalzemeler.Name = "lstMalzemeler";
            this.lstMalzemeler.Size = new System.Drawing.Size(286, 186);
            this.lstMalzemeler.TabIndex = 51;
            // 
            // btnMalzemeSil
            // 
            this.btnMalzemeSil.BackColor = System.Drawing.Color.Black;
            this.btnMalzemeSil.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnMalzemeSil.Location = new System.Drawing.Point(555, 31);
            this.btnMalzemeSil.Name = "btnMalzemeSil";
            this.btnMalzemeSil.Size = new System.Drawing.Size(53, 26);
            this.btnMalzemeSil.TabIndex = 54;
            this.btnMalzemeSil.Text = "Sil";
            this.btnMalzemeSil.UseVisualStyleBackColor = false;
            this.btnMalzemeSil.Click += new System.EventHandler(this.btnMalzemeSil_Click);
            // 
            // btnMalzemeEkle
            // 
            this.btnMalzemeEkle.BackColor = System.Drawing.Color.Black;
            this.btnMalzemeEkle.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnMalzemeEkle.Location = new System.Drawing.Point(500, 31);
            this.btnMalzemeEkle.Name = "btnMalzemeEkle";
            this.btnMalzemeEkle.Size = new System.Drawing.Size(49, 26);
            this.btnMalzemeEkle.TabIndex = 53;
            this.btnMalzemeEkle.Text = "Ekle";
            this.btnMalzemeEkle.UseVisualStyleBackColor = false;
            this.btnMalzemeEkle.Click += new System.EventHandler(this.btnMalzemeEkle_Click);
            // 
            // txtMalzeme
            // 
            this.txtMalzeme.Location = new System.Drawing.Point(321, 35);
            this.txtMalzeme.Name = "txtMalzeme";
            this.txtMalzeme.Size = new System.Drawing.Size(173, 20);
            this.txtMalzeme.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(9, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "Pizza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(317, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Ekstra Malzeme";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Black;
            this.btnKaydet.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnKaydet.Location = new System.Drawing.Point(12, 266);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(285, 29);
            this.btnKaydet.TabIndex = 57;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Visible = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Black;
            this.btnIptal.ForeColor = System.Drawing.Color.BurlyWood;
            this.btnIptal.Location = new System.Drawing.Point(321, 266);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(287, 29);
            this.btnIptal.TabIndex = 58;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // DuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 308);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnMalzemeSil);
            this.Controls.Add(this.btnMalzemeEkle);
            this.Controls.Add(this.txtMalzeme);
            this.Controls.Add(this.lstMalzemeler);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnPizzaSil);
            this.Controls.Add(this.btnPizzaEkle);
            this.Controls.Add(this.txtPizzaCesidi);
            this.Controls.Add(this.lstPizzalar);
            this.MinimumSize = new System.Drawing.Size(634, 347);
            this.Name = "DuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PizzaCesidiDuzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPizzalar;
        private System.Windows.Forms.TextBox txtPizzaCesidi;
        private System.Windows.Forms.Button btnPizzaEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnPizzaSil;
        private System.Windows.Forms.ListBox lstMalzemeler;
        private System.Windows.Forms.Button btnMalzemeSil;
        private System.Windows.Forms.Button btnMalzemeEkle;
        private System.Windows.Forms.TextBox txtMalzeme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
    }
}