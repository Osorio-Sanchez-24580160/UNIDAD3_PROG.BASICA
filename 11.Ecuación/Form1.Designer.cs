namespace Ecuación
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
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(196, 73);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 26);
            label1.TabIndex = 0;
            label1.Text = "f(x) = ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 11F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(284, 64);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(156, 26);
            label4.TabIndex = 3;
            label4.Text = "_________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 11F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(339, 58);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(35, 26);
            label5.TabIndex = 4;
            label5.Text = "x ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(381, 90);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 22);
            label2.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 11F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(311, 100);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 26);
            label6.TabIndex = 6;
            label6.Text = "1 + x";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(381, 90);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(23, 22);
            label3.TabIndex = 7;
            label3.Text = "2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 11F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(104, 154);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(35, 26);
            label7.TabIndex = 8;
            label7.Text = "x ";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 11F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(251, 154);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(60, 26);
            label8.TabIndex = 9;
            label8.Text = "f(x)";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 26;
            listBox1.Location = new Point(58, 192);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(123, 212);
            listBox1.TabIndex = 10;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 26;
            listBox2.Location = new Point(216, 192);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(123, 212);
            listBox2.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Location = new Point(405, 192);
            button1.Name = "button1";
            button1.Size = new Size(148, 48);
            button1.TabIndex = 12;
            button1.Text = "for";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.Location = new Point(405, 246);
            button2.Name = "button2";
            button2.Size = new Size(148, 48);
            button2.TabIndex = 13;
            button2.Text = "while";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.Location = new Point(405, 300);
            button3.Name = "button3";
            button3.Size = new Size(148, 48);
            button3.TabIndex = 14;
            button3.Text = "do...while";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DeepSkyBlue;
            button4.Location = new Point(405, 354);
            button4.Name = "button4";
            button4.Size = new Size(148, 48);
            button4.TabIndex = 15;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(635, 468);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Verdana", 11F, FontStyle.Bold | FontStyle.Italic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Ecuacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label6;
        private Label label3;
        private Label label7;
        private Label label8;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
