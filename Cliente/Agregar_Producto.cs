using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cliente;

namespace Cliente
{
    public partial class Agregar_Producto : Form
    {
        public Agregar_Producto(DataTable data)
        {
            InitializeComponent();
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "producto_id";
            comboBox1.DataSource = data;
        }

        private void Aceptar_Btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(textBox1.Text);
            Cliente_Form.Agregar_Producto(textBox1.Text, 1, dateTimePicker1.Value, 1);
            this.Dispose();
            MessageBox.Show("Registro Agregado con Exito");
            

        }

        private void Cancelar_Btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
