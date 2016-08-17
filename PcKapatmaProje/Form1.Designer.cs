namespace PcKapat
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
            this.components = new System.ComponentModel.Container();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.numericSaat = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericDakika = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbZorla = new System.Windows.Forms.CheckBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbislem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericSaniye = new System.Windows.Forms.NumericUpDown();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lbislemSira = new System.Windows.Forms.ListBox();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.iptalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericSaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDakika)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSaniye)).BeginInit();
            this.Menu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // numericSaat
            // 
            this.numericSaat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericSaat.Location = new System.Drawing.Point(50, 23);
            this.numericSaat.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericSaat.Name = "numericSaat";
            this.numericSaat.Size = new System.Drawing.Size(40, 20);
            this.numericSaat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dakika";
            // 
            // numericDakika
            // 
            this.numericDakika.Location = new System.Drawing.Point(138, 23);
            this.numericDakika.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericDakika.Name = "numericDakika";
            this.numericDakika.Size = new System.Drawing.Size(40, 20);
            this.numericDakika.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbZorla);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbislem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericSaat);
            this.groupBox1.Controls.Add(this.numericSaniye);
            this.groupBox1.Controls.Add(this.numericDakika);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saat Ayar İşlemleri";
            // 
            // cbZorla
            // 
            this.cbZorla.AutoSize = true;
            this.cbZorla.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbZorla.Checked = true;
            this.cbZorla.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbZorla.Location = new System.Drawing.Point(6, 90);
            this.cbZorla.Name = "cbZorla";
            this.cbZorla.Size = new System.Drawing.Size(102, 17);
            this.cbZorla.TabIndex = 6;
            this.cbZorla.Text = "Kapatmayı Zorla";
            this.cbZorla.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(207, 77);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(61, 40);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(114, 77);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(86, 40);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "İşlem";
            // 
            // cbislem
            // 
            this.cbislem.FormattingEnabled = true;
            this.cbislem.Location = new System.Drawing.Point(50, 50);
            this.cbislem.Name = "cbislem";
            this.cbislem.Size = new System.Drawing.Size(218, 21);
            this.cbislem.TabIndex = 3;
            this.cbislem.Text = "Bir Seçim Yapın";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Saniye";
            // 
            // numericSaniye
            // 
            this.numericSaniye.Location = new System.Drawing.Point(228, 23);
            this.numericSaniye.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericSaniye.Name = "numericSaniye";
            this.numericSaniye.Size = new System.Drawing.Size(40, 20);
            this.numericSaniye.TabIndex = 0;
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(0, 233);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(0, 73);
            this.lblSaat.TabIndex = 4;
            this.lblSaat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbislemSira
            // 
            this.lbislemSira.ContextMenuStrip = this.Menu;
            this.lbislemSira.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbislemSira.FormattingEnabled = true;
            this.lbislemSira.Location = new System.Drawing.Point(3, 16);
            this.lbislemSira.MultiColumn = true;
            this.lbislemSira.Name = "lbislemSira";
            this.lbislemSira.Size = new System.Drawing.Size(390, 273);
            this.lbislemSira.TabIndex = 5;
            this.lbislemSira.SelectedIndexChanged += new System.EventHandler(this.lbislemSira_SelectedIndexChanged);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iptalToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(111, 26);
            // 
            // iptalToolStripMenuItem
            // 
            this.iptalToolStripMenuItem.Name = "iptalToolStripMenuItem";
            this.iptalToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.iptalToolStripMenuItem.Text = "İptal Et";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lbislemSira);
            this.groupBox2.Location = new System.Drawing.Point(294, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 292);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlem Sırası";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 306);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgisayar Kapatıcı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericSaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDakika)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSaniye)).EndInit();
            this.Menu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.NumericUpDown numericSaat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericDakika;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbislem;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericSaniye;
        private System.Windows.Forms.CheckBox cbZorla;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem iptalToolStripMenuItem;
        private System.Windows.Forms.ListBox lbislemSira;
    }
}

