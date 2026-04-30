namespace Kalkulator
{
    partial class UnitsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.cmbIzvorna = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.labelaTipKonv = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.cmbCiljna = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.BackColor = System.Drawing.Color.DimGray;
            this.cmbKategorija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategorija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.cmbKategorija.ForeColor = System.Drawing.Color.White;
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(291, 103);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(148, 30);
            this.cmbKategorija.TabIndex = 0;
            this.cmbKategorija.SelectedIndexChanged += new System.EventHandler(this.cmbKategorija_SelectedIndexChanged);
            this.cmbKategorija.Click += new System.EventHandler(this.cmbKategorija_SelectedIndexChanged);
            // 
            // cmbIzvorna
            // 
            this.cmbIzvorna.BackColor = System.Drawing.Color.DimGray;
            this.cmbIzvorna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIzvorna.DropDownWidth = 250;
            this.cmbIzvorna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIzvorna.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.cmbIzvorna.ForeColor = System.Drawing.Color.White;
            this.cmbIzvorna.FormattingEnabled = true;
            this.cmbIzvorna.Location = new System.Drawing.Point(122, 141);
            this.cmbIzvorna.Name = "cmbIzvorna";
            this.cmbIzvorna.Size = new System.Drawing.Size(153, 30);
            this.cmbIzvorna.TabIndex = 1;
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.Color.DimGray;
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.ForeColor = System.Drawing.Color.White;
            this.txtValue.Location = new System.Drawing.Point(122, 103);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(153, 30);
            this.txtValue.TabIndex = 2;
            this.txtValue.Text = " Unesi vrijednost";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvert.FlatAppearance.BorderSize = 0;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.White;
            this.btnConvert.Location = new System.Drawing.Point(204, 197);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(153, 39);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Konvertuj";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // labelaTipKonv
            // 
            this.labelaTipKonv.AutoSize = true;
            this.labelaTipKonv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaTipKonv.ForeColor = System.Drawing.Color.White;
            this.labelaTipKonv.Location = new System.Drawing.Point(200, 69);
            this.labelaTipKonv.Name = "labelaTipKonv";
            this.labelaTipKonv.Size = new System.Drawing.Size(175, 24);
            this.labelaTipKonv.TabIndex = 4;
            this.labelaTipKonv.Text = "TIP KONVERZIJE";
            this.labelaTipKonv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResult.Location = new System.Drawing.Point(12, 255);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(536, 60);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Rezultat će biti prikazan ovdje";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCiljna
            // 
            this.cmbCiljna.BackColor = System.Drawing.Color.DimGray;
            this.cmbCiljna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiljna.DropDownWidth = 250;
            this.cmbCiljna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCiljna.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.cmbCiljna.ForeColor = System.Drawing.Color.White;
            this.cmbCiljna.FormattingEnabled = true;
            this.cmbCiljna.Location = new System.Drawing.Point(291, 141);
            this.cmbCiljna.Name = "cmbCiljna";
            this.cmbCiljna.Size = new System.Drawing.Size(148, 30);
            this.cmbCiljna.TabIndex = 6;
            this.cmbCiljna.SelectedIndexChanged += new System.EventHandler(this.cmbCiljna_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "KONVERTOR JEDINICA PRO";
            // 
            // UnitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(560, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCiljna);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.labelaTipKonv);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.cmbIzvorna);
            this.Controls.Add(this.cmbKategorija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UnitsForm";
            this.Text = "UnitsForm";
            this.Load += new System.EventHandler(this.UnitsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.ComboBox cmbIzvorna;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label labelaTipKonv;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cmbCiljna;
        private System.Windows.Forms.Label label1;
    }
}