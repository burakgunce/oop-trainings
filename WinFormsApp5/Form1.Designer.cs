namespace WinFormsApp5
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
            numericUpDown1 = new NumericUpDown();
            listBox1 = new ListBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 44);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Girilen Sayi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 76);
            label2.Name = "label2";
            label2.Size = new Size(246, 20);
            label2.TabIndex = 1;
            label2.Text = "Girilen sayıya kadar olan asal sayılar";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(137, 37);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(74, 109);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(193, 304);
            listBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(285, 109);
            button1.Name = "button1";
            button1.Size = new Size(66, 72);
            button1.TabIndex = 4;
            button1.Text = "asal sayıları bul";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 450);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private ListBox listBox1;
        private Button button1;
    }
}