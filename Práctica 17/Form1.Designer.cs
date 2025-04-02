namespace Práctica_17
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
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 40);
            label1.Name = "label1";
            label1.Size = new Size(509, 27);
            label1.TabIndex = 0;
            label1.Text = "Este programa ordena los números de mayor a menor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(135, 183);
            label2.Name = "label2";
            label2.Size = new Size(25, 27);
            label2.TabIndex = 1;
            label2.Text = "A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(262, 183);
            label3.Name = "label3";
            label3.Size = new Size(24, 27);
            label3.TabIndex = 2;
            label3.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(394, 183);
            label4.Name = "label4";
            label4.Size = new Size(24, 27);
            label4.TabIndex = 3;
            label4.Text = "C";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(101, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 34);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(228, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(94, 34);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(355, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(94, 34);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(86, 239);
            button1.Name = "button1";
            button1.Size = new Size(123, 37);
            button1.TabIndex = 7;
            button1.Text = "Ordenar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.OliveDrab;
            button2.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(215, 239);
            button2.Name = "button2";
            button2.Size = new Size(123, 37);
            button2.TabIndex = 8;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.OliveDrab;
            button3.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(344, 239);
            button3.Name = "button3";
            button3.Size = new Size(123, 37);
            button3.TabIndex = 9;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(101, 307);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(94, 34);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(228, 307);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(94, 34);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(355, 307);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(94, 34);
            textBox6.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(587, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = " Práctica 17";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}
