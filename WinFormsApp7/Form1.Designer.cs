namespace WinFormsApp7
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
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 41);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Ürün İd";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 92);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Ürün Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 132);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 2;
            label3.Text = "Ürün Açıklaması";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 183);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 3;
            label4.Text = "Üretim Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 226);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 4;
            label5.Text = "Garanti Süresi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 27);
            textBox3.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(138, 178);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(161, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(138, 221);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(161, 27);
            dateTimePicker2.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(24, 269);
            button1.Name = "button1";
            button1.Size = new Size(118, 43);
            button1.TabIndex = 10;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(195, 269);
            button2.Name = "button2";
            button2.Size = new Size(107, 42);
            button2.TabIndex = 11;
            button2.Text = "Listeye Git";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 348);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private Button button2;
    }
}