namespace Grados
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
            valor = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Resultado = new TextBox();
            etiqueta = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SolidWorks GDT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 33);
            label1.Name = "label1";
            label1.Size = new Size(74, 24);
            label1.TabIndex = 0;
            label1.Text = "Datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SolidWorks GDT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(185, 84);
            label2.Name = "label2";
            label2.Size = new Size(191, 24);
            label2.TabIndex = 1;
            label2.Text = "Ingresa el valor:";
            // 
            // valor
            // 
            valor.Location = new Point(404, 80);
            valor.Name = "valor";
            valor.Size = new Size(182, 31);
            valor.TabIndex = 2;
            valor.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SolidWorks GDT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 148);
            label3.Name = "label3";
            label3.Size = new Size(273, 24);
            label3.TabIndex = 3;
            label3.Text = "Opciones de conversion";
            // 
            // button1
            // 
            button1.Font = new Font("SolidWorks GDT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(105, 215);
            button1.Name = "button1";
            button1.Size = new Size(156, 34);
            button1.TabIndex = 4;
            button1.Text = "FAHRENHEIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("SolidWorks GDT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(313, 215);
            button2.Name = "button2";
            button2.Size = new Size(180, 34);
            button2.TabIndex = 5;
            button2.Text = "CENTIGRADOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("SolidWorks GDT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(542, 215);
            button3.Name = "button3";
            button3.Size = new Size(156, 34);
            button3.TabIndex = 6;
            button3.Text = "BORRAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SolidWorks GDT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(76, 289);
            label4.Name = "label4";
            label4.Size = new Size(237, 24);
            label4.TabIndex = 7;
            label4.Text = "Resultado en grados";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SolidWorks GDT", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(109, 346);
            label5.Name = "label5";
            label5.Size = new Size(267, 24);
            label5.TabIndex = 8;
            label5.Text = "Equivalente en grados:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(443, 346);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 9;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(404, 339);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(89, 31);
            Resultado.TabIndex = 10;
            // 
            // etiqueta
            // 
            etiqueta.AutoSize = true;
            etiqueta.Location = new Point(526, 348);
            etiqueta.Name = "etiqueta";
            etiqueta.Size = new Size(59, 25);
            etiqueta.TabIndex = 11;
            etiqueta.Text = "label7";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 450);
            Controls.Add(etiqueta);
            Controls.Add(Resultado);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(valor);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Conversion de grados F a C y viceversa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox valor;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Resultado;
        private Label etiqueta;
    }
}
