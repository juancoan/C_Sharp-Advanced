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
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Threading;

namespace Servidor
{
    
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
            //Se deshabilitan los Tabs
            habilitar_tabs(false);
            Interruptor.BackColor = Color.Red;
            
            tabControl1.SelectedIndexChanged += new EventHandler(Tabs_SelectedIndexChanged);
            
        }

        //Controla la deshabilitacion de los tabs
        //Solo usuarios identificados pueden habilitarlos

            public void habilitar_tabs(Boolean data)
        {
            if (data == false)
            {
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.TabPages.Remove(tabPage5);
                tabControl1.TabPages.Remove(tabPage6);
                tabControl1.TabPages.Remove(tabPage7);

            }
            else
            {
                tabControl1.TabPages.Insert(0, tabPage7);
                tabControl1.TabPages.Insert(0, tabPage6);
                tabControl1.TabPages.Insert(0, tabPage5);
                tabControl1.TabPages.Insert(0, tabPage4);
                tabControl1.TabPages.Insert(0, tabPage3);
                tabControl1.TabPages.Insert(0, tabPage2);

            }
        }

        //Controla como se van a mover los tabs
        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabpage2"])
            {
                listar_inventario();
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabpage3"])
            {
                listar_proveedores();
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabpage4"])
            {
                listar_categorias();
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabpage5"])
            {
                listar_productos();
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["tabpage6"])
            {
                listar_sucursales();
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabpage7"])
            {
                listar_usuarios();
            }


        }


        //Estos metodos son para listar los datagrids
        public void listar_inventario()
        {
            NInventario ninventario = new NInventario();
            DataTable datatable = new DataTable();
            datatable = ninventario.listar_tabla();
            datagrid_inventario.DataSource = datatable;
        }

        public void listar_proveedores()
        {
            NProveedor nproveedor = new NProveedor();
            DataTable datatable = new DataTable();
            datatable = nproveedor.listar_tabla();
            datagrid_proveedores.DataSource = datatable;
        }

        public void listar_categorias()
        {
            NCategoria ncategorias = new NCategoria();
            DataTable datatable = new DataTable();
            datatable = ncategorias.listar_tabla();
            datagrid_categorias.DataSource = datatable;

        }

        public void listar_productos()
        {
            NProductos nproductos = new NProductos();
            DataTable datatable = new DataTable();
            datatable = nproductos.listar_tabla();
            datagrid_productos.DataSource = datatable;

        }

        public void listar_sucursales()
        {
            NSucursal nsucursal = new NSucursal();
            DataTable datatable = new DataTable();
            datatable = nsucursal.listar_tabla();
            datagrid_sucursales.DataSource = datatable;
        }

        public void listar_usuarios()
        {
            NUsuarios nusuarios = new NUsuarios();
            DataTable datatable = new DataTable();
            datatable = nusuarios.listar_tabla();
            datagrid_usuarios.DataSource = datatable;
            datagrid_sucursales.DataSource = datatable;
        }

        //Fin de metodos de datagrids.

        private void button1_Click(object sender, EventArgs e)
        {


            // DCategoria cat = new DCategoria(22, "julian");
            // Console.Write(cat.Insertar(cat));
            //SqlDateTime dt = new SqlDateTime(2010, 10, 19);
            //DInventario inv = new DInventario(3,"ef2263", 1, 1, null, null, 2010 - 10 - 19, 2017 - 05 - 05, 1, false);
            //DInventario inv = new DInventario(7, "exito", 2, 1, SqlDateTime.MaxValue, dateTimePicker1.Value, dt,dt, 1, false);
            //Console.Write(inv.Insertar(inv));
            //Console.Write(inv.Modificar(inv));
            //inv.Id = 9;
            //Console.Write(inv.Eliminar(inv));
            //DInventario inv = new DInventario();
            //DataTable dat1 = new DataTable();
            //dat1 = inv.listar();
            //dataGridView1.DataSource = dat1;

            //DProductos prods = new DProductos(1,1,1,"Jacks",12350);
            //prods.Insertar(prods);
            //Console.Write(prods.Modificar(prods));
            //prods.Id_producto = 3;
            //Console.Write(prods.Eliminar(prods));

            //DataTable dat1 = prods.listar();
            //dataGridView1.DataSource = dat1;

            //DProveedor prov = new DProveedor(1, "Adolfo","8868-7487");
            //Console.Write(prov.Modificar(prov));
            //Console.Write(prov.Insertar(prov));
            //DProveedor prov = new DProveedor();
            //DataTable dat1 = prov.listar();
            //dataGridView1.DataSource = dat1;

            //DSucursal suc = new DSucursal(3, "Guana");
            //Console.Write(suc.Modificar(suc));
            //Console.Write(suc.Eliminar(suc));
            //DataTable dat1 = suc.listar();
            //dataGridView1.DataSource = dat1;
            //Console.Write(suc.Insertar(suc));

            //DUsuarios users = new DUsuarios(4,1,"tomela","2343",false);
            //Console.Write(users.Eliminar(users));
            //DataTable dat1 = new DataTable();
            //dat1 = users.listar();
            //dataGridView1.DataSource = dat1;


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Este codigo contiene la logica simple para logear un Usuario en el sistema
            //Dependiendo del true o el false le indica que es para administracion
            Boolean respuesta = false;
            NUsuarios nusuarios = new NUsuarios();
            respuesta = nusuarios.autenticar_usuario(box_user.Text, box_pass.Text, true);

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
                tabControl1.TabPages.Remove(tabPage1);

            }


        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            Interruptor.BackColor = Color.Green;
            Interruptor.Text = "ON";
            Console.WriteLine("Encendiendo el Server");
            //Listener listen = new Listener(10);
            TCPServer servidor = new TCPServer(15830);
            
        }
    }
}
