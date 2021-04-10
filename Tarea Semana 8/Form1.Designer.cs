
namespace ProyectoPromedios
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMayorNota = new System.Windows.Forms.TextBox();
            this.TxtMenorNota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPromedioMayor = new System.Windows.Forms.TextBox();
            this.txtPromedioMenor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cargar Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(541, 22);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(439, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(339, 500);
            this.listBox1.TabIndex = 2;
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(47, 142);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDatos.Size = new System.Drawing.Size(386, 499);
            this.txtDatos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ruta del archivo seleccionado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datos del archivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datos Ordenados Por Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(733, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Alumno Mayor Nota";
            // 
            // txtMayorNota
            // 
            this.txtMayorNota.Location = new System.Drawing.Point(736, 47);
            this.txtMayorNota.Multiline = true;
            this.txtMayorNota.Name = "txtMayorNota";
            this.txtMayorNota.Size = new System.Drawing.Size(258, 52);
            this.txtMayorNota.TabIndex = 10;
            // 
            // TxtMenorNota
            // 
            this.TxtMenorNota.Location = new System.Drawing.Point(1000, 47);
            this.TxtMenorNota.Multiline = true;
            this.TxtMenorNota.Name = "TxtMenorNota";
            this.TxtMenorNota.Size = new System.Drawing.Size(258, 49);
            this.TxtMenorNota.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(997, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Alumno Menor Nota";
            // 
            // TxtPromedioMayor
            // 
            this.TxtPromedioMayor.Location = new System.Drawing.Point(736, 105);
            this.TxtPromedioMayor.Name = "TxtPromedioMayor";
            this.TxtPromedioMayor.Size = new System.Drawing.Size(258, 22);
            this.TxtPromedioMayor.TabIndex = 13;
            // 
            // txtPromedioMenor
            // 
            this.txtPromedioMenor.Location = new System.Drawing.Point(1000, 102);
            this.txtPromedioMenor.Name = "txtPromedioMenor";
            this.txtPromedioMenor.Size = new System.Drawing.Size(258, 22);
            this.txtPromedioMenor.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(781, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Datos Ordenados con Promedio";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(784, 152);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(474, 484);
            this.listBox2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 653);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.txtPromedioMenor);
            this.Controls.Add(this.TxtPromedioMayor);
            this.Controls.Add(this.TxtMenorNota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMayorNota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMayorNota;
        private System.Windows.Forms.TextBox TxtMenorNota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPromedioMayor;
        private System.Windows.Forms.TextBox txtPromedioMenor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox2;
    }
}

