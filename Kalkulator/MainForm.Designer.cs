namespace Kalkulator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnScale = new System.Windows.Forms.Button();
            this.btnKalkulator = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnCurrency = new System.Windows.Forms.Button();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(215, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(338, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Smart Calculator";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnScale
            // 
            this.btnScale.BackColor = System.Drawing.Color.Transparent;
            this.btnScale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScale.BackgroundImage")));
            this.btnScale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnScale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScale.FlatAppearance.BorderSize = 0;
            this.btnScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScale.Location = new System.Drawing.Point(150, 268);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(162, 146);
            this.btnScale.TabIndex = 1;
            this.btnScale.UseVisualStyleBackColor = false;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // btnKalkulator
            // 
            this.btnKalkulator.BackColor = System.Drawing.Color.Transparent;
            this.btnKalkulator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKalkulator.BackgroundImage")));
            this.btnKalkulator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKalkulator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKalkulator.FlatAppearance.BorderSize = 0;
            this.btnKalkulator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKalkulator.Location = new System.Drawing.Point(108, 93);
            this.btnKalkulator.Name = "btnKalkulator";
            this.btnKalkulator.Size = new System.Drawing.Size(204, 146);
            this.btnKalkulator.TabIndex = 2;
            this.btnKalkulator.UseVisualStyleBackColor = false;
            this.btnKalkulator.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHistory.BackgroundImage")));
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Location = new System.Drawing.Point(448, 268);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(154, 146);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnCurrency
            // 
            this.btnCurrency.BackColor = System.Drawing.Color.Transparent;
            this.btnCurrency.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCurrency.BackgroundImage")));
            this.btnCurrency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCurrency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCurrency.FlatAppearance.BorderSize = 0;
            this.btnCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrency.Location = new System.Drawing.Point(448, 93);
            this.btnCurrency.Name = "btnCurrency";
            this.btnCurrency.Size = new System.Drawing.Size(154, 146);
            this.btnCurrency.TabIndex = 4;
            this.btnCurrency.UseVisualStyleBackColor = false;
            this.btnCurrency.Click += new System.EventHandler(this.btnCurrency_Click);
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.BackColor = System.Drawing.Color.Transparent;
            this.btnExitApplication.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitApplication.BackgroundImage")));
            this.btnExitApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExitApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitApplication.FlatAppearance.BorderSize = 0;
            this.btnExitApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitApplication.Location = new System.Drawing.Point(685, 328);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(103, 110);
            this.btnExitApplication.TabIndex = 5;
            this.btnExitApplication.UseVisualStyleBackColor = false;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.btnCurrency);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnKalkulator);
            this.Controls.Add(this.btnScale);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnScale;
        private System.Windows.Forms.Button btnKalkulator;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnCurrency;
        private System.Windows.Forms.Button btnExitApplication;
    }
}