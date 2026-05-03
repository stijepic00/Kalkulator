using Projekat_kalkulator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Net;
using Newtonsoft.Json.Linq; 

namespace Kalkulator
{
    public partial class MainForm : Form
    {
        private Stopwatch sessionStopwatch = new Stopwatch();
        private bool isDrawerOpen = false;
        private const int DrawerWidth = 180;
        Color mojZelena = Color.FromArgb(95, 195, 20);
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            sessionStopwatch.Start();
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,     // x-koordinata gore levo
    int nTopRect,      // y-koordinata gore levo
    int nRightRect,    // x-koordinata dole desno
    int nBottomRect,   // y-koordinata dole desno
    int nWidthEllipse, // širina elipse (koliko je zaobljeno)
    int nHeightEllipse // visina elipse
);

        private void OpenForm(Form f)
        {
            try
            {
                f.StartPosition = FormStartPosition.CenterScreen;
                f.FormClosed += (s, e) => this.Show();
                this.Hide();
                f.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); this.Show(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm(new Form1());

            btnKalkulator.TextAlign = ContentAlignment.BottomCenter;
            btnKalkulator.ImageAlign = ContentAlignment.TopCenter;

            btnKalkulator.FlatStyle = FlatStyle.Flat;
            btnKalkulator.FlatAppearance.BorderSize = 0;

            btnKalkulator.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnKalkulator.ForeColor = Color.White;
            //btnKalkulator.BackColor = Color.FromArgb(30, 30, 30);



        }

        private void btnScale_Click(object sender, EventArgs e)
        {
            OpenForm(new UnitsForm());
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            OpenForm(new HistoryForm());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void AzurirajKursnuListu()
        {
            string eurSym = "€";
            string usdSym = "$";
            string chfSym = "₣";
            string rubSym = "₽";
            string rsdSym = "din"; // Možeš koristiti i "RSD"

            try
            {
                using (WebClient client = new WebClient())
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    string json = client.DownloadString("http://www.floatrates.com/daily/bam.json");

                    JObject data = JObject.Parse(json);

                    // Čitanje online vrijednosti
                    double eurVal = 1 / data["eur"].Value<double>("rate");
                    double usdVal = 1 / data["usd"]["rate"].Value<double>();
                    double chfVal = 1 / data["chf"]["rate"].Value<double>();
                    double rubVal = 1 / data["rub"]["rate"].Value<double>();

                    // Kurs za 100 RSD (zato množimo sa 100)
                    double rsdVal = (1 / data["rsd"]["rate"].Value<double>()) * 100;

                    lblEur.Text = $"{eurSym} EUR: {eurVal:N3} BAM";
                    lblUsd.Text = $"{usdSym} USD: {usdVal:N3} BAM";
                    lblChf.Text = $"{chfSym} CHF: {chfVal:N3} BAM";
                    lblRub.Text = $"{rubSym} RUB: {rubVal:N3} BAM";
                    lblRsd.Text = $"{rsdSym} 100 RSD: {rsdVal:N3} BAM";
                }
            }
            catch
            {
                // FAILSAFE: Ako internet pukne
                lblEur.Text = $"{eurSym} EUR: 1.956 BAM";
                lblUsd.Text = $"{usdSym} USD: 1.801 BAM";
                lblChf.Text = $"{chfSym} CHF: 2.025 BAM";
                lblRub.Text = $"{rubSym} RUB: 0.019 BAM";
                lblRsd.Text = $"{rsdSym} 100 RSD: 1.662 BAM";
            }
        }
        private void btnCurrency_Click(object sender, EventArgs e)
        {
            OpenForm(new CurrencyForm());
        }
        private void StyleButton(Button btn, string imagePath)
        {
            if (System.IO.File.Exists(imagePath))
            {
                Image img = Image.FromFile(imagePath);
                btn.Image = new Bitmap(img, new Size(48, 48));
            }
            btn.TextAlign = ContentAlignment.BottomCenter;
            btn.ImageAlign = ContentAlignment.TopCenter;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.Cursor = Cursors.Hand;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // --- STILIZACIJA MENU DUGMETA ---
            btnMenu.Text = "☰";
            btnMenu.BackColor = mojZelena; // Zelena #5FC314
            btnMenu.ForeColor = Color.White;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Font = new Font("Segoe UI", 14, FontStyle.Bold);

            // Hover efekti (da dugme "reaguje" na miš)
            btnMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 175, 15);
            btnMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 155, 10);

            // Zaobljenje ivica (15 je nivo zaobljenosti)
            btnMenu.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnMenu.Width, btnMenu.Height, 15, 15));
            // Promijeni 'e' u 'ev' da se ne sudara sa glavnim 'e' parametrom
            btnMenu.MouseEnter += (s, ev) => { if (isDrawerOpen) btnMenu.ForeColor = Color.Black; };
            btnMenu.MouseLeave += (s, ev) => { if (isDrawerOpen) btnMenu.ForeColor = mojZelena; };
            // -------------------------------
            AzurirajKursnuListu();
            pnlTop.BackColor = Color.FromArgb(30, 30, 30);
            pnlDrawer.Width = 0; // Skriven na početku

            // Osvežavanje sata i datuma odmah pri paljenju
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd");

            // Pozivanje tvoje funkcije za ostalu dugmad
            StyleButton(btnKalkulator, "Kalkulator.png");
            StyleButton(btnCurrency, "Currency.png");
            StyleButton(btnScale, "Scale.png");
            StyleButton(btnHistory, "History.png");

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd");

            TimeSpan ts = sessionStopwatch.Elapsed;
            lblSession.Text = string.Format("Aktivan: {0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 1. Dodaj ovo gore kod ostalih varijabli
        private bool isAnimating = false;

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (isAnimating) return; // Blokira klik dok traje animacija

            isAnimating = true;
            this.SuspendLayout(); // Stopira titranje UI-a

            if (!isDrawerOpen)
            {
                // OTVARANJE
                btnMenu.Text = "✕";
                btnMenu.BackColor = Color.FromArgb(45, 45, 45); // Tamna boja panela
                btnMenu.ForeColor = mojZelena; // Znak X postaje zelen

                while (pnlDrawer.Width < DrawerWidth)
                {
                    int korak = 20;
                    if (pnlDrawer.Width + korak > DrawerWidth) korak = DrawerWidth - pnlDrawer.Width;

                    pnlDrawer.Width += korak;
                    this.Width += korak; // Širi celu formu udesno

                    Application.DoEvents();
                    System.Threading.Thread.Sleep(1);
                }
                isDrawerOpen = true;
            }
            else
            {
                // ZATVARANJE
                btnMenu.Text = "☰";
                btnMenu.BackColor = mojZelena; // Vraća na zelenu
                btnMenu.ForeColor = Color.White; // Vraća beli hamburger

                while (pnlDrawer.Width > 0)
                {
                    int korak = 20;
                    if (pnlDrawer.Width - korak < 0) korak = pnlDrawer.Width;

                    pnlDrawer.Width -= korak;
                    this.Width -= korak; // Smanjuje formu

                    Application.DoEvents();
                    System.Threading.Thread.Sleep(1);
                }
                isDrawerOpen = false;
            }

            this.ResumeLayout();
            isAnimating = false;
        }

        private void lblSession_Click(object sender, EventArgs e)
        {

        }

        private void lblVersion_Click(object sender, EventArgs e)
        {
            if (lblVersion.Text.Contains("Build"))
            {
                lblVersion.Text = "Developed by Kristijan";
            }
           
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
