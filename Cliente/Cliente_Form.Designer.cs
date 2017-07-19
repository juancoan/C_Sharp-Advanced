using System;

namespace Cliente
{
    partial class Cliente_Form
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

        internal static void Agregar_Producto(string text1, string valueMember, string text2, int v)
        {
            throw new NotImplementedException();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Agregar_btn = new System.Windows.Forms.Button();
            this.Mover_btn = new System.Windows.Forms.Button();
            this.Refrescar_btn = new System.Windows.Forms.Button();
            this.Consumir_btn = new System.Windows.Forms.Button();
            this.sucursaltextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage0 = new System.Windows.Forms.TabPage();
            this.mensaje_auth = new System.Windows.Forms.Label();
            this.Autenticar_Btn = new System.Windows.Forms.Button();
            this.box_pass = new System.Windows.Forms.TextBox();
            this.box_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage0.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage0);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(64, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 363);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Catalogo Disponible";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(893, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inventario Local";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(896, 341);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(892, 337);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lista de Compras";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(886, 331);
            this.dataGridView3.TabIndex = 0;
            // 
            // Agregar_btn
            // 
            this.Agregar_btn.Enabled = false;
            this.Agregar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar_btn.Location = new System.Drawing.Point(71, 448);
            this.Agregar_btn.Name = "Agregar_btn";
            this.Agregar_btn.Size = new System.Drawing.Size(117, 45);
            this.Agregar_btn.TabIndex = 2;
            this.Agregar_btn.Text = "Agregar";
            this.Agregar_btn.UseVisualStyleBackColor = true;
            this.Agregar_btn.Click += new System.EventHandler(this.Agregar_btn_Click);
            // 
            // Mover_btn
            // 
            this.Mover_btn.Enabled = false;
            this.Mover_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mover_btn.Location = new System.Drawing.Point(212, 448);
            this.Mover_btn.Name = "Mover_btn";
            this.Mover_btn.Size = new System.Drawing.Size(169, 45);
            this.Mover_btn.TabIndex = 3;
            this.Mover_btn.Text = "Mover a Local";
            this.Mover_btn.UseVisualStyleBackColor = true;
            this.Mover_btn.Click += new System.EventHandler(this.Mover_btn_Click);
            // 
            // Refrescar_btn
            // 
            this.Refrescar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refrescar_btn.Location = new System.Drawing.Point(404, 448);
            this.Refrescar_btn.Name = "Refrescar_btn";
            this.Refrescar_btn.Size = new System.Drawing.Size(117, 45);
            this.Refrescar_btn.TabIndex = 5;
            this.Refrescar_btn.Text = "Refrescar";
            this.Refrescar_btn.UseVisualStyleBackColor = true;
            this.Refrescar_btn.Click += new System.EventHandler(this.Refrescar_btn_Click);
            // 
            // Consumir_btn
            // 
            this.Consumir_btn.Enabled = false;
            this.Consumir_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consumir_btn.Location = new System.Drawing.Point(546, 448);
            this.Consumir_btn.Name = "Consumir_btn";
            this.Consumir_btn.Size = new System.Drawing.Size(117, 45);
            this.Consumir_btn.TabIndex = 6;
            this.Consumir_btn.Text = "Consumir";
            this.Consumir_btn.UseVisualStyleBackColor = true;
            this.Consumir_btn.Click += new System.EventHandler(this.Consumir_btn_Click);
            // 
            // sucursaltextbox
            // 
            this.sucursaltextbox.Location = new System.Drawing.Point(509, 35);
            this.sucursaltextbox.Name = "sucursaltextbox";
            this.sucursaltextbox.Size = new System.Drawing.Size(100, 20);
            this.sucursaltextbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Indicar Sucursal #";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage0
            // 
            this.tabPage0.Controls.Add(this.mensaje_auth);
            this.tabPage0.Controls.Add(this.Autenticar_Btn);
            this.tabPage0.Controls.Add(this.box_pass);
            this.tabPage0.Controls.Add(this.box_user);
            this.tabPage0.Controls.Add(this.label2);
            this.tabPage0.Controls.Add(this.label3);
            this.tabPage0.Location = new System.Drawing.Point(4, 22);
            this.tabPage0.Name = "tabPage0";
            this.tabPage0.Size = new System.Drawing.Size(892, 337);
            this.tabPage0.TabIndex = 3;
            this.tabPage0.Text = "Inicio";
            this.tabPage0.UseVisualStyleBackColor = true;
            // 
            // mensaje_auth
            // 
            this.mensaje_auth.AutoSize = true;
            this.mensaje_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensaje_auth.ForeColor = System.Drawing.Color.Red;
            this.mensaje_auth.Location = new System.Drawing.Point(413, 107);
            this.mensaje_auth.Name = "mensaje_auth";
            this.mensaje_auth.Size = new System.Drawing.Size(0, 20);
            this.mensaje_auth.TabIndex = 11;
            // 
            // Autenticar_Btn
            // 
            this.Autenticar_Btn.Location = new System.Drawing.Point(240, 200);
            this.Autenticar_Btn.Name = "Autenticar_Btn";
            this.Autenticar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Autenticar_Btn.TabIndex = 10;
            this.Autenticar_Btn.Text = "Autenticar";
            this.Autenticar_Btn.UseVisualStyleBackColor = true;
            this.Autenticar_Btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // box_pass
            // 
            this.box_pass.Location = new System.Drawing.Point(240, 145);
            this.box_pass.Name = "box_pass";
            this.box_pass.Size = new System.Drawing.Size(100, 20);
            this.box_pass.TabIndex = 9;
            // 
            // box_user
            // 
            this.box_user.Location = new System.Drawing.Point(240, 98);
            this.box_user.Name = "box_user";
            this.box_user.Size = new System.Drawing.Size(100, 20);
            this.box_user.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Establecer Sucursal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cliente_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sucursaltextbox);
            this.Controls.Add(this.Consumir_btn);
            this.Controls.Add(this.Refrescar_btn);
            this.Controls.Add(this.Mover_btn);
            this.Controls.Add(this.Agregar_btn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "Cliente_Form";
            this.Text = "Sucursal";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage0.ResumeLayout(false);
            this.tabPage0.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button Agregar_btn;
        private System.Windows.Forms.Button Mover_btn;
        private System.Windows.Forms.Button Refrescar_btn;
        private System.Windows.Forms.Button Consumir_btn;
        private System.Windows.Forms.TextBox sucursaltextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage0;
        private System.Windows.Forms.Label mensaje_auth;
        private System.Windows.Forms.Button Autenticar_Btn;
        private System.Windows.Forms.TextBox box_pass;
        private System.Windows.Forms.TextBox box_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

