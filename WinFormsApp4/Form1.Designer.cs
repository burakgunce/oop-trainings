namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            btnEkle = new Button();
            btnDuzenle = new Button();
            btnSil = new Button();
            btnYukari = new Button();
            btnAsagi = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(21, 82);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(325, 324);
            listBox1.TabIndex = 0;
            listBox1.KeyDown += listBox1_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 13);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 1;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 13);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Soyad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(21, 36);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(104, 27);
            txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(138, 36);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(104, 27);
            txtSoyad.TabIndex = 4;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(262, 36);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(84, 27);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(21, 412);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(102, 30);
            btnDuzenle.TabIndex = 6;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(135, 412);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(96, 30);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnYukari
            // 
            btnYukari.BackgroundImage = (Image)resources.GetObject("btnYukari.BackgroundImage");
            btnYukari.BackgroundImageLayout = ImageLayout.Zoom;
            btnYukari.Location = new Point(363, 205);
            btnYukari.Name = "btnYukari";
            btnYukari.Size = new Size(37, 38);
            btnYukari.TabIndex = 8;
            btnYukari.UseVisualStyleBackColor = true;
            btnYukari.Click += btnYukari_Click;
            // 
            // btnAsagi
            // 
            btnAsagi.BackgroundImage = (Image)resources.GetObject("btnAsagi.BackgroundImage");
            btnAsagi.BackgroundImageLayout = ImageLayout.Zoom;
            btnAsagi.Location = new Point(363, 249);
            btnAsagi.Name = "btnAsagi";
            btnAsagi.Size = new Size(37, 38);
            btnAsagi.TabIndex = 9;
            btnAsagi.UseVisualStyleBackColor = true;
            btnAsagi.Click += btnAsagi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 450);
            Controls.Add(btnAsagi);
            Controls.Add(btnYukari);
            Controls.Add(btnSil);
            Controls.Add(btnDuzenle);
            Controls.Add(btnEkle);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Button btnEkle;
        private Button btnDuzenle;
        private Button btnSil;
        private Button btnYukari;
        private Button btnAsagi;
    }
}