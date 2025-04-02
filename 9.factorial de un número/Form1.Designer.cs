namespace factorial_de_un_número
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
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 52);
            label1.Name = "label1";
            label1.Size = new Size(303, 26);
            label1.TabIndex = 0;
            label1.Text = "Factorial de un número";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(404, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 34);
            textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(281, 107);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(250, 179);
            listBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 336);
            label2.Name = "label2";
            label2.Size = new Size(271, 26);
            label2.TabIndex = 3;
            label2.Text = "Factorial del número";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(425, 336);
            label3.Name = "label3";
            label3.Size = new Size(40, 26);
            label3.TabIndex = 4;
            label3.Text = "es";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(292, 333);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 34);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(471, 336);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(248, 29);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOliveGreen;
            button1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(564, 107);
            button1.Name = "button1";
            button1.Size = new Size(133, 38);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOliveGreen;
            button2.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(564, 175);
            button2.Name = "button2";
            button2.Size = new Size(133, 38);
            button2.TabIndex = 8;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(750, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "  Factorial de un número";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
    }
}
