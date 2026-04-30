using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class CurrencyForm : Form
    {
        // Default kursevi (ako net ne radi)
        double eurKurs = 1.95583;
        double usdKurs = 1.82;
        double rsdKurs = 0.0166;
        double rubKurs = 0.019;
        double gbpKurs = 2.28;
        double chfKurs = 2.01;
        double jpyKurs = 0.012;
        double hrkKurs = 0.26; // Fiksni stari kurs
        bool isOffline = false;

        string[] valute = {
    "BAM (BiH Marka)",
    "Euro (EUR)",
    "Dolar (USD)",
    "Kuna (HRK)",
    "Dinar (RSD)",
    "Rublja (RUB)",
    "Funta (GBP)",
    "Franak (CHF)",
    "Jen (JPY)"
};

        public CurrencyForm()
        {
            InitializeComponent();

            // Postavljanje tamne teme (Woah efekt)
            PodesiDizajn();
        }

        private void PodesiDizajn()
        {
            this.BackColor = Color.FromArgb(45, 45, 48);
            lblResult.ForeColor = Color.Cyan;
            btnConvert.BackColor = Color.FromArgb(0, 122, 204);
            btnConvert.ForeColor = Color.White;
            btnConvert.FlatStyle = FlatStyle.Flat;

            cmbIzvorna.BackColor = Color.FromArgb(30, 30, 30);
            cmbIzvorna.ForeColor = Color.White;
            cmbCiljna.BackColor = Color.FromArgb(30, 30, 30);
            cmbCiljna.ForeColor = Color.White;
        }

        private async void CurrencyForm_Load(object sender, EventArgs e)
        {
            // Punimo liste
            cmbIzvorna.Items.Clear();
            cmbCiljna.Items.Clear();
            cmbIzvorna.Items.AddRange(valute);
            cmbCiljna.Items.AddRange(valute);


            // Automatsko popunjavanje
            cmbIzvorna.SelectedIndex = 0; // BAM
            cmbCiljna.SelectedIndex = 1;   // EUR

            // Pokušaj osvježiti kurseve sa interneta
            lblResult.Text = "Ažuriranje kurseva...";
            await AzurirajKurseve();
            lblResult.Text = "Kursevi ažurirani!";
        }

        private async Task AzurirajKurseve()
        {
            try
            {
                using (HttpClient klijent = new HttpClient())
                {
                    string json = await klijent.GetStringAsync("https://open.er-api.com/v6/latest/BAM");
                    var podaci = JsonConvert.DeserializeObject<dynamic>(json);

                    if (podaci != null && podaci.rates != null)
                    {
                        eurKurs = 1.0 / (double)podaci.rates.EUR;
                        usdKurs = 1.0 / (double)podaci.rates.USD;
                        rsdKurs = 1.0 / (double)podaci.rates.RSD;
                        rubKurs = 1.0 / (double)podaci.rates.RUB;
                        gbpKurs = 1.0 / (double)podaci.rates.GBP;
                        chfKurs = 1.0 / (double)podaci.rates.CHF;
                        jpyKurs = 1.0 / (double)podaci.rates.JPY;

                        isOffline = false; // Internet radi
                    }
                }
            }
            catch
            {
                isOffline = true; // Prebacuje na fiksne cijene
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                // Provjera praznog polja i selekcije
                if (string.IsNullOrWhiteSpace(txtValue.Text)) return;
                if (cmbIzvorna.SelectedIndex == -1 || cmbCiljna.SelectedIndex == -1) return;

                // Siguran unos broja (radi i sa tačkom i sa zarezom)
                double unos = double.Parse(txtValue.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);

                string izPuniNaziv = cmbIzvorna.SelectedItem.ToString();
                string uPuniNaziv = cmbCiljna.SelectedItem.ToString();

                // Popravka zagrada: Uzimamo sve od prve zagrade do kraja stringa
                string izOznaka = izPuniNaziv.Substring(izPuniNaziv.IndexOf('('));
                string uOznaka = uPuniNaziv.Substring(uPuniNaziv.IndexOf('('));

                // 1. KORAK: Sve pretvaramo u BAM (osnovna jedinica)
                double iznosUBam = unos;
                if (izPuniNaziv.Contains("EUR")) iznosUBam = unos * eurKurs;
                else if (izPuniNaziv.Contains("USD")) iznosUBam = unos * usdKurs;
                else if (izPuniNaziv.Contains("RSD")) iznosUBam = unos * rsdKurs;
                else if (izPuniNaziv.Contains("RUB")) iznosUBam = unos * rubKurs;
                else if (izPuniNaziv.Contains("GBP")) iznosUBam = unos * gbpKurs;
                else if (izPuniNaziv.Contains("CHF")) iznosUBam = unos * chfKurs;
                else if (izPuniNaziv.Contains("JPY")) iznosUBam = unos * jpyKurs;
                else if (izPuniNaziv.Contains("HRK")) iznosUBam = unos * hrkKurs;

                // 2. KORAK: Iz BAM-a pretvaramo u ciljnu valutu
                double rezultat = 0;
                if (uPuniNaziv.Contains("EUR")) rezultat = iznosUBam / eurKurs;
                else if (uPuniNaziv.Contains("USD")) rezultat = iznosUBam / usdKurs;
                else if (uPuniNaziv.Contains("RSD")) rezultat = iznosUBam / rsdKurs;
                else if (uPuniNaziv.Contains("RUB")) rezultat = iznosUBam / rubKurs;
                else if (uPuniNaziv.Contains("GBP")) rezultat = iznosUBam / gbpKurs;
                else if (uPuniNaziv.Contains("CHF")) rezultat = iznosUBam / chfKurs;
                else if (uPuniNaziv.Contains("JPY")) rezultat = iznosUBam / jpyKurs;
                else if (uPuniNaziv.Contains("HRK")) rezultat = iznosUBam / hrkKurs;
                else if (uPuniNaziv.Contains("BAM")) rezultat = iznosUBam;

                // 3. KORAK: Ispis u lblResult sa statusom interneta
                string statusNeta = isOffline ? "\n(OFFLINE - FIKSNI KURS)" : "";

                lblResult.Text = $"{unos} {izOznaka}\n= {rezultat:N4} {uOznaka}{statusNeta}";

                // Boja: Narandžasta ako je offline (upozorenje), inače zelena
                lblResult.ForeColor = isOffline ? Color.Orange : Color.SpringGreen;
            }
            catch
            {
                lblResult.Text = "Greška: Unesite ispravan broj!";
                lblResult.ForeColor = Color.Red;
            }
        }

    }
}