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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 kalkulator = new Form1();
            kalkulator.Show();

            Form1 calc = new Form1();
            calc.Show();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnKonverter_Click(object sender, EventArgs e)
        {
            Form1 conv = new Form1();
            conv.Show();
            conv.PrebaciNaKonverter(); // Dodat ćemo ovu metodu u Form1
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm hist = new HistoryForm();
            hist.Show();
        }
    }
}
