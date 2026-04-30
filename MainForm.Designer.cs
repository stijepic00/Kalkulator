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
            this.components = new System.ComponentModel.Container();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlDrawer = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDrawerTitle = new System.Windows.Forms.Label();
            this.lblEur = new System.Windows.Forms.Label();
            this.lblUsd = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlDrawer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(268, 50);
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
            this.btnScale.Location = new System.Drawing.Point(213, 272);
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
            this.btnKalkulator.Location = new System.Drawing.Point(38, 114);
            this.btnKalkulator.Name = "btnKalkulator";
            this.btnKalkulator.Size = new System.Drawing.Size(148, 146);
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
            this.btnHistory.Location = new System.Drawing.Point(533, 272);
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
            this.btnCurrency.Location = new System.Drawing.Point(354, 114);
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
            this.btnExitApplication.Location = new System.Drawing.Point(680, 45);
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
            this.label1.Location = new System.Drawing.Point(66, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kalkulator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Istorija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valute";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Konverter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(709, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Izlaz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(561, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 47);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(213, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 51);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlTop.Controls.Add(this.lblDate);
            this.pnlTop.Controls.Add(this.lblSession);
            this.pnlTop.Controls.Add(this.lblTime);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 40);
            this.pnlTop.TabIndex = 13;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Italic);
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(691, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(126, 20);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Vrijeme uživo";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSession.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSession.Location = new System.Drawing.Point(350, 9);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(141, 20);
            this.lblSession.TabIndex = 1;
            this.lblSession.Text = "Vrijeme aktivnosti";
            this.lblSession.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSession.Click += new System.EventHandler(this.lblSession_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(21, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Datum";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDrawer
            // 
            this.pnlDrawer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlDrawer.Controls.Add(this.label10);
            this.pnlDrawer.Controls.Add(this.lblUsd);
            this.pnlDrawer.Controls.Add(this.lblEur);
            this.pnlDrawer.Controls.Add(this.lblDrawerTitle);
            this.pnlDrawer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDrawer.Location = new System.Drawing.Point(0, 40);
            this.pnlDrawer.Name = "pnlDrawer";
            this.pnlDrawer.Size = new System.Drawing.Size(0, 435);
            this.pnlDrawer.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.Location = new System.Drawing.Point(162, 438);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(33, 41);
            this.btnMenu.TabIndex = 15;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.Gray;
            this.lblVersion.Location = new System.Drawing.Point(677, 448);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(47, 18);
            this.lblVersion.TabIndex = 16;
            this.lblVersion.Text = "v1.0.1";
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // lblDrawerTitle
            // 
            this.lblDrawerTitle.AutoSize = true;
            this.lblDrawerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblDrawerTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDrawerTitle.Location = new System.Drawing.Point(12, 10);
            this.lblDrawerTitle.Name = "lblDrawerTitle";
            this.lblDrawerTitle.Size = new System.Drawing.Size(152, 18);
            this.lblDrawerTitle.TabIndex = 0;
            this.lblDrawerTitle.Text = "BRZE INFORMACIJE";
            // 
            // lblEur
            // 
            this.lblEur.AutoSize = true;
            this.lblEur.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEur.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEur.Location = new System.Drawing.Point(10, 105);
            this.lblEur.Name = "lblEur";
            this.lblEur.Size = new System.Drawing.Size(17, 20);
            this.lblEur.TabIndex = 17;
            this.lblEur.Text = "€";
            // 
            // lblUsd
            // 
            this.lblUsd.AutoSize = true;
            this.lblUsd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsd.Location = new System.Drawing.Point(10, 132);
            this.lblUsd.Name = "lblUsd";
            this.lblUsd.Size = new System.Drawing.Size(17, 20);
            this.lblUsd.TabIndex = 18;
            this.lblUsd.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(10, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "1 EUR = 1.95 BAM";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pnlDrawer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMenu);
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
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnlTop);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlDrawer.ResumeLayout(false);
            this.pnlDrawer.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel pnlDrawer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDrawerTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUsd;
        private System.Windows.Forms.Label lblEur;
    }
}