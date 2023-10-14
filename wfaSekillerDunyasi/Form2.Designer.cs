namespace wfaSekillerDunyasi
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            nudX = new NumericUpDown();
            nudY = new NumericUpDown();
            nudGenislik = new NumericUpDown();
            nudYukseklik = new NumericUpDown();
            cboTur = new ComboBox();
            lstSekiller = new ListBox();
            pboRenk = new PictureBox();
            btnRastgeleEkle = new Button();
            btnEkle = new Button();
            btnYukari = new Button();
            btnSil = new Button();
            btnAsagi = new Button();
            pnlCizim = new Panel();
            btnTemizle = new Button();
            btnKaydet = new Button();
            colorDialog1 = new ColorDialog();
            label7 = new Label();
            txtMetin = new TextBox();
            btnMetinEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)nudX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGenislik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudYukseklik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboRenk).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 18);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 0;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 18);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 1;
            label2.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 18);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Genişlik";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 18);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "Yükseklik";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(403, 18);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 4;
            label5.Text = "Şekil Türü";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(521, 18);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 5;
            label6.Text = "Renk";
            // 
            // nudX
            // 
            nudX.Location = new Point(28, 50);
            nudX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudX.Name = "nudX";
            nudX.Size = new Size(79, 27);
            nudX.TabIndex = 6;
            // 
            // nudY
            // 
            nudY.Location = new Point(113, 50);
            nudY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudY.Name = "nudY";
            nudY.Size = new Size(79, 27);
            nudY.TabIndex = 7;
            // 
            // nudGenislik
            // 
            nudGenislik.Location = new Point(207, 50);
            nudGenislik.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudGenislik.Name = "nudGenislik";
            nudGenislik.Size = new Size(79, 27);
            nudGenislik.TabIndex = 8;
            nudGenislik.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // nudYukseklik
            // 
            nudYukseklik.Location = new Point(305, 49);
            nudYukseklik.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudYukseklik.Name = "nudYukseklik";
            nudYukseklik.Size = new Size(79, 27);
            nudYukseklik.TabIndex = 9;
            nudYukseklik.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // cboTur
            // 
            cboTur.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTur.FormattingEnabled = true;
            cboTur.Items.AddRange(new object[] { "Dikdörtgen", "Elips" });
            cboTur.Location = new Point(403, 49);
            cboTur.Name = "cboTur";
            cboTur.Size = new Size(90, 28);
            cboTur.TabIndex = 10;
            // 
            // lstSekiller
            // 
            lstSekiller.FormattingEnabled = true;
            lstSekiller.ItemHeight = 20;
            lstSekiller.Location = new Point(28, 93);
            lstSekiller.Name = "lstSekiller";
            lstSekiller.Size = new Size(630, 84);
            lstSekiller.TabIndex = 11;
            // 
            // pboRenk
            // 
            pboRenk.BackColor = SystemColors.ControlText;
            pboRenk.BorderStyle = BorderStyle.FixedSingle;
            pboRenk.Location = new Point(524, 49);
            pboRenk.Name = "pboRenk";
            pboRenk.Size = new Size(35, 27);
            pboRenk.TabIndex = 12;
            pboRenk.TabStop = false;
            pboRenk.Click += pboRenk_Click;
            // 
            // btnRastgeleEkle
            // 
            btnRastgeleEkle.Location = new Point(586, 48);
            btnRastgeleEkle.Name = "btnRastgeleEkle";
            btnRastgeleEkle.Size = new Size(55, 28);
            btnRastgeleEkle.TabIndex = 13;
            btnRastgeleEkle.Text = "?";
            btnRastgeleEkle.UseVisualStyleBackColor = true;
            btnRastgeleEkle.Click += btnRastgeleEkle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(659, 47);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(55, 28);
            btnEkle.TabIndex = 14;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnYukari
            // 
            btnYukari.BackgroundImage = (Image)resources.GetObject("btnYukari.BackgroundImage");
            btnYukari.BackgroundImageLayout = ImageLayout.Zoom;
            btnYukari.Location = new Point(677, 86);
            btnYukari.Name = "btnYukari";
            btnYukari.Size = new Size(37, 28);
            btnYukari.TabIndex = 15;
            btnYukari.UseVisualStyleBackColor = true;
            btnYukari.Click += btnYukari_Click;
            // 
            // btnSil
            // 
            btnSil.BackgroundImage = (Image)resources.GetObject("btnSil.BackgroundImage");
            btnSil.BackgroundImageLayout = ImageLayout.Zoom;
            btnSil.Location = new Point(677, 120);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(37, 28);
            btnSil.TabIndex = 16;
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnAsagi
            // 
            btnAsagi.BackgroundImage = (Image)resources.GetObject("btnAsagi.BackgroundImage");
            btnAsagi.BackgroundImageLayout = ImageLayout.Zoom;
            btnAsagi.Location = new Point(677, 154);
            btnAsagi.Name = "btnAsagi";
            btnAsagi.Size = new Size(37, 28);
            btnAsagi.TabIndex = 17;
            btnAsagi.UseVisualStyleBackColor = true;
            btnAsagi.Click += btnAsagi_Click;
            // 
            // pnlCizim
            // 
            pnlCizim.BackColor = Color.White;
            pnlCizim.Location = new Point(28, 191);
            pnlCizim.Name = "pnlCizim";
            pnlCizim.Size = new Size(686, 253);
            pnlCizim.TabIndex = 18;
            pnlCizim.Paint += pnlCizim_Paint;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(28, 459);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(100, 28);
            btnTemizle.TabIndex = 19;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(146, 459);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(100, 28);
            btnKaydet.TabIndex = 20;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 502);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 21;
            label7.Text = "Metin";
            
            // 
            // txtMetin
            // 
            txtMetin.Location = new Point(98, 499);
            txtMetin.Name = "txtMetin";
            txtMetin.Size = new Size(522, 27);
            txtMetin.TabIndex = 22;
            // 
            // btnMetinEkle
            // 
            btnMetinEkle.Location = new Point(626, 498);
            btnMetinEkle.Name = "btnMetinEkle";
            btnMetinEkle.Size = new Size(99, 28);
            btnMetinEkle.TabIndex = 23;
            btnMetinEkle.Text = "Metin Ekle";
            btnMetinEkle.UseVisualStyleBackColor = true;
            btnMetinEkle.Click += btnMetinEkle_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 743);
            Controls.Add(btnMetinEkle);
            Controls.Add(txtMetin);
            Controls.Add(label7);
            Controls.Add(btnKaydet);
            Controls.Add(btnTemizle);
            Controls.Add(pnlCizim);
            Controls.Add(btnAsagi);
            Controls.Add(btnSil);
            Controls.Add(btnYukari);
            Controls.Add(btnEkle);
            Controls.Add(btnRastgeleEkle);
            Controls.Add(pboRenk);
            Controls.Add(lstSekiller);
            Controls.Add(cboTur);
            Controls.Add(nudYukseklik);
            Controls.Add(nudGenislik);
            Controls.Add(nudY);
            Controls.Add(nudX);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)nudX).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGenislik).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudYukseklik).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboRenk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown nudX;
        private NumericUpDown nudY;
        private NumericUpDown nudGenislik;
        private NumericUpDown nudYukseklik;
        private ComboBox cboTur;
        private ListBox lstSekiller;
        private PictureBox pboRenk;
        private Button btnRastgeleEkle;
        private Button btnEkle;
        private Button btnYukari;
        private Button btnSil;
        private Button btnAsagi;
        private Panel pnlCizim;
        private Button btnTemizle;
        private Button btnKaydet;
        private ColorDialog colorDialog1;
        private Label label7;
        private TextBox txtMetin;
        private Button btnMetinEkle;
    }
}