namespace Cliente
{
    partial class Agregar_Producto
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Aceptar_Btn = new System.Windows.Forms.Button();
            this.Cancelar_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "# Serie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Vencimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(66, 246);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 78);
            this.label4.TabIndex = 6;
            this.label4.Text = "Instrucciones:\r\n\r\n1) Introduzca el número de serie del producto\r\n2) Seleccione el" +
    " producto (eg salsa)\r\n3) Indique la fecha de vencimiento\r\n4) Presione Aceptar";
            // 
            // Aceptar_Btn
            // 
            this.Aceptar_Btn.Location = new System.Drawing.Point(66, 289);
            this.Aceptar_Btn.Name = "Aceptar_Btn";
            this.Aceptar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Aceptar_Btn.TabIndex = 7;
            this.Aceptar_Btn.Text = "Aceptar";
            this.Aceptar_Btn.UseVisualStyleBackColor = true;
            this.Aceptar_Btn.Click += new System.EventHandler(this.Aceptar_Btn_Click);
            // 
            // Cancelar_Btn
            // 
            this.Cancelar_Btn.Location = new System.Drawing.Point(147, 289);
            this.Cancelar_Btn.Name = "Cancelar_Btn";
            this.Cancelar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Cancelar_Btn.TabIndex = 8;
            this.Cancelar_Btn.Text = "Cancelar";
            this.Cancelar_Btn.UseVisualStyleBackColor = true;
            this.Cancelar_Btn.Click += new System.EventHandler(this.Cancelar_Btn_Click);
            // 
            // Agregar_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 358);
            this.Controls.Add(this.Cancelar_Btn);
            this.Controls.Add(this.Aceptar_Btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Agregar_Producto";
            this.Text = "Agregar_Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Aceptar_Btn;
        private System.Windows.Forms.Button Cancelar_Btn;
    }
}