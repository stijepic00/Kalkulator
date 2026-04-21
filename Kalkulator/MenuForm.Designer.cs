namespace Kalkulator
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnKalkulator = new System.Windows.Forms.Button();
            this.btnKonverter = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.Location = new System.Drawing.Point(185, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moj Kalkulator I Konverter";
            // 
            // btnKalkulator
            // 
            this.btnKalkulator.BackColor = System.Drawing.Color.Transparent;
            this.btnKalkulator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKalkulator.BackgroundImage")));
            this.btnKalkulator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKalkulator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKalkulator.FlatAppearance.BorderSize = 0;
            this.btnKalkulator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKalkulator.Location = new System.Drawing.Point(64, 106);
            this.btnKalkulator.Name = "btnKalkulator";
            this.btnKalkulator.Size = new System.Drawing.Size(163, 238);
            this.btnKalkulator.TabIndex = 1;
            this.btnKalkulator.UseVisualStyleBackColor = false;
            this.btnKalkulator.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKonverter
            // 
            this.btnKonverter.BackColor = System.Drawing.Color.Transparent;
            this.btnKonverter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKonverter.BackgroundImage")));
            this.btnKonverter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKonverter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKonverter.FlatAppearance.BorderSize = 0;
            this.btnKonverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKonverter.Location = new System.Drawing.Point(233, 106);
            this.btnKonverter.Name = "btnKonverter";
            this.btnKonverter.Size = new System.Drawing.Size(279, 238);
            this.btnKonverter.TabIndex = 2;
            this.btnKonverter.UseVisualStyleBackColor = false;
            this.btnKonverter.Click += new System.EventHandler(this.btnKonverter_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHistory.BackgroundImage")));
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Location = new System.Drawing.Point(518, 106);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(231, 238);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnKonverter);
            this.Controls.Add(this.btnKalkulator);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKalkulator;
        private System.Windows.Forms.Button btnKonverter;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}