using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class HistoryForm : Form
    {
        // Boje usklađene sa tvojim Dark Mode-om iz Form1
        private Color darkBackground = Color.FromArgb(45, 45, 48);
        private Color cardColor = Color.FromArgb(30, 30, 30);
        private Color textColor = Color.White;
        private Color resultColor = Color.Lime;

        public HistoryForm()
        {
            InitializeComponent();
            // Postavljamo osnovni izgled forme
            this.BackColor = darkBackground;
            this.Text = "Istorija Računanja";
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            // Pozivamo učitavanje kartica
            UcitajIstorijuUKartice();
        }

        private void UcitajIstorijuUKartice()
        {
            string connectionString = "Server=DESKTOP-J73S4GL;Database=KalkulatorDB;Trusted_Connection=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Istorija ORDER BY Datum DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // DODAJ OVU LINIJU ZA TEST:
                    MessageBox.Show("Broj redova u bazi: " + table.Rows.Count);

                    // 1. Očisti flowHistory od starih stvari ili DataGridView-a (ako je ostao u kodu)
                    flowHistory.Controls.Clear();
                    flowHistory.FlowDirection = FlowDirection.TopDown;
                    flowHistory.WrapContents = false;
                    flowHistory.AutoScroll = true;

                    foreach (DataRow row in table.Rows)
                    {
                        // 2. KREIRANJE GLAVNE KARTICE (PANEL)
                        Panel card = new Panel();
                        // Umjesto: card.Size = new Size(flowHistory.Width - 25, 90);
                        // Stavi fiksno:
                        card.Size = new Size(350, 90); // Širina prilagođena sa malim paddingom za scrollbar
                        card.BackColor = cardColor;
                        card.Margin = new Padding(10, 5, 10, 5);
                        card.Padding = new Padding(10);

                        // 3. IZRAZ (Gornji tekst - sivi)
                        Label lblIzraz = new Label();
                        lblIzraz.Text = row["Izraz"].ToString();
                        lblIzraz.ForeColor = Color.DarkGray;
                        lblIzraz.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                        lblIzraz.Dock = DockStyle.Top;
                        lblIzraz.AutoSize = true;

                        // 4. REZULTAT (Srednji tekst - zeleni/veliki)
                        Label lblRezultat = new Label();
                        lblRezultat.Text = "= " + row["Rezultat"].ToString();
                        lblRezultat.ForeColor = resultColor;
                        lblRezultat.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                        lblRezultat.Location = new Point(10, 30);
                        lblRezultat.AutoSize = true;

                        // 5. DATUM (Mali tekst u uglu)
                        Label lblDatum = new Label();
                        DateTime dt = Convert.ToDateTime(row["Datum"]);
                        lblDatum.Text = dt.ToString("dd.MM.yyyy HH:mm");
                        lblDatum.ForeColor = Color.DimGray;
                        lblDatum.Font = new Font("Segoe UI", 8);
                        lblDatum.Dock = DockStyle.Bottom;
                        lblDatum.TextAlign = ContentAlignment.BottomRight;

                        // 6. DODAVANJE ELEMENATA NA KARTICU
                        card.Controls.Add(lblRezultat);
                        card.Controls.Add(lblIzraz);
                        card.Controls.Add(lblDatum);

                        // 7. HOVER EFEKAT (Interaktivnost)
                        card.MouseEnter += (s, e) => card.BackColor = Color.FromArgb(55, 55, 60);
                        card.MouseLeave += (s, e) => card.BackColor = cardColor;

                        // Dodaj karticu u flowHistory panel
                        flowHistory.Controls.Add(card);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju: " + ex.Message);
            }
        }

        // Ako želiš da se lista osvježi kad god se prozor aktivira
        private void HistoryForm_Activated(object sender, EventArgs e)
        {
            // Opcionalno: UcitajIstorijuUKartice();
        }

        private void HistoryForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}