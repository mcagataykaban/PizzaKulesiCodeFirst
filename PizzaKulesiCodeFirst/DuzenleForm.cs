using PizzaKulesiCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaKulesiCodeFirst
{
    public partial class DuzenleForm : Form
    {
        public event EventHandler DegisiklikYapildi;
        private readonly PizzaKulesiContext db;

        public DuzenleForm(PizzaKulesiContext db)
        {
            this.db = db;
            InitializeComponent();
            PizzalariListele();
            MalzemeleriListele();
        }
        protected virtual void DegisiklikYapildiginda(EventArgs args)
        {
            DegisiklikYapildi?.Invoke(this, args);
        }

        private void MalzemeleriListele()
        {
            lstMalzemeler.DataSource = db.EkstraMalzemeler.ToList();
        }

        private void PizzalariListele()
        {
            lstPizzalar.DataSource = db.Pizzalar.ToList();
        }

        private void btnPizzaEkle_Click(object sender, EventArgs e)
        {
            if (txtPizzaCesidi.Text == "")
            {
                MessageBox.Show("Pizza çeşidi gir");
                return;
            }
            db.Pizzalar.Add(new Pizza { Cesit = txtPizzaCesidi.Text });
            db.SaveChanges();
            txtPizzaCesidi.Clear();
            PizzalariListele();
            DegisiklikYapildiginda(EventArgs.Empty);
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            if (txtMalzeme.Text == "")
            {
                MessageBox.Show("Malzeme adı gir");
                return;
            }
            db.EkstraMalzemeler.Add(new EkstraMalzeme { MalzemeAd = txtMalzeme.Text });
            db.SaveChanges();
            txtMalzeme.Clear();
            MalzemeleriListele();
            DegisiklikYapildiginda(EventArgs.Empty);

        }

        private void btnPizzaSil_Click(object sender, EventArgs e)
        {
            if (lstPizzalar.SelectedIndex < 0)
                return;
            var secilenPizza = (Pizza)lstPizzalar.SelectedItem;
            db.Pizzalar.Remove(secilenPizza);
            db.SaveChanges();
            PizzalariListele();
            DegisiklikYapildiginda(EventArgs.Empty);

        }

        private void btnMalzemeSil_Click(object sender, EventArgs e)
        {
            if (lstMalzemeler.SelectedIndex < 0)
                return;
            var secilenMalzeme = (EkstraMalzeme)lstMalzemeler.SelectedItem;
            db.EkstraMalzemeler.Remove(secilenMalzeme);
            db.SaveChanges();
            MalzemeleriListele();
            DegisiklikYapildiginda(EventArgs.Empty);

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            //Düzenle moduna geç
            btnIptal.Visible = btnKaydet.Visible = true;
            btnDuzenle.Visible = false;
            var secilenPizza = (Pizza)lstPizzalar.SelectedItem;
            var secilenMalzeme = (EkstraMalzeme)lstMalzemeler.SelectedItem;
            txtMalzeme.Text = secilenMalzeme.MalzemeAd;
            txtPizzaCesidi.Text = secilenPizza.Cesit;
            btnMalzemeEkle.Enabled = btnPizzaEkle.Enabled = btnMalzemeSil.Enabled = btnPizzaSil.Enabled = false;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtPizzaCesidi.Text == "" || txtMalzeme.Text == "")
            {
                MessageBox.Show("Bilgileri gir");
                return;
            }
            var secilenPizza = (Pizza)lstPizzalar.SelectedItem;
            var secilenMalzeme = (EkstraMalzeme)lstMalzemeler.SelectedItem;

            secilenPizza.Cesit = txtPizzaCesidi.Text;
            secilenMalzeme.MalzemeAd = txtMalzeme.Text;
            db.SaveChanges();
            FormuResetle();
            DegisiklikYapildiginda(EventArgs.Empty);
        }

        private void FormuResetle()
        {
            MalzemeleriListele();
            PizzalariListele();
            txtMalzeme.Clear();
            txtPizzaCesidi.Clear();
            btnDuzenle.Visible = true;
            btnIptal.Visible = btnKaydet.Visible = false;
            btnMalzemeEkle.Enabled = btnPizzaEkle.Enabled = btnMalzemeSil.Enabled = btnPizzaSil.Enabled = true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuResetle();
        }
    }
}
