namespace introduce_y_suma_numeros
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 39);
            label1.Name = "label1";
            label1.Size = new Size(428, 27);
            label1.TabIndex = 0;
            label1.Text = "Este programa suma los números capturados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 103);
            label2.Name = "label2";
            label2.Size = new Size(208, 27);
            label2.TabIndex = 1;
            label2.Text = "Introduce un número";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(83, 210);
            label3.Name = "label3";
            label3.Size = new Size(177, 54);
            label3.TabIndex = 2;
            label3.Text = "La suma de todos \r\nlos números es:\r\n";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(304, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 34);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(304, 219);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 34);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(320, 147);
            button1.Name = "button1";
            button1.Size = new Size(138, 38);
            button1.TabIndex = 5;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(554, 313);
            button2.Name = "button2";
            button2.Size = new Size(170, 38);
            button2.TabIndex = 6;
            button2.Text = "Sumar números";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(536, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(209, 229);
            listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Introduce y suma números";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
    }
}
