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

namespace Kalkulator
{
    public partial class MainForm : Form
    {
        private Stopwatch sessionStopwatch = new Stopwatch();
        private bool isDrawerOpen = false;
        private const int DrawerWidth = 180;
        public MainForm()
        {
            InitializeComponent();
            sessionStopwatch.Start(); // Pokreće štopericu
        }


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

            // Setup Panela (Uveri se da se ovako zovu u Designeru!)
            pnlTop.BackColor = Color.FromArgb(30, 30, 30);
            pnlDrawer.Width = 0;

            // Setup Labela
            lblTime.ForeColor = Color.White;
            lblTime.Font = new Font("Consolas", 12, FontStyle.Bold);
            lblDate.ForeColor = Color.DarkGray;
            lblSession.ForeColor = Color.SteelBlue;

            // Inicijalni tekst
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd");

            // Dugmad
            StyleButton(btnKalkulator, "Kalkulator.png");
            StyleButton(btnCurrency, "Currency.png");
            StyleButton(btnScale, "Scale.png");
            StyleButton(btnHistory, "History.png");
            lblDrawerTitle.ForeColor = Color.SteelBlue;
            lblDrawerTitle.Text = "BRZE INFORMACIJE";
            // Verzija aplikacije u donjem desnom uglu
            lblVersion.Text = "Build: 2026.4.25"; // Možeš staviti i datum
            lblVersion.ForeColor = Color.FromArgb(150, 150, 150); // Diskretna siva
            lblVersion.Font = new Font("Segoe UI", 7, FontStyle.Regular); // Sitniji font
            lblVersion.BackColor = Color.Transparent; // Da se stapa sa pozadinom
            lblEur.Text = "EUR: 1.955 BAM";
            lblUsd.Text = "USD: 1.800 BAM";
            lblEur.ForeColor = Color.White;
            lblUsd.ForeColor = Color.White;

            pnlDrawer.Width = 0; // Počinje zatvoren

            timer1.Start(); // Pokreće vizuelno osvežavanje
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Onemogući dugme dok traje animacija da ne zabaguje
            btnMenu.Enabled = false;

            if (!isDrawerOpen)
            {
                // Otvaranje ladice
                while (pnlDrawer.Width < DrawerWidth)
                {
                    pnlDrawer.Width += 15; // Manji korak za glađu animaciju
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
                isDrawerOpen = true;
            }
            else
            {
                // Zatvaranje ladice
                while (pnlDrawer.Width > 0)
                {
                    pnlDrawer.Width -= 15;
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
                isDrawerOpen = false;
            }

            btnMenu.Enabled = true;
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
            else
            {
                lblVersion.Text = "Built: 2026.4.25";
            }
        }
    }
}
