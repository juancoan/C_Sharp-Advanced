namespace Servidor
{
    partial class Administrador
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mensaje_auth = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.box_pass = new System.Windows.Forms.TextBox();
            this.box_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Inv_Insertar_Btn = new System.Windows.Forms.Button();
            this.Inv_Agregar_Btn = new System.Windows.Forms.Button();
            this.Inv_Eliminar_Btn = new System.Windows.Forms.Button();
            this.Inv_Modificar_Btn = new System.Windows.Forms.Button();
            this.datagrid_inventario = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Prov_Insertar_Btn = new System.Windows.Forms.Button();
            this.Prov_Agregar_Btn = new System.Windows.Forms.Button();
            this.Prov_Eliminar_Btn = new System.Windows.Forms.Button();
            this.Prov_Modificar_Btn = new System.Windows.Forms.Button();
            this.datagrid_proveedores = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Cat_Insertar_Btn = new System.Windows.Forms.Button();
            this.datagrid_categorias = new System.Windows.Forms.DataGridView();
            this.Cat_Agregar_Btn = new System.Windows.Forms.Button();
            this.Cat_Modificar_Btn = new System.Windows.Forms.Button();
            this.Cat_Eliminar_Btn = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Prod_Insertar_Btn = new System.Windows.Forms.Button();
            this.datagrid_productos = new System.Windows.Forms.DataGridView();
            this.Prod_Agregar_Btn = new System.Windows.Forms.Button();
            this.Prod_Modificar_Btn = new System.Windows.Forms.Button();
            this.Prod_Eliminar_Btn = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.Suc_Insertar_Btn = new System.Windows.Forms.Button();
            this.datagrid_sucursales = new System.Windows.Forms.DataGridView();
            this.Suc_Agregar_Btn = new System.Windows.Forms.Button();
            this.Suc_Modificar_Btn = new System.Windows.Forms.Button();
            this.Suc_Eliminar_Btn = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.User_Insertar_Btn = new System.Windows.Forms.Button();
            this.datagrid_usuarios = new System.Windows.Forms.DataGridView();
            this.User_Agregar_Btn = new System.Windows.Forms.Button();
            this.User_Modificar_Btn = new System.Windows.Forms.Button();
            this.User_Eliminar_Btn = new System.Windows.Forms.Button();
            this.Interruptor = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_inventario)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_proveedores)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_categorias)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_productos)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_sucursales)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(61, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(843, 349);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mensaje_auth);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.box_pass);
            this.tabPage1.Controls.Add(this.box_user);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(835, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inicio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mensaje_auth
            // 
            this.mensaje_auth.AutoSize = true;
            this.mensaje_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensaje_auth.ForeColor = System.Drawing.Color.Red;
            this.mensaje_auth.Location = new System.Drawing.Point(442, 87);
            this.mensaje_auth.Name = "mensaje_auth";
            this.mensaje_auth.Size = new System.Drawing.Size(0, 20);
            this.mensaje_auth.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Autenticar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // box_pass
            // 
            this.box_pass.Location = new System.Drawing.Point(269, 125);
            this.box_pass.Name = "box_pass";
            this.box_pass.Size = new System.Drawing.Size(100, 20);
            this.box_pass.TabIndex = 3;
            // 
            // box_user
            // 
            this.box_user.Location = new System.Drawing.Point(269, 78);
            this.box_user.Name = "box_user";
            this.box_user.Size = new System.Drawing.Size(100, 20);
            this.box_user.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Inv_Insertar_Btn);
            this.tabPage2.Controls.Add(this.Inv_Agregar_Btn);
            this.tabPage2.Controls.Add(this.Inv_Eliminar_Btn);
            this.tabPage2.Controls.Add(this.Inv_Modificar_Btn);
            this.tabPage2.Controls.Add(this.datagrid_inventario);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(835, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inventario Global";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Inv_Insertar_Btn
            // 
            this.Inv_Insertar_Btn.Location = new System.Drawing.Point(455, 271);
            this.Inv_Insertar_Btn.Name = "Inv_Insertar_Btn";
            this.Inv_Insertar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Inv_Insertar_Btn.TabIndex = 4;
            this.Inv_Insertar_Btn.Text = "Insertar";
            this.Inv_Insertar_Btn.UseVisualStyleBackColor = true;
            // 
            // Inv_Agregar_Btn
            // 
            this.Inv_Agregar_Btn.Location = new System.Drawing.Point(347, 271);
            this.Inv_Agregar_Btn.Name = "Inv_Agregar_Btn";
            this.Inv_Agregar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Inv_Agregar_Btn.TabIndex = 3;
            this.Inv_Agregar_Btn.Text = "Agregar";
            this.Inv_Agregar_Btn.UseVisualStyleBackColor = true;
            // 
            // Inv_Eliminar_Btn
            // 
            this.Inv_Eliminar_Btn.Location = new System.Drawing.Point(233, 271);
            this.Inv_Eliminar_Btn.Name = "Inv_Eliminar_Btn";
            this.Inv_Eliminar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Inv_Eliminar_Btn.TabIndex = 2;
            this.Inv_Eliminar_Btn.Text = "Eliminar";
            this.Inv_Eliminar_Btn.UseVisualStyleBackColor = true;
            // 
            // Inv_Modificar_Btn
            // 
            this.Inv_Modificar_Btn.Location = new System.Drawing.Point(116, 271);
            this.Inv_Modificar_Btn.Name = "Inv_Modificar_Btn";
            this.Inv_Modificar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Inv_Modificar_Btn.TabIndex = 1;
            this.Inv_Modificar_Btn.Text = "Modificar";
            this.Inv_Modificar_Btn.UseVisualStyleBackColor = true;
            // 
            // datagrid_inventario
            // 
            this.datagrid_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_inventario.Location = new System.Drawing.Point(6, 6);
            this.datagrid_inventario.MultiSelect = false;
            this.datagrid_inventario.Name = "datagrid_inventario";
            this.datagrid_inventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_inventario.Size = new System.Drawing.Size(823, 228);
            this.datagrid_inventario.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Prov_Insertar_Btn);
            this.tabPage3.Controls.Add(this.Prov_Agregar_Btn);
            this.tabPage3.Controls.Add(this.Prov_Eliminar_Btn);
            this.tabPage3.Controls.Add(this.Prov_Modificar_Btn);
            this.tabPage3.Controls.Add(this.datagrid_proveedores);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(835, 316);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Proveedores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Prov_Insertar_Btn
            // 
            this.Prov_Insertar_Btn.Location = new System.Drawing.Point(522, 275);
            this.Prov_Insertar_Btn.Name = "Prov_Insertar_Btn";
            this.Prov_Insertar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Prov_Insertar_Btn.TabIndex = 8;
            this.Prov_Insertar_Btn.Text = "Insertar";
            this.Prov_Insertar_Btn.UseVisualStyleBackColor = true;
            // 
            // Prov_Agregar_Btn
            // 
            this.Prov_Agregar_Btn.Location = new System.Drawing.Point(414, 275);
            this.Prov_Agregar_Btn.Name = "Prov_Agregar_Btn";
            this.Prov_Agregar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Prov_Agregar_Btn.TabIndex = 7;
            this.Prov_Agregar_Btn.Text = "Agregar";
            this.Prov_Agregar_Btn.UseVisualStyleBackColor = true;
            // 
            // Prov_Eliminar_Btn
            // 
            this.Prov_Eliminar_Btn.Location = new System.Drawing.Point(300, 275);
            this.Prov_Eliminar_Btn.Name = "Prov_Eliminar_Btn";
            this.Prov_Eliminar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Prov_Eliminar_Btn.TabIndex = 6;
            this.Prov_Eliminar_Btn.Text = "Eliminar";
            this.Prov_Eliminar_Btn.UseVisualStyleBackColor = true;
            // 
            // Prov_Modificar_Btn
            // 
            this.Prov_Modificar_Btn.Location = new System.Drawing.Point(183, 275);
            this.Prov_Modificar_Btn.Name = "Prov_Modificar_Btn";
            this.Prov_Modificar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Prov_Modificar_Btn.TabIndex = 5;
            this.Prov_Modificar_Btn.Text = "Modificar";
            this.Prov_Modificar_Btn.UseVisualStyleBackColor = true;
            // 
            // datagrid_proveedores
            // 
            this.datagrid_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_proveedores.Location = new System.Drawing.Point(15, 22);
            this.datagrid_proveedores.MultiSelect = false;
            this.datagrid_proveedores.Name = "datagrid_proveedores";
            this.datagrid_proveedores.ReadOnly = true;
            this.datagrid_proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_proveedores.Size = new System.Drawing.Size(781, 226);
            this.datagrid_proveedores.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Cat_Insertar_Btn);
            this.tabPage4.Controls.Add(this.datagrid_categorias);
            this.tabPage4.Controls.Add(this.Cat_Agregar_Btn);
            this.tabPage4.Controls.Add(this.Cat_Modificar_Btn);
            this.tabPage4.Controls.Add(this.Cat_Eliminar_Btn);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(835, 316);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Categorias";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Cat_Insertar_Btn
            // 
            this.Cat_Insertar_Btn.Location = new System.Drawing.Point(475, 268);
            this.Cat_Insertar_Btn.Name = "Cat_Insertar_Btn";
            this.Cat_Insertar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Cat_Insertar_Btn.TabIndex = 12;
            this.Cat_Insertar_Btn.Text = "Insertar";
            this.Cat_Insertar_Btn.UseVisualStyleBackColor = true;
            // 
            // datagrid_categorias
            // 
            this.datagrid_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_categorias.Location = new System.Drawing.Point(12, 0);
            this.datagrid_categorias.MultiSelect = false;
            this.datagrid_categorias.Name = "datagrid_categorias";
            this.datagrid_categorias.ReadOnly = true;
            this.datagrid_categorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_categorias.Size = new System.Drawing.Size(781, 226);
            this.datagrid_categorias.TabIndex = 3;
            // 
            // Cat_Agregar_Btn
            // 
            this.Cat_Agregar_Btn.Location = new System.Drawing.Point(367, 268);
            this.Cat_Agregar_Btn.Name = "Cat_Agregar_Btn";
            this.Cat_Agregar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Cat_Agregar_Btn.TabIndex = 11;
            this.Cat_Agregar_Btn.Text = "Agregar";
            this.Cat_Agregar_Btn.UseVisualStyleBackColor = true;
            // 
            // Cat_Modificar_Btn
            // 
            this.Cat_Modificar_Btn.Location = new System.Drawing.Point(136, 268);
            this.Cat_Modificar_Btn.Name = "Cat_Modificar_Btn";
            this.Cat_Modificar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Cat_Modificar_Btn.TabIndex = 9;
            this.Cat_Modificar_Btn.Text = "Modificar";
            this.Cat_Modificar_Btn.UseVisualStyleBackColor = true;
            // 
            // Cat_Eliminar_Btn
            // 
            this.Cat_Eliminar_Btn.Location = new System.Drawing.Point(253, 268);
            this.Cat_Eliminar_Btn.Name = "Cat_Eliminar_Btn";
            this.Cat_Eliminar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Cat_Eliminar_Btn.TabIndex = 10;
            this.Cat_Eliminar_Btn.Text = "Eliminar";
            this.Cat_Eliminar_Btn.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.Prod_Insertar_Btn);
            this.tabPage5.Controls.Add(this.datagrid_productos);
            this.tabPage5.Controls.Add(this.Prod_Agregar_Btn);
            this.tabPage5.Controls.Add(this.Prod_Modificar_Btn);
            this.tabPage5.Controls.Add(this.Prod_Eliminar_Btn);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(835, 316);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Productos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Prod_Insertar_Btn
            // 
            this.Prod_Insertar_Btn.Location = new System.Drawing.Point(514, 271);
            this.Prod_Insertar_Btn.Name = "Prod_Insertar_Btn";
            this.Prod_Insertar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Prod_Insertar_Btn.TabIndex = 12;
            this.Prod_Insertar_Btn.Text = "Insertar";
            this.Prod_Insertar_Btn.UseVisualStyleBackColor = true;
            // 
            // datagrid_productos
            // 
            this.datagrid_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_productos.Location = new System.Drawing.Point(12, 3);
            this.datagrid_productos.MultiSelect = false;
            this.datagrid_productos.Name = "datagrid_productos";
            this.datagrid_productos.ReadOnly = true;
            this.datagrid_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_productos.Size = new System.Drawing.Size(781, 226);
            this.datagrid_productos.TabIndex = 3;
            // 
            // Prod_Agregar_Btn
            // 
            this.Prod_Agregar_Btn.Location = new System.Drawing.Point(406, 271);
            this.Prod_Agregar_Btn.Name = "Prod_Agregar_Btn";
            this.Prod_Agregar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Prod_Agregar_Btn.TabIndex = 11;
            this.Prod_Agregar_Btn.Text = "Agregar";
            this.Prod_Agregar_Btn.UseVisualStyleBackColor = true;
            // 
            // Prod_Modificar_Btn
            // 
            this.Prod_Modificar_Btn.Location = new System.Drawing.Point(175, 271);
            this.Prod_Modificar_Btn.Name = "Prod_Modificar_Btn";
            this.Prod_Modificar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Prod_Modificar_Btn.TabIndex = 9;
            this.Prod_Modificar_Btn.Text = "Modificar";
            this.Prod_Modificar_Btn.UseVisualStyleBackColor = true;
            // 
            // Prod_Eliminar_Btn
            // 
            this.Prod_Eliminar_Btn.Location = new System.Drawing.Point(292, 271);
            this.Prod_Eliminar_Btn.Name = "Prod_Eliminar_Btn";
            this.Prod_Eliminar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Prod_Eliminar_Btn.TabIndex = 10;
            this.Prod_Eliminar_Btn.Text = "Eliminar";
            this.Prod_Eliminar_Btn.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.Suc_Insertar_Btn);
            this.tabPage6.Controls.Add(this.datagrid_sucursales);
            this.tabPage6.Controls.Add(this.Suc_Agregar_Btn);
            this.tabPage6.Controls.Add(this.Suc_Modificar_Btn);
            this.tabPage6.Controls.Add(this.Suc_Eliminar_Btn);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(835, 316);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Sucursales";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // Suc_Insertar_Btn
            // 
            this.Suc_Insertar_Btn.Location = new System.Drawing.Point(525, 268);
            this.Suc_Insertar_Btn.Name = "Suc_Insertar_Btn";
            this.Suc_Insertar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Suc_Insertar_Btn.TabIndex = 12;
            this.Suc_Insertar_Btn.Text = "Insertar";
            this.Suc_Insertar_Btn.UseVisualStyleBackColor = true;
            // 
            // datagrid_sucursales
            // 
            this.datagrid_sucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_sucursales.Location = new System.Drawing.Point(14, 3);
            this.datagrid_sucursales.MultiSelect = false;
            this.datagrid_sucursales.Name = "datagrid_sucursales";
            this.datagrid_sucursales.ReadOnly = true;
            this.datagrid_sucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_sucursales.Size = new System.Drawing.Size(781, 226);
            this.datagrid_sucursales.TabIndex = 3;
            // 
            // Suc_Agregar_Btn
            // 
            this.Suc_Agregar_Btn.Location = new System.Drawing.Point(417, 268);
            this.Suc_Agregar_Btn.Name = "Suc_Agregar_Btn";
            this.Suc_Agregar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Suc_Agregar_Btn.TabIndex = 11;
            this.Suc_Agregar_Btn.Text = "Agregar";
            this.Suc_Agregar_Btn.UseVisualStyleBackColor = true;
            // 
            // Suc_Modificar_Btn
            // 
            this.Suc_Modificar_Btn.Location = new System.Drawing.Point(186, 268);
            this.Suc_Modificar_Btn.Name = "Suc_Modificar_Btn";
            this.Suc_Modificar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Suc_Modificar_Btn.TabIndex = 9;
            this.Suc_Modificar_Btn.Text = "Modificar";
            this.Suc_Modificar_Btn.UseVisualStyleBackColor = true;
            // 
            // Suc_Eliminar_Btn
            // 
            this.Suc_Eliminar_Btn.Location = new System.Drawing.Point(303, 268);
            this.Suc_Eliminar_Btn.Name = "Suc_Eliminar_Btn";
            this.Suc_Eliminar_Btn.Size = new System.Drawing.Size(75, 23);
            this.Suc_Eliminar_Btn.TabIndex = 10;
            this.Suc_Eliminar_Btn.Text = "Eliminar";
            this.Suc_Eliminar_Btn.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.User_Insertar_Btn);
            this.tabPage7.Controls.Add(this.datagrid_usuarios);
            this.tabPage7.Controls.Add(this.User_Agregar_Btn);
            this.tabPage7.Controls.Add(this.User_Modificar_Btn);
            this.tabPage7.Controls.Add(this.User_Eliminar_Btn);
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(835, 316);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Usuarios";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // User_Insertar_Btn
            // 
            this.User_Insertar_Btn.Location = new System.Drawing.Point(531, 264);
            this.User_Insertar_Btn.Name = "User_Insertar_Btn";
            this.User_Insertar_Btn.Size = new System.Drawing.Size(75, 23);
            this.User_Insertar_Btn.TabIndex = 12;
            this.User_Insertar_Btn.Text = "Insertar";
            this.User_Insertar_Btn.UseVisualStyleBackColor = true;
            // 
            // datagrid_usuarios
            // 
            this.datagrid_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_usuarios.Location = new System.Drawing.Point(13, 3);
            this.datagrid_usuarios.MultiSelect = false;
            this.datagrid_usuarios.Name = "datagrid_usuarios";
            this.datagrid_usuarios.ReadOnly = true;
            this.datagrid_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_usuarios.Size = new System.Drawing.Size(781, 226);
            this.datagrid_usuarios.TabIndex = 3;
            // 
            // User_Agregar_Btn
            // 
            this.User_Agregar_Btn.Location = new System.Drawing.Point(423, 264);
            this.User_Agregar_Btn.Name = "User_Agregar_Btn";
            this.User_Agregar_Btn.Size = new System.Drawing.Size(75, 23);
            this.User_Agregar_Btn.TabIndex = 11;
            this.User_Agregar_Btn.Text = "Agregar";
            this.User_Agregar_Btn.UseVisualStyleBackColor = true;
            // 
            // User_Modificar_Btn
            // 
            this.User_Modificar_Btn.Location = new System.Drawing.Point(192, 264);
            this.User_Modificar_Btn.Name = "User_Modificar_Btn";
            this.User_Modificar_Btn.Size = new System.Drawing.Size(75, 23);
            this.User_Modificar_Btn.TabIndex = 9;
            this.User_Modificar_Btn.Text = "Modificar";
            this.User_Modificar_Btn.UseVisualStyleBackColor = true;
            // 
            // User_Eliminar_Btn
            // 
            this.User_Eliminar_Btn.Location = new System.Drawing.Point(309, 264);
            this.User_Eliminar_Btn.Name = "User_Eliminar_Btn";
            this.User_Eliminar_Btn.Size = new System.Drawing.Size(75, 23);
            this.User_Eliminar_Btn.TabIndex = 10;
            this.User_Eliminar_Btn.Text = "Eliminar";
            this.User_Eliminar_Btn.UseVisualStyleBackColor = true;
            // 
            // Interruptor
            // 
            this.Interruptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interruptor.Location = new System.Drawing.Point(792, 38);
            this.Interruptor.Name = "Interruptor";
            this.Interruptor.Size = new System.Drawing.Size(105, 42);
            this.Interruptor.TabIndex = 3;
            this.Interruptor.Text = "OFF";
            this.Interruptor.UseVisualStyleBackColor = true;
            this.Interruptor.Click += new System.EventHandler(this.button26_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 482);
            this.Controls.Add(this.Interruptor);
            this.Controls.Add(this.tabControl1);
            this.Name = "Administrador";
            this.Text = "Panel de Administracion";
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_inventario)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_proveedores)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_categorias)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_productos)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_sucursales)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView datagrid_inventario;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_pass;
        private System.Windows.Forms.TextBox box_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label mensaje_auth;
        private System.Windows.Forms.Button Inv_Insertar_Btn;
        private System.Windows.Forms.Button Inv_Agregar_Btn;
        private System.Windows.Forms.Button Inv_Eliminar_Btn;
        private System.Windows.Forms.Button Inv_Modificar_Btn;
        private System.Windows.Forms.Button Prov_Insertar_Btn;
        private System.Windows.Forms.Button Prov_Agregar_Btn;
        private System.Windows.Forms.Button Prov_Eliminar_Btn;
        private System.Windows.Forms.Button Prov_Modificar_Btn;
        private System.Windows.Forms.DataGridView datagrid_proveedores;
        private System.Windows.Forms.Button Cat_Insertar_Btn;
        private System.Windows.Forms.DataGridView datagrid_categorias;
        private System.Windows.Forms.Button Cat_Agregar_Btn;
        private System.Windows.Forms.Button Cat_Modificar_Btn;
        private System.Windows.Forms.Button Cat_Eliminar_Btn;
        private System.Windows.Forms.Button Prod_Insertar_Btn;
        private System.Windows.Forms.DataGridView datagrid_productos;
        private System.Windows.Forms.Button Prod_Agregar_Btn;
        private System.Windows.Forms.Button Prod_Modificar_Btn;
        private System.Windows.Forms.Button Prod_Eliminar_Btn;
        private System.Windows.Forms.Button Suc_Insertar_Btn;
        private System.Windows.Forms.DataGridView datagrid_sucursales;
        private System.Windows.Forms.Button Suc_Agregar_Btn;
        private System.Windows.Forms.Button Suc_Modificar_Btn;
        private System.Windows.Forms.Button Suc_Eliminar_Btn;
        private System.Windows.Forms.Button User_Insertar_Btn;
        private System.Windows.Forms.DataGridView datagrid_usuarios;
        private System.Windows.Forms.Button User_Agregar_Btn;
        private System.Windows.Forms.Button User_Modificar_Btn;
        private System.Windows.Forms.Button User_Eliminar_Btn;
        private System.Windows.Forms.Button Interruptor;
    }
}

