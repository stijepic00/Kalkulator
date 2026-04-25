using System;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class UnitsForm : Form
    {
        string[] tezine = { "Miligram (mg)", "Gram (g)", "Kilogram (kg)", "Tona (t)" };
        string[] duzine = { "Milimetar (mm)", "Centimetar (cm)", "Decimetar (dm)", "Metar (m)", "Kilometar (km)", "Inč (in)" };
        string[] povrsine = { "Kvadratni metar (m2)", "Ar (a)", "Dunum (dnu)", "Hektar (ha)", "Kvadratni kilometar (km2)" };

        public UnitsForm()
        {
            InitializeComponent();
            cmbKategorija.Items.Clear();
            cmbKategorija.Items.Add("Težina");
            cmbKategorija.Items.Add("Dužina");
            cmbKategorija.Items.Add("Površina"); // Nova kategorija

            cmbKategorija.SelectedIndex = -1;
        }


        private void UnitsForm_Load(object sender, EventArgs e)
        {
            // Provjera: da li je ComboBox uopšte kreiran i ima li stavke
            if (cmbKategorija != null && cmbKategorija.Items.Count > 0)
            {
                cmbKategorija.SelectedIndex = 0;
            }
        }

        private void cmbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIzvorna == null || cmbCiljna == null) return;

            cmbIzvorna.Items.Clear();
            cmbCiljna.Items.Clear();

            switch (cmbKategorija.Text)
            {
                case "Težina":
                    cmbIzvorna.Items.AddRange(tezine);
                    cmbCiljna.Items.AddRange(tezine);
                    break;
                case "Dužina":
                    cmbIzvorna.Items.AddRange(duzine);
                    cmbCiljna.Items.AddRange(duzine);
                    break;
                case "Površina": // Novo!
                    cmbIzvorna.Items.AddRange(povrsine);
                    cmbCiljna.Items.AddRange(povrsine);
                    break;
            }

            if (cmbIzvorna.Items.Count > 0) cmbIzvorna.SelectedIndex = 0;
            if (cmbCiljna.Items.Count > 1) cmbCiljna.SelectedIndex = 1;
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtValue.Text)) return;
                if (cmbIzvorna.SelectedItem == null || cmbCiljna.SelectedItem == null) return;

                double unos = double.Parse(txtValue.Text.Replace(",", "."));
                string iz = cmbIzvorna.SelectedItem.ToString();
                string u = cmbCiljna.SelectedItem.ToString();
                double rezultat = 0;

                if (cmbKategorija.Text == "Težina")
                {
                    double uG = iz.Contains("(t)") ? unos * 1000000 : iz.Contains("(kg)") ? unos * 1000 : iz.Contains("(mg)") ? unos / 1000 : unos;
                    rezultat = u.Contains("(t)") ? uG / 1000000 : u.Contains("(kg)") ? uG / 1000 : u.Contains("(mg)") ? uG * 1000 : uG;
                }
                else if (cmbKategorija.Text == "Dužina")
                {
                    // Dodata logika za Inč (1 in = 0.0254 m)
                    double uM = iz.Contains("(mm)") ? unos / 1000.0 : iz.Contains("(cm)") ? unos / 100.0 : iz.Contains("(dm)") ? unos / 10.0 : iz.Contains("(km)") ? unos * 1000.0 : iz.Contains("(in)") ? unos * 0.0254 : unos;
                    rezultat = u.Contains("(mm)") ? uM * 1000.0 : u.Contains("(cm)") ? uM * 100.0 : u.Contains("(dm)") ? uM * 10.0 : u.Contains("(km)") ? uM / 1000.0 : u.Contains("(in)") ? uM / 0.0254 : uM;
                }
                else if (cmbKategorija.Text == "Površina") // Novo!
                {
                    // Sve pretvaramo u m2 (kvadratni metar)
                    double uM2 = iz.Contains("(ha)") ? unos * 10000 : iz.Contains("(dnu)") ? unos * 1000 : iz.Contains("(a)") ? unos * 100 : iz.Contains("(km2)") ? unos * 1000000 : unos;
                    // Iz m2 u ciljnu
                    rezultat = u.Contains("(ha)") ? uM2 / 10000 : u.Contains("(dnu)") ? uM2 / 1000 : u.Contains("(a)") ? uM2 / 100 : u.Contains("(km2)") ? uM2 / 1000000 : uM2;
                }

                // Environment.NewLine forsira prelazak u novi red tamo gdje ti želiš
                lblResult.Text = $"{unos} {iz} {Environment.NewLine} = {rezultat:N2} {u}";
                lblResult.ForeColor = System.Drawing.Color.LimeGreen;
            }
            catch
            {
                MessageBox.Show("Greška: Unesite ispravan broj.");
            }
        }

        private void cmbCiljna_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}