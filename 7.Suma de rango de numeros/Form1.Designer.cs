namespace Suma_de_rango_de_numeros
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
            listBox1 = new ListBox();
            label4 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 51);
            label1.Name = "label1";
            label1.Size = new Size(675, 26);
            label1.TabIndex = 0;
            label1.Text = "Imprime números de un rango especifico y los suma \r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 132);
            label2.Name = "label2";
            label2.Size = new Size(138, 22);
            label2.TabIndex = 1;
            label2.Text = "Rango inferior";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(359, 132);
            label3.Name = "label3";
            label3.Size = new Size(147, 22);
            label3.TabIndex = 2;
            label3.Text = "Rango superior";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(205, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 29);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(525, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 29);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.Font = new Font("Verdana", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(455, 197);
            button1.Name = "button1";
            button1.Size = new Size(198, 47);
            button1.TabIndex = 5;
            button1.Text = "Imprime";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(158, 197);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(237, 204);
            listBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(158, 435);
            label4.Name = "label4";
            label4.Size = new Size(62, 22);
            label4.TabIndex = 7;
            label4.Text = "Suma";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(236, 430);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(128, 29);
            textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 564);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = " Sumando rango de números";
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
        private ListBox listBox1;
        private Label label4;
        private TextBox textBox3;
    }
}
