namespace Kalkulator
{
    partial class CurrencyForm
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
            this.cmbIzvorna = new System.Windows.Forms.ComboBox();
            this.cmbCiljna = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbIzvorna
            // 
            this.cmbIzvorna.BackColor = System.Drawing.Color.DimGray;
            this.cmbIzvorna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIzvorna.DropDownWidth = 200;
            this.cmbIzvorna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIzvorna.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.cmbIzvorna.ForeColor = System.Drawing.Color.White;
            this.cmbIzvorna.FormattingEnabled = true;
            this.cmbIzvorna.Location = new System.Drawing.Point(130, 152);
            this.cmbIzvorna.Name = "cmbIzvorna";
            this.cmbIzvorna.Size = new System.Drawing.Size(143, 30);
            this.cmbIzvorna.TabIndex = 0;
            // 
            // cmbCiljna
            // 
            this.cmbCiljna.BackColor = System.Drawing.Color.DimGray;
            this.cmbCiljna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiljna.DropDownWidth = 200;
            this.cmbCiljna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCiljna.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.cmbCiljna.ForeColor = System.Drawing.Color.White;
            this.cmbCiljna.FormattingEnabled = true;
            this.cmbCiljna.Location = new System.Drawing.Point(285, 152);
            this.cmbCiljna.Name = "cmbCiljna";
            this.cmbCiljna.Size = new System.Drawing.Size(131, 30);
            this.cmbCiljna.TabIndex = 1;
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.Color.DimGray;
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtValue.ForeColor = System.Drawing.Color.White;
            this.txtValue.Location = new System.Drawing.Point(205, 107);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(171, 30);
            this.txtValue.TabIndex = 2;
            this.txtValue.Text = " Unesi iznos";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvert.FlatAppearance.BorderSize = 0;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnConvert.ForeColor = System.Drawing.Color.White;
            this.btnConvert.Location = new System.Drawing.Point(205, 211);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(143, 34);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Konvertuj";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResult.Location = new System.Drawing.Point(12, 260);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(531, 60);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Rezultat će biti prikazan ovdje";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.21F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "KONVERTOR VALUTA PRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(201, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "TIP KONVERZIJE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(560, 334);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.cmbCiljna);
            this.Controls.Add(this.cmbIzvorna);
            this.Name = "CurrencyForm";
            this.Text = "CurrencyForm";
            this.Load += new System.EventHandler(this.CurrencyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIzvorna;
        private System.Windows.Forms.ComboBox cmbCiljna;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}