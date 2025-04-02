namespace Practica_18
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
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 89);
            label1.Name = "label1";
            label1.Size = new Size(155, 27);
            label1.TabIndex = 0;
            label1.Text = "Longitud lado A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(83, 153);
            label2.Name = "label2";
            label2.Size = new Size(154, 27);
            label2.TabIndex = 1;
            label2.Text = "Longitud lado B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(83, 221);
            label3.Name = "label3";
            label3.Size = new Size(154, 27);
            label3.TabIndex = 2;
            label3.Text = "Longitud lado C";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(253, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 34);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(253, 150);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 34);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(253, 218);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(215, 34);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(64, 350);
            label4.Name = "label4";
            label4.Size = new Size(174, 27);
            label4.TabIndex = 6;
            label4.Text = "Tipo de triangulo:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(253, 347);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(215, 34);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(46, 289);
            button1.Name = "button1";
            button1.Size = new Size(147, 39);
            button1.TabIndex = 8;
            button1.Text = "Decisión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkCyan;
            button2.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(222, 289);
            button2.Name = "button2";
            button2.Size = new Size(147, 39);
            button2.TabIndex = 9;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkCyan;
            button3.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(385, 289);
            button3.Name = "button3";
            button3.Size = new Size(147, 39);
            button3.TabIndex = 9;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(99, 27);
            label5.Name = "label5";
            label5.Size = new Size(599, 24);
            label5.TabIndex = 10;
            label5.Text = "Este programa dice el tipo de triangulo por los datos que introduzcas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.triangulos;
            pictureBox1.Location = new Point(549, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Practica 18";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label5;
        private PictureBox pictureBox1;
    }
}
