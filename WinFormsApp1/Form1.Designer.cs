namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 26);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Marka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 86);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 143);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 2;
            label3.Text = "Yıl";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 27);
            textBox2.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(43, 213);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(174, 142);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Renkler";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(37, 94);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(95, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mat Siyah";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(37, 48);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(119, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sedefli Beyaz";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(125, 136);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(157, 27);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(141, 363);
            numericUpDown2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(158, 27);
            numericUpDown2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 365);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 9;
            label4.Text = "Motor Hacmi";
            // 
            // button1
            // 
            button1.Location = new Point(59, 401);
            button1.Name = "button1";
            button1.Size = new Size(223, 54);
            button1.TabIndex = 10;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(330, 23);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(310, 364);
            listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 478);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private Button button1;
        private ListBox listBox1;
    }
}