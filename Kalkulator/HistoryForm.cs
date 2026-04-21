using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            // Automatski učitaj poslednju operaciju kada se forma otvori
            UcitajPoslednjuOperaciju();
        }

        private void UcitajPoslednjuOperaciju()
        {
            string connectionString = "Server=DESKTOP-J73S4GL;Database=KalkulatorDB;Trusted_Connection=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Uzima sve operacije, poslednja operacija je na vrhu
                    string query = "SELECT * FROM Istorija ORDER BY Datum DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;

                    // Prilagodi širinu kolona
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Opcionalno: označi poslednji red (poslednju operaciju)
                    if (dataGridView1.Rows.Count > 0)
                        dataGridView1.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom učitavanja istorije: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}