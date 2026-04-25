using Kalkulator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
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

            // POSTAVLJANJE DEFAULT NIGHT MODE-A ODMAH NA STARTU
            PostaviTemu(Color.FromArgb(45, 45, 48), Color.White, Color.FromArgb(30, 30, 30));
        }

        public class API_Response
        {
            public string base_code { get; set; }
            public Dictionary<string, double> conversion_rates { get; set; }
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
                    // 1. FIKSNE BOJE (Ove se nikada ne mijenjaju)
                    if (btn == btnClear)
                    {
                        btn.BackColor = Color.IndianRed;
                        btn.ForeColor = Color.White;
                    }
                    else if (btn == btnAdvanced)
                    {
                        btn.BackColor = Color.FromKnownColor(KnownColor.MenuHighlight);
                        btn.ForeColor = Color.White;
                    }
                    // 2. FUNKCIJE I JEDNAKO (SteelBlue)
                    else if (btn == btnPlus || btn == btnMinus || btn == btnMultiply ||
                             btn == btnDivide || btn == btnSqrt || btn == btnSquare ||
                             btn == btnInverse || btn == btnPercent || btn == btnEquals)
                    {
                        btn.BackColor = Color.SteelBlue;
                        btn.ForeColor = Color.White;
                    }
                    // 3. BROJEVI I OSTALO (Prate temu)
                    else if (btn.Text.Length == 1 && (char.IsDigit(btn.Text[0]) || btn.Text == ","))
                    {
                        btn.BackColor = isLightMode ? Color.White : bojaDugmadi;
                        btn.ForeColor = isLightMode ? Color.Black : bojaTeksta;
                    }
                    else
                    {
                        btn.BackColor = isLightMode ? Color.FromArgb(220, 220, 220) : Color.FromArgb(50, 50, 50);
                        btn.ForeColor = isLightMode ? Color.Black : Color.White;
                    }

                    // FANCY FLAT STIL
                    btn.UseVisualStyleBackColor = false;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
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
            // Samo jedna linija - šaljemo parametre za Night Mode
            PostaviTemu(Color.FromArgb(45, 45, 48), Color.White, Color.FromArgb(30, 30, 30));
        }

        private void btnLightMode_Click(object sender, EventArgs e)
        {
            // Samo jedna linija - šaljemo parametre za Light Mode
            PostaviTemu(SystemColors.Control, Color.Black, Color.White);
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

       

        // ==================== KONVERTER - OVO JE BILO NEDOSTAJEĆE ====================
        
           
        

        
    }
}