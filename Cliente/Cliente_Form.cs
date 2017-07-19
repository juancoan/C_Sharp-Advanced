using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using System.Threading;
using System.Data.SqlTypes;

namespace Cliente
{
 
    public partial class Cliente_Form : Form
    {

        //public TCPClient cliente;
        public static TCPClient cliente;
        public int num_sucursal; //Esta variable maneja el numero de sucursal que esta logeada
        public int codigo_usuario = 2; //Este hay que cambiarlo por la sesion
        
        

        public Cliente_Form()
        {
            InitializeComponent();
            //Este evento sirve para saber en que pestaña se encuentra el usuario.
            //Dependiendo de ello asi deshabilita botones
            tabControl1.SelectedIndexChanged += new EventHandler(Tabs_SelectedIndexChanged);
            //Deshabilitando tabs
            habilitar_tabs(false);
            habilitar_botones(false);
            button1.Visible = false;
           //Metodo para conectar al servidor
            
            cliente = new TCPClient("127.0.0.1", 15830);

            
        }

        //El siguiente metodo controla que los tabs esten deshabilitados
        //Si el usuario autentica entonces puede usuarlos.

        public void habilitar_tabs(Boolean data)
        {
            if (data == false)
            {
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage3);
         
            }
            else
            {
          
                tabControl1.TabPages.Insert(0, tabPage3);
                tabControl1.TabPages.Insert(0, tabPage2);
                tabControl1.TabPages.Insert(0, tabPage1);
                tabControl1.TabPages.Remove(tabPage0);

            }
        }

        //Deshabilita los botones

        public void habilitar_botones(Boolean data)
        {
            if(data == false)
            {
                Agregar_btn.Visible = false;
                Consumir_btn.Visible = false;
                Mover_btn.Visible = false;
                Refrescar_btn.Visible = false;
                sucursaltextbox.Visible = false;
                label1.Visible = false;
            }else
            {
                Agregar_btn.Visible = true;
                Consumir_btn.Visible = true;
                Mover_btn.Visible = true;
                Refrescar_btn.Visible = true;
                sucursaltextbox.Visible = true;
                label1.Visible = true;
            }
            
        }

        //Este procedimiento controla el comportamiento de los tabs
        //Se va a utilizar para validar cuales botones deben de estar disponibles.
        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabpage1"])
            {
                deshabilitar_botones();
                Agregar_btn.Enabled = true;
                Mover_btn.Enabled = true;
                Refrescar();

            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabpage2"])
            {
                deshabilitar_botones();
                Consumir_btn.Enabled = true;
                Refrescar();

            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabpage3"])
            {
                deshabilitar_botones();
                Refrescar();
                
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Aqui se conecta al servidor.
            num_sucursal = Int32.Parse(sucursaltextbox.Text);
            button1.Visible = false;
            sucursaltextbox.Enabled = false;
            label1.Text = "Sucursal #";
            catalogo_global();
            Mover_btn.Enabled = true;
            catalogo_local();
            inventario_agotado();
            tabControl1.Enabled = true;
            habilitar_botones(true);
            
        }
        
        //A partir de aqui vienen procedimientos que pueden ser llamados
        // A lo largo del formulario.

        public DataTable listar_productos()
        {
            NProductos nproductos = new NProductos();
            Mensaje msg = new Mensaje(103, nproductos);
            cliente.SendData(msg);
            DataTable productos = new DataTable();
            Thread.Sleep(200);
            msg = cliente.RecData();
            productos = (DataTable)msg.Obj;
            return productos;
        }
        
        //Catalogo Global
        public void catalogo_global()
        {
            
            NInventario ninventario = new NInventario();
            Mensaje msg = new Mensaje(100, ninventario);            
            cliente.SendData(msg);
            msg = cliente.RecData();
            dataGridView1.DataSource = msg.Obj;
            dataGridView1.Refresh();
        }

        //Catalogo local
        public void catalogo_local()
        {
          
            NInventario ninventario = new NInventario();
            ninventario.Cod_sucursal = num_sucursal;
            Mensaje msg = new Mensaje(101, ninventario);
            cliente.SendData(msg);
            msg = cliente.RecData();
            dataGridView2.DataSource = msg.Obj;
            dataGridView2.Refresh();
            
        }

        //Lista inteligente de compras
        public void inventario_agotado()
        {
            NInventario ninventario = new NInventario();
            ninventario.Cod_sucursal = num_sucursal;
            Mensaje msg = new Mensaje(102, ninventario);
            cliente.SendData(msg);
            msg = cliente.RecData();
            dataGridView3.DataSource = msg.Obj;
            dataGridView3.Refresh();
        }

        public void deshabilitar_botones()
        {
            Agregar_btn.Enabled = false;
            Mover_btn.Enabled = false;
            Consumir_btn.Enabled = false;
        }

        private void Refrescar_btn_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        public void Refrescar()
        {
            //Para refrescar con datos pendientess
            Thread.Sleep(100);
            catalogo_global();
            catalogo_local();
            inventario_agotado();
        }
        private void Mover_btn_Click(object sender, EventArgs e)
        {
            //Mover al inventario local
            //Primero se toma el id, del datagrid para usar esa informacion en el metodo
            int id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            NInventario ninventario = new NInventario();
            ninventario.Id = id;
            ninventario.Cod_sucursal = num_sucursal;
            ninventario.Cod_user = codigo_usuario;
            Mensaje msg = new Mensaje(105, ninventario);
            cliente.SendData(msg);
            Refrescar();
            MessageBox.Show("El Producto se movió al Inventario Local");
            Refrescar();

        }

        private void Agregar_btn_Click(object sender, EventArgs e)
        {
            //Agregar producto al catalogo global
            //Se va a iniciar un form que tiene un constructor para recibir
            //De una vez la lista de productos, de esta forma evitamos
            //Que este dialogo tenga que instanciar objetos o utilizar conexiones.
            //Agregar_Producto agregar_producto = new Agregar_Producto(listar_productos());
            
            Agregar_Producto agregar_producto = new Agregar_Producto(listar_productos());
            agregar_producto.Show();
            Refrescar();

        }

        public static void Agregar_Producto(string serie, int id_producto, SqlDateTime fecha_vencimiento, int cod_user)
        {
            NInventario ninventario = new NInventario();
            ninventario.Serie = serie;
            ninventario.Id_producto = id_producto;
            ninventario.Fecha_vencimiento = fecha_vencimiento;
            ninventario.Cod_user = cod_user;
            Mensaje msg = new Mensaje(104, ninventario);
            cliente.SendData(msg);

        }

        public void autenticar_usuario()
        {
            //Metodo de autenticacion de usuario
            Boolean respuesta = false;
            NUsuarios nusuarios = new NUsuarios();
            nusuarios.Username = box_user.Text;
            nusuarios.Password = box_pass.Text;
            nusuarios.Admin = false;
            Mensaje msg = new Mensaje(107, nusuarios);
            cliente.SendData(msg);
            msg = cliente.RecData();
            respuesta = (Boolean)msg.Obj;


            if (respuesta == false)
            {
                mensaje_auth.Text = "Autenticacion Fallida";
                Thread.Sleep(2000);
                mensaje_auth.Text = "Por Favor Intente de Nuevo";

            }
            else
            {
                mensaje_auth.Text = "Atenticacion Exitosa";
                habilitar_tabs(true);
                habilitar_botones(false);
                sucursaltextbox.Visible = true;
                label1.Visible = true;
                tabControl1.Enabled = false;
                button1.Visible = true;

            }
        }
        

        private void Consumir_btn_Click(object sender, EventArgs e)
        {
            //Mover al inventario local
            //Primero se toma el id, del datagrid para usar esa informacion en el metodo
            int id = Int32.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            NInventario ninventario = new NInventario();
            ninventario.Id = id;
            ninventario.Cod_sucursal = num_sucursal;
            ninventario.Cod_user = codigo_usuario;
            Mensaje msg = new Mensaje(106, ninventario);
            cliente.SendData(msg);
            Refrescar();
            MessageBox.Show("El Producto se Consumió");
            Refrescar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            autenticar_usuario();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
