namespace WinFormsApp4
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
            btnEkle = new Button();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(16, 154);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(84, 27);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(16, 110);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(182, 27);
            txtSoyad.TabIndex = 9;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(16, 46);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(182, 27);
            txtAd.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 87);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 7;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 23);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 6;
            label1.Text = "Ad";
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(115, 154);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(83, 27);
            btnIptal.TabIndex = 11;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(210, 203);
            Controls.Add(btnIptal);
            Controls.Add(btnEkle);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label2;
        private Label label1;
        private Button btnIptal;
    }
}