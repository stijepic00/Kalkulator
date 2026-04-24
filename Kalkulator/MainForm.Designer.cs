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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(264, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(297, 47);
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
            this.btnScale.Location = new System.Drawing.Point(218, 239);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(151, 146);
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
            this.btnKalkulator.Location = new System.Drawing.Point(30, 81);
            this.btnKalkulator.Name = "btnKalkulator";
            this.btnKalkulator.Size = new System.Drawing.Size(170, 146);
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
            this.btnHistory.Location = new System.Drawing.Point(538, 239);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(146, 146);
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
            this.btnCurrency.Location = new System.Drawing.Point(359, 81);
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
            this.btnExitApplication.Location = new System.Drawing.Point(685, 12);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(103, 110);
            this.btnExitApplication.TabIndex = 5;
            this.btnExitApplication.UseVisualStyleBackColor = false;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kalkulator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(580, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Istorija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valute";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Konverter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(714, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Izlaz";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}