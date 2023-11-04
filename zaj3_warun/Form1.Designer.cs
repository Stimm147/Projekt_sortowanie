namespace zaj3_warun
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            checkBox1 = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            button6 = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 47);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 92);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 1;
            label1.Text = "...................................";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(86, 253);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 51);
            button1.TabIndex = 2;
            button1.Text = "\r\nSB";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(195, 253);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 51);
            button2.TabIndex = 3;
            button2.Text = "SS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(298, 253);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 51);
            button3.TabIndex = 4;
            button3.Text = "SI";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(405, 253);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 51);
            button4.TabIndex = 5;
            button4.Text = "SM";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(517, 253);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(82, 51);
            button5.TabIndex = 6;
            button5.Text = "SQ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(330, 52);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 7;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(405, 48);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(131, 23);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button6
            // 
            button6.Location = new Point(428, 92);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(82, 22);
            button6.TabIndex = 9;
            button6.Text = "Generuj";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(405, 141);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 10;
            label2.Text = "Czas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(493, 141);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(numericUpDown1);
            Controls.Add(checkBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown1;
        private Button button6;
        private Label label2;
        private Label label3;
    }
}