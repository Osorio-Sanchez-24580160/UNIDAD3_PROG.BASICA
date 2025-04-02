namespace Practica_13
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 45);
            label1.Name = "label1";
            label1.Size = new Size(382, 72);
            label1.TabIndex = 0;
            label1.Text = "Dado como dato el sueldo de un trabajador,\r\nel programa aplica un aumento del 15% si\r\nel sueldo es menor de 400,000.\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 172);
            label2.Name = "label2";
            label2.Size = new Size(142, 24);
            label2.TabIndex = 1;
            label2.Text = "Ingresa sueldo: \r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 325);
            label3.Name = "label3";
            label3.Size = new Size(136, 24);
            label3.TabIndex = 2;
            label3.Text = "Nuevo sueldo: \r\n";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(201, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 32);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(201, 322);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 32);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(53, 248);
            button1.Name = "button1";
            button1.Size = new Size(146, 32);
            button1.TabIndex = 5;
            button1.Text = "DECISIÓN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(211, 248);
            button2.Name = "button2";
            button2.Size = new Size(146, 32);
            button2.TabIndex = 6;
            button2.Text = "BORRAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Práctica 13";
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
    }
}
