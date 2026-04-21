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

namespace Kalkulator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Show(); // fallback
            }
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
            btn.FlatStyle = FlatStyle.Standard;

            btn.UseVisualStyleBackColor = false;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(20, 20, 20);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            StyleButton(btnKalkulator, "Kalkulator.png");
            StyleButton(btnCurrency, "Currency.png");
            StyleButton(btnScale, "Scale.png");
            StyleButton(btnHistory, "History.png");

            this.BackColor = Color.FromArgb(240, 240, 240);
            this.ForeColor = Color.Black;


        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
