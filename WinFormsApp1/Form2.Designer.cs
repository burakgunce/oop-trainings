namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 19);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 51);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 83);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 122);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 161);
            label5.Name = "label5";
            label5.Size = new Size(30, 20);
            label5.TabIndex = 4;
            label5.Text = "Yaş";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 300);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 5;
            label6.Text = "Eğitim";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(124, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(124, 122);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(178, 27);
            textBox4.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(124, 161);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(175, 27);
            numericUpDown1.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Üniversite", "Lise", "İlkokul" });
            comboBox1.Location = new Point(124, 297);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(37, 210);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 66);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cinsiyet";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(111, 31);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(68, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Kadın";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Erkek";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(30, 344);
            button1.Name = "button1";
            button1.Size = new Size(255, 44);
            button1.TabIndex = 13;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(698, 344);
            button2.Name = "button2";
            button2.Size = new Size(80, 42);
            button2.TabIndex = 14;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(328, 24);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(450, 304);
            listBox1.TabIndex = 15;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
    }
}