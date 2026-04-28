using Kalkulator;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat_kalkulator
{
    public partial class Form1 : Form
    {
        double trenutniEurKurs = 1.95583;
        double trenutniUsdKurs = 1.80;
        string izvorPodataka = "fiksni kurs (CBBiH)";
        string zadnjeAzuriranje = "nikada (koristi se lokalni kurs)";
        bool prikazanRezultat = false;
        bool napredniMod = false;
        bool cleanMode = false;
        DataTable dt = new DataTable();

        // Liste jedinica za lakše filtriranje
        string[] valute = { "Euro (EUR)", "BAM (BAM)", "Dolar (USD)", "Kuna (HRK)" };
        string[] tezine = { "Miligram (mg)", "Gram (g)", "Kilogram (kg)", "Tona (t)" };
        string[] duzine = { "Milimetar (mm)", "Centimetar (cm)", "Decimetar (dm)", "Metar (m)", "Kilometar (km)" };

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public class API_Response
        {
            public string base_code { get; set; }
            public Dictionary<string, double> conversion_rates { get; set; }
        }

        private async Task AzurirajKurseveSaInterneta()
        {
            try
            {
                using (HttpClient klijent = new HttpClient())
                {
                    // Koristi pouzdaniji API (npr. exchangerate-api.com - zahtijeva besplatan ključ)
                    // Za testiranje, osiguraj da URL zaista vraća JSON
                    string url = "https://open.er-api.com/v6/latest/BAM";
                    string jsonRezultat = await klijent.GetStringAsync(url);

                    var podaci = JsonConvert.DeserializeObject<dynamic>(jsonRezultat);

                    // API koji sam naveo iznad koristi "rates" ili "rates" polje
                    if (podaci != null && podaci.rates != null)
                    {
                        // Uzimamo direktne vrijednosti jer je baza BAM (1 BAM = X EUR)
                        double bamToEur = (double)podaci.rates.EUR;
                        double bamToUsd = (double)podaci.rates.USD;

                        // Ako je baza BAM, onda je kurs za množenje (npr. 0.511)
                        // Da dobiješ koliko je 1 EUR u BAM-ovima (1.95):
                        trenutniEurKurs = 1.0 / bamToEur;
                        trenutniUsdKurs = 1.0 / bamToUsd;

                        lblStatusKursa.Invoke((MethodInvoker)delegate {
                            lblStatusKursa.Text = $"Internet kurs: EUR={trenutniEurKurs:F2} USD={trenutniUsdKurs:F2}";
                            lblStatusKursa.ForeColor = Color.Lime;
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                // Ako nema interneta, koristi fiksne vrijednosti
                izvorPodataka = "fiksni kurs (offline)";
                lblStatusKursa.Text = "Offline - koriste se fiksni kursevi";
            }
        }

        // ==================== FUNKCIJA ZA PROMJENU TEME ====================
        private void PostaviTemu(Color bojaPozadine, Color bojaTeksta, Color bojaDugmadi)
        {
            this.BackColor = bojaPozadine;
            bool isLightMode = (bojaPozadine == SystemColors.Control);

            foreach (Control c in this.Controls)
            {
                if (c is Button btn)
                {
                    bool jeSpecijalnoDugme = (btn == btnPlus || btn == btnMinus || btn == btnMultiply ||
                                             btn == btnDivide || btn == btnClear || btn == btnAdvanced ||
                                             btn == btnSqrt || btn == btnSquare || btn == btnInverse ||
                                             btn == btnPercent || btn == btnDot || btn == btnEquals);

                    if (jeSpecijalnoDugme)
                    {
                        btn.ForeColor = isLightMode ? Color.Black : Color.White;
                        btn.UseVisualStyleBackColor = false;
                        continue;
                    }

                    if (btn.Text.Length == 1 && char.IsDigit(btn.Text[0]))
                    {
                        btn.BackColor = isLightMode ? Color.LightGray : bojaDugmadi;
                        btn.ForeColor = isLightMode ? Color.Black : bojaTeksta;
                        btn.UseVisualStyleBackColor = false;
                        continue;
                    }

                    btn.BackColor = bojaDugmadi;
                    btn.ForeColor = bojaTeksta;
                    btn.UseVisualStyleBackColor = false;
                }
                else if (c is TextBox txt)
                {
                    txt.BackColor = isLightMode ? Color.White : bojaDugmadi;
                    if (txt.ForeColor != Color.Lime) txt.ForeColor = bojaTeksta;
                }
            }
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            PostaviTemu(Color.FromArgb(45, 45, 48), Color.White, Color.FromArgb(30, 30, 30));
        }

        private void btnLightMode_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            txtDisplay.BackColor = Color.White;
            txtDisplay.ForeColor = Color.Black;

            foreach (Control c in this.Controls)
            {
                if (c is Button btn)
                {
                    if (btn.Text.Length == 1 && char.IsDigit(btn.Text[0]))
                    {
                        btn.BackColor = Color.LightGray;
                        btn.ForeColor = Color.Black;
                        btn.UseVisualStyleBackColor = false;
                    }
                    else if (btn == btnDot || btn.Text == ",")
                    {
                        btn.BackColor = SystemColors.Control;
                        btn.ForeColor = Color.Black;
                        btn.UseVisualStyleBackColor = false;
                    }
                    else
                    {
                        btn.UseVisualStyleBackColor = true;
                        btn.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void FixBrojeve()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button btn)
                {
                    if (btn.Text.Length == 1 && char.IsDigit(btn.Text[0]))
                    {
                        btn.BackColor = Color.LightGray;
                    }
                    else if (btn == btnDot || btn.Text == ",")
                    {
                        btn.BackColor = SystemColors.Control;
                    }
                }
            }
        }

        // ==================== LOGIKA RAČUNANJA ====================
        private void Izracunaj()
        {
            try
            {
                string izrazZaBazu = txtDisplay.Text;
                double r = EvalNapredni(izrazZaBazu);

                prikazanRezultat = true;
                txtDisplay.ForeColor = Color.Lime;
                txtDisplay.Text = r.ToString().Replace(".", ",");
                prikazanRezultat = false;

                string rezultatZaBazu = r.ToString();
                Task.Run(() => SacuvajUBazu(izrazZaBazu, rezultatZaBazu));
            }
            catch (Exception ex)
            {
                txtDisplay.Text = "Greška!";
                Console.WriteLine(ex.Message);
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm f = new HistoryForm();
            f.Show();
        }

        private void DodajZnak(string znak)
        {
            if (prikazanRezultat)
            {
                txtDisplay.Text = "";
                prikazanRezultat = false;
            }

            if (txtDisplay.Text == "0" && znak != "," && !znak.Contains(" "))
            {
                txtDisplay.Text = znak;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + znak;
            }

            txtDisplay.Focus();
            txtDisplay.SelectionStart = txtDisplay.Text.Length;
        }

        private double EvalNapredni(string izraz)
        {
            // Očisti izraz od razmaka i pretvori zareze u tačke
            string tmp = izraz.Replace(" ", "").Replace(",", ".");

            try
            {
                // Specijalne funkcije
                if (tmp.Contains("√"))
                {
                    return Math.Sqrt(double.Parse(tmp.Replace("√", ""), System.Globalization.CultureInfo.InvariantCulture));
                }
                // ... ostale provjere ...

                // OSIGURAJ TAČKU ZA DATATABLE
                var rezultat = dt.Compute(tmp, "");
                return Convert.ToDouble(rezultat);
            }
            catch
            {
                throw new Exception("Greška u matematičkom izrazu");
            }
        }

        // ==================== BROJEVI I OPERACIJE ====================
        private void btn1_Click(object sender, EventArgs e) { DodajZnak("1"); }
        private void btn2_Click(object sender, EventArgs e) { DodajZnak("2"); }
        private void btn3_Click(object sender, EventArgs e) { DodajZnak("3"); }
        private void btn4_Click(object sender, EventArgs e) { DodajZnak("4"); }
        private void btn5_Click(object sender, EventArgs e) { DodajZnak("5"); }
        private void btn6_Click(object sender, EventArgs e) { DodajZnak("6"); }
        private void btn7_Click(object sender, EventArgs e) { DodajZnak("7"); }
        private void btn8_Click(object sender, EventArgs e) { DodajZnak("8"); }
        private void btn9_Click(object sender, EventArgs e) { DodajZnak("9"); }
        private void btn0_Click(object sender, EventArgs e) { DodajZnak("0"); }
        private void btnDot_Click(object sender, EventArgs e) { if (!txtDisplay.Text.EndsWith(" ")) DodajZnak(","); }

        private void btnPlus_Click(object sender, EventArgs e) { DodajZnak(" + "); }
        private void btnMinus_Click(object sender, EventArgs e) { DodajZnak(" - "); }
        private void btnMultiply_Click(object sender, EventArgs e) { DodajZnak(" * "); }
        private void btnDivide_Click(object sender, EventArgs e) { DodajZnak(" / "); }

        private void btnEquals_Click(object sender, EventArgs e) { Izracunaj(); }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            txtDisplay.ForeColor = (this.BackColor == Color.FromArgb(45, 45, 48)) ? Color.White : Color.Black;
            txtDisplay.Focus();
            txtDisplay.SelectionLength = 0;
        }

        // ==================== TASTATURA ====================
        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '=' || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Izracunaj();
                return;
            }

            if (e.KeyChar == (char)Keys.Back) return;

            if (txtDisplay.Text == "0" && char.IsDigit(e.KeyChar))
            {
                txtDisplay.Text = e.KeyChar.ToString();
                e.Handled = true;
                txtDisplay.SelectionStart = txtDisplay.Text.Length;
                return;
            }

            if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
            {
                e.Handled = true;
                DodajZnak(" " + e.KeyChar + " ");
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; Izracunaj(); }
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete) btnClear_Click(sender, e);
            if (e.KeyCode == Keys.C) btnClear_Click(sender, e);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            txtDisplay.Focus();
            txtDisplay.SelectionStart = txtDisplay.Text.Length;
            txtDisplay.SelectionLength = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (prikazanRezultat) return;
            txtDisplay.ForeColor = (this.BackColor == Color.FromArgb(45, 45, 48)) ? Color.White : Color.Black;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;

            txtDisplay.Text = "0";
            ResetujListe();
            cmbIzvorna.SelectedIndex = -1;
            cmbCiljna.SelectedIndex = -1;

            await AzurirajKurseveSaInterneta();
        }

        private void ResetujListe()
        {
            cmbIzvorna.Items.Clear();
            cmbCiljna.Items.Clear();

            cmbIzvorna.Items.AddRange(valute);
            cmbIzvorna.Items.AddRange(tezine);
            cmbIzvorna.Items.AddRange(duzine);

            cmbCiljna.Items.AddRange(valute);
            cmbCiljna.Items.AddRange(tezine);
            cmbCiljna.Items.AddRange(duzine);
        }

        private void SacuvajUBazu(string izraz, string rezultat)
        {
            try
            {
                string connectionString = "Server=DESKTOP-J73S4GL;Database=KalkulatorDB;Trusted_Connection=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Istorija (Izraz, Rezultat, Datum) VALUES (@Izraz, @Rezultat, @Datum)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Izraz", izraz);
                    cmd.Parameters.AddWithValue("@Rezultat", rezultat);
                    cmd.Parameters.AddWithValue("@Datum", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("SQL Greška: " + ex.Message);
            }
        }

        private void btnHistory_Click_1(object sender, EventArgs e)
        {
            HistoryForm f = new HistoryForm();
            f.Show();
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            napredniMod = !napredniMod;

            if (napredniMod)
            {
                btnPlus.Visible = false;
                btnMinus.Visible = false;
                btnMultiply.Visible = false;
                btnDivide.Visible = false;

                btnSqrt.Visible = true;
                btnSquare.Visible = true;
                btnInverse.Visible = true;
                btnPercent.Visible = true;

                btnAdvanced.Text = "Osnovno";
            }
            else
            {
                btnPlus.Visible = true;
                btnMinus.Visible = true;
                btnMultiply.Visible = true;
                btnDivide.Visible = true;

                btnSqrt.Visible = false;
                btnSquare.Visible = false;
                btnInverse.Visible = false;
                btnPercent.Visible = false;

                btnAdvanced.Text = "Napredno";
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e) { DodajZnak("√"); }
        private void btnSquare_Click(object sender, EventArgs e) { DodajZnak("^2"); }
        private void btnInverse_Click(object sender, EventArgs e) { DodajZnak("1/"); }
        private void btnPercent_Click(object sender, EventArgs e) { DodajZnak("%"); }

        private void button2_Click(object sender, EventArgs e)
        {
            cleanMode = !cleanMode;

            foreach (Control c in this.Controls)
            {
                if (c != btnMode && c != pnlConverter)
                {
                    c.Visible = !cleanMode;
                }
            }

            if (cleanMode)
            {
                txtDisplay.Visible = false;
                pnlConverter.Visible = true;
                pnlConverter.Dock = DockStyle.Fill;
                pnlConverter.BringToFront();
                btnMode.BringToFront();
            }
            else
            {
                pnlConverter.Dock = DockStyle.None;
                pnlConverter.Visible = false;
                txtDisplay.Visible = true;
                ResetujListe();
            }
        }

        // ==================== KONVERTER - OVO JE BILO NEDOSTAJEĆE ====================
        private void btnConvertNow_Click(object sender, EventArgs e)
        {
            // Resetovanje boja
            cmbIzvorna.BackColor = Color.White;
            cmbCiljna.BackColor = Color.White;
            txtValueToConvert.BackColor = Color.White;
            lblConverterResult.Text = "";

            double unos = 0;
            bool greska = false;

            // Validacija
            if (cmbIzvorna.SelectedIndex == -1) { cmbIzvorna.BackColor = Color.MistyRose; greska = true; }
            if (cmbCiljna.SelectedIndex == -1) { cmbCiljna.BackColor = Color.MistyRose; greska = true; }

            string cistUnos = txtValueToConvert.Text.Replace(",", ".");
            if (string.IsNullOrWhiteSpace(cistUnos) || !double.TryParse(cistUnos, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out unos))
            {
                txtValueToConvert.BackColor = Color.MistyRose;
                greska = true;
            }

            if (greska)
            {
                lblConverterResult.Text = "Popunite označena polja!";
                lblConverterResult.ForeColor = Color.Orange;
                return;
            }

            try
            {
                double rezultat = 0;
                string iz = cmbIzvorna.SelectedItem.ToString();
                string u = cmbCiljna.SelectedItem.ToString();

                // --- VALUTE ---
                if (Array.Exists(valute, x => x == iz))
                {
                    double iznosUBam = unos;

                    if (iz.Contains("EUR"))
                        iznosUBam = unos * trenutniEurKurs;
                    else if (iz.Contains("USD"))
                        iznosUBam = unos * trenutniUsdKurs;
                    else if (iz.Contains("HRK"))
                        iznosUBam = unos * 0.26;

                    if (u.Contains("EUR"))
                        rezultat = iznosUBam / trenutniEurKurs;
                    else if (u.Contains("USD"))
                        rezultat = iznosUBam / trenutniUsdKurs;
                    else if (u.Contains("HRK"))
                        rezultat = iznosUBam / 0.26;
                    else if (u.Contains("BAM"))
                        rezultat = iznosUBam;

                    lblStatusKursa.Text = $"Korišten kurs: 1 EUR = {trenutniEurKurs:F4} BAM | Izvor: {izvorPodataka}";
                    lblStatusKursa.ForeColor = Color.Lime;
                }
                // --- TEŽINE ---
                else if (Array.Exists(tezine, x => x == iz))
                {
                    double uG = iz.Contains("(t)") ? unos * 1000000 :
                               iz.Contains("kg") ? unos * 1000 :
                               iz.Contains("mg") ? unos / 1000 : unos;

                    rezultat = u.Contains("(t)") ? uG / 1000000 :
                               u.Contains("kg") ? uG / 1000 :
                               u.Contains("mg") ? uG * 1000 : uG;

                    lblStatusKursa.Text = "Konverzija težine završena.";
                    lblStatusKursa.ForeColor = Color.Cyan;
                }
                // --- DUŽINE ---
                else if (Array.Exists(duzine, x => x == iz))
                {
                    double uM = iz.Contains("(mm)") ? unos / 1000.0 :
                               iz.Contains("(cm)") ? unos / 100.0 :
                               iz.Contains("(dm)") ? unos / 10.0 :
                               iz.Contains("(km)") ? unos * 1000.0 : unos;

                    rezultat = u.Contains("mm") ? uM * 1000.0 :
                               u.Contains("cm") ? uM * 100.0 :
                               u.Contains("dm") ? uM * 10.0 :
                               u.Contains("km") ? uM / 1000.0 : uM;

                    lblStatusKursa.Text = "Konverzija dužine završena.";
                    lblStatusKursa.ForeColor = Color.Yellow;
                }

                string oznakaIzvor = iz.Contains("(") ? iz.Split('(')[1].Replace(")", "") : iz;
                string oznakaCilj = u.Contains("(") ? u.Split('(')[1].Replace(")", "") : u;

                lblConverterResult.Text = $"{unos} {oznakaIzvor} = {Math.Round(rezultat, 4)} {oznakaCilj}";
                lblConverterResult.ForeColor = Color.Lime;
            }
            catch (Exception ex)
            {
                lblConverterResult.Text = "Greška u računanju!";
                lblConverterResult.ForeColor = Color.Red;
                System.Diagnostics.Debug.WriteLine("Greška: " + ex.Message);
            }
        }

        private void lblVelikiRezultat_Click(object sender, EventArgs e) { }

        private void cmbIzvorna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIzvorna.SelectedItem == null) return;

            string izabrano = cmbIzvorna.SelectedItem.ToString();
            cmbCiljna.Items.Clear();

            if (Array.Exists(valute, x => x == izabrano))
                cmbCiljna.Items.AddRange(valute);
            else if (Array.Exists(tezine, x => x == izabrano))
                cmbCiljna.Items.AddRange(tezine);
            else if (Array.Exists(duzine, x => x == izabrano))
                cmbCiljna.Items.AddRange(duzine);

            cmbCiljna.SelectedIndex = -1;
        }

        private void cmbCiljna_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btnLightMode_Click_1(object sender, EventArgs e)
        {
            PostaviTemu(SystemColors.Control, Color.Black, SystemColors.ButtonFace);
        }
    }
}