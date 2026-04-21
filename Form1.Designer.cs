namespace Projekat_kalkulator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.pnlConverter = new System.Windows.Forms.Panel();
            this.lblStatusKursa = new System.Windows.Forms.Label();
            this.cmbIzvorna = new System.Windows.Forms.ComboBox();
            this.lblVelikiRezultat = new System.Windows.Forms.Label();
            this.btnConvertNow = new System.Windows.Forms.Button();
            this.lblConverterResult = new System.Windows.Forms.Label();
            this.cmbCiljna = new System.Windows.Forms.ComboBox();
            this.txtValueToConvert = new System.Windows.Forms.TextBox();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnLightMode = new System.Windows.Forms.Button();
            this.btnDarkMode = new System.Windows.Forms.Button();
            this.btnMode = new System.Windows.Forms.Button();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.pnlConverter.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.AccessibleName = "";
            this.txtDisplay.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(5, 48);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(310, 50);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDisplay_KeyPress);
            // 
            // btnPlus
            // 
            this.btnPlus.AccessibleName = "";
            this.btnPlus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(245, 326);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(70, 60);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(245, 256);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(70, 60);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(245, 116);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(70, 60);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(245, 186);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(70, 60);
            this.btnMultiply.TabIndex = 3;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(5, 400);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 63);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(165, 326);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(70, 60);
            this.btnEquals.TabIndex = 5;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.LightGray;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(5, 256);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 60);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(85, 326);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(70, 60);
            this.btnDot.TabIndex = 7;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.LightGray;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(165, 256);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 60);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.LightGray;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(85, 256);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 60);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.LightGray;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(165, 186);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 60);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.LightGray;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(85, 186);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 60);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.LightGray;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(5, 186);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 60);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.LightGray;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(165, 116);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 60);
            this.btn9.TabIndex = 16;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.LightGray;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(85, 116);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 60);
            this.btn8.TabIndex = 15;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.LightGray;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(5, 116);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 60);
            this.btn7.TabIndex = 14;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.LightGray;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(5, 326);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(70, 60);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(5, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 60);
            this.button1.TabIndex = 21;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSqrt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.Location = new System.Drawing.Point(245, 116);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(70, 60);
            this.btnSqrt.TabIndex = 22;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Visible = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSquare.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare.Location = new System.Drawing.Point(245, 186);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(70, 60);
            this.btnSquare.TabIndex = 23;
            this.btnSquare.Text = "x²";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Visible = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInverse.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInverse.Location = new System.Drawing.Point(245, 256);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(70, 60);
            this.btnInverse.TabIndex = 24;
            this.btnInverse.Text = "1/x";
            this.btnInverse.UseVisualStyleBackColor = false;
            this.btnInverse.Visible = false;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.AccessibleName = "";
            this.btnPercent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPercent.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercent.Location = new System.Drawing.Point(245, 326);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(70, 60);
            this.btnPercent.TabIndex = 25;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Visible = false;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // pnlConverter
            // 
            this.pnlConverter.Controls.Add(this.lblStatusKursa);
            this.pnlConverter.Controls.Add(this.cmbIzvorna);
            this.pnlConverter.Controls.Add(this.lblVelikiRezultat);
            this.pnlConverter.Controls.Add(this.btnConvertNow);
            this.pnlConverter.Controls.Add(this.lblConverterResult);
            this.pnlConverter.Controls.Add(this.cmbCiljna);
            this.pnlConverter.Controls.Add(this.txtValueToConvert);
            this.pnlConverter.Location = new System.Drawing.Point(5, 104);
            this.pnlConverter.Name = "pnlConverter";
            this.pnlConverter.Size = new System.Drawing.Size(310, 358);
            this.pnlConverter.TabIndex = 27;
            this.pnlConverter.Visible = false;
            // 
            // lblStatusKursa
            // 
            this.lblStatusKursa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblStatusKursa.Location = new System.Drawing.Point(15, 296);
            this.lblStatusKursa.Name = "lblStatusKursa";
            this.lblStatusKursa.Size = new System.Drawing.Size(290, 63);
            this.lblStatusKursa.TabIndex = 6;
            this.lblStatusKursa.Text = "Status kursa";
            this.lblStatusKursa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbIzvorna
            // 
            this.cmbIzvorna.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbIzvorna.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbIzvorna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbIzvorna.FormattingEnabled = true;
            this.cmbIzvorna.Location = new System.Drawing.Point(170, 66);
            this.cmbIzvorna.Name = "cmbIzvorna";
            this.cmbIzvorna.Size = new System.Drawing.Size(91, 24);
            this.cmbIzvorna.TabIndex = 5;
            this.cmbIzvorna.SelectedIndexChanged += new System.EventHandler(this.cmbIzvorna_SelectedIndexChanged);
            // 
            // lblVelikiRezultat
            // 
            this.lblVelikiRezultat.AutoSize = true;
            this.lblVelikiRezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F, System.Drawing.FontStyle.Bold);
            this.lblVelikiRezultat.Location = new System.Drawing.Point(10, 14);
            this.lblVelikiRezultat.Name = "lblVelikiRezultat";
            this.lblVelikiRezultat.Size = new System.Drawing.Size(300, 30);
            this.lblVelikiRezultat.TabIndex = 4;
            this.lblVelikiRezultat.Text = "KONVERTOR VALUTA";
            this.lblVelikiRezultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVelikiRezultat.Click += new System.EventHandler(this.lblVelikiRezultat_Click);
            // 
            // btnConvertNow
            // 
            this.btnConvertNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnConvertNow.Location = new System.Drawing.Point(49, 157);
            this.btnConvertNow.Name = "btnConvertNow";
            this.btnConvertNow.Size = new System.Drawing.Size(212, 59);
            this.btnConvertNow.TabIndex = 3;
            this.btnConvertNow.Text = "Pokreni konverziju";
            this.btnConvertNow.UseVisualStyleBackColor = true;
            this.btnConvertNow.Click += new System.EventHandler(this.btnConvertNow_Click);
            // 
            // lblConverterResult
            // 
            this.lblConverterResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold);
            this.lblConverterResult.Location = new System.Drawing.Point(3, 207);
            this.lblConverterResult.Name = "lblConverterResult";
            this.lblConverterResult.Size = new System.Drawing.Size(313, 140);
            this.lblConverterResult.TabIndex = 2;
            this.lblConverterResult.Text = "Rezultat";
            this.lblConverterResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCiljna
            // 
            this.cmbCiljna.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCiljna.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCiljna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmbCiljna.FormattingEnabled = true;
            this.cmbCiljna.Location = new System.Drawing.Point(49, 96);
            this.cmbCiljna.Name = "cmbCiljna";
            this.cmbCiljna.Size = new System.Drawing.Size(212, 25);
            this.cmbCiljna.TabIndex = 1;
            this.cmbCiljna.Text = "Odaberi konverziju";
            this.cmbCiljna.SelectedIndexChanged += new System.EventHandler(this.cmbCiljna_SelectedIndexChanged);
            // 
            // txtValueToConvert
            // 
            this.txtValueToConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtValueToConvert.Location = new System.Drawing.Point(49, 67);
            this.txtValueToConvert.Name = "txtValueToConvert";
            this.txtValueToConvert.Size = new System.Drawing.Size(115, 23);
            this.txtValueToConvert.TabIndex = 0;
            this.txtValueToConvert.Text = "Unesi vrijednost";
            this.txtValueToConvert.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnHistory
            // 
            this.btnHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHistory.BackgroundImage")));
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.Location = new System.Drawing.Point(186, -4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(47, 46);
            this.btnHistory.TabIndex = 20;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click_1);
            // 
            // btnLightMode
            // 
            this.btnLightMode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLightMode.BackgroundImage")));
            this.btnLightMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLightMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLightMode.Location = new System.Drawing.Point(133, -4);
            this.btnLightMode.Name = "btnLightMode";
            this.btnLightMode.Size = new System.Drawing.Size(47, 46);
            this.btnLightMode.TabIndex = 19;
            this.btnLightMode.UseVisualStyleBackColor = true;
            this.btnLightMode.Click += new System.EventHandler(this.btnLightMode_Click_1);
            // 
            // btnDarkMode
            // 
            this.btnDarkMode.BackColor = System.Drawing.SystemColors.Control;
            this.btnDarkMode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDarkMode.BackgroundImage")));
            this.btnDarkMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDarkMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDarkMode.Location = new System.Drawing.Point(85, -4);
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Size = new System.Drawing.Size(42, 46);
            this.btnDarkMode.TabIndex = 18;
            this.btnDarkMode.UseVisualStyleBackColor = false;
            this.btnDarkMode.Click += new System.EventHandler(this.btnDarkMode_Click);
            // 
            // btnMode
            // 
            this.btnMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnMode.Location = new System.Drawing.Point(282, 401);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(33, 61);
            this.btnMode.TabIndex = 26;
            this.btnMode.Text = "🧹";
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdvanced.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdvanced.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.btnAdvanced.Location = new System.Drawing.Point(161, 400);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(120, 62);
            this.btnAdvanced.TabIndex = 6;
            this.btnAdvanced.Text = "Napredno";
            this.btnAdvanced.UseVisualStyleBackColor = false;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 474);
            this.Controls.Add(this.pnlConverter);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnInverse);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnLightMode);
            this.Controls.Add(this.btnDarkMode);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.pnlConverter.ResumeLayout(false);
            this.pnlConverter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Panel pnlConverter;
        private System.Windows.Forms.ComboBox cmbCiljna;
        private System.Windows.Forms.TextBox txtValueToConvert;
        private System.Windows.Forms.Button btnConvertNow;
        private System.Windows.Forms.Label lblConverterResult;
        private System.Windows.Forms.Label lblVelikiRezultat;
        private System.Windows.Forms.ComboBox cmbIzvorna;
        private System.Windows.Forms.Label lblStatusKursa;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnLightMode;
        private System.Windows.Forms.Button btnDarkMode;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Button btnAdvanced;
    }
}

