﻿namespace Area_Triangulo
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
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 53);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 0;
            label1.Text = "Área de Triangulo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 132);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 1;
            label2.Text = "Base";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(63, 179);
            label3.Name = "label3";
            label3.Size = new Size(91, 28);
            label3.TabIndex = 2;
            label3.Text = "Altura";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(229, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 36);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(229, 176);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 36);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(85, 255);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 5;
            label4.Text = "Área";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(229, 252);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 36);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Azure;
            button1.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(152, 330);
            button1.Name = "button1";
            button1.Size = new Size(168, 34);
            button1.TabIndex = 7;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(485, 394);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calcular área de triangulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Button button1;
    }
}
