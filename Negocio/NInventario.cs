﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlTypes;
using Datos;

//Esta Clase maneja toda la logica del negocio para el inventario.

namespace Negocio
{
    [Serializable]
    public class NInventario

    {
        private int id;
        private string serie;
        private int id_producto;
        private int cod_sucursal;
        private SqlDateTime fecha_entrada_sucursal;
        private SqlDateTime fecha_consumo;
        private SqlDateTime fecha_entrada_cat_global;
        private SqlDateTime fecha_vencimiento;
        private int cod_user;
        private Boolean disponibilidad;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Serie
        {
            get
            {
                return serie;
            }

            set
            {
                serie = value;
            }
        }

        public int Id_producto
        {
            get
            {
                return id_producto;
            }

            set
            {
                id_producto = value;
            }
        }

        public int Cod_sucursal
        {
            get
            {
                return cod_sucursal;
            }

            set
            {
                cod_sucursal = value;
            }
        }

        public SqlDateTime Fecha_entrada_sucursal
        {
            get
            {
                return fecha_entrada_sucursal;
            }

            set
            {
                fecha_entrada_sucursal = value;
            }
        }

        public SqlDateTime Fecha_consumo
        {
            get
            {
                return fecha_consumo;
            }

            set
            {
                fecha_consumo = value;
            }
        }

        public SqlDateTime Fecha_entrada_cat_global
        {
            get
            {
                return fecha_entrada_cat_global;
            }

            set
            {
                fecha_entrada_cat_global = value;
            }
        }

        public SqlDateTime Fecha_vencimiento
        {
            get
            {
                return fecha_vencimiento;
            }

            set
            {
                fecha_vencimiento = value;
            }
        }

        public int Cod_user
        {
            get
            {
                return cod_user;
            }

            set
            {
                cod_user = value;
            }
        }

        public bool Disponibilidad
        {
            get
            {
                return disponibilidad;
            }

            set
            {
                disponibilidad = value;
            }
        }



        //Constructor Vacio
        public NInventario()
        {

        }

        public NInventario(int id, string serie, int id_producto, int cod_sucursal, SqlDateTime fecha_entrada_sucursal, SqlDateTime fecha_consumo, SqlDateTime fecha_entrada_cat_global, SqlDateTime fecha_vencimiento, int cod_user, bool disponibilidad)
        {
            this.id = id;
            this.serie = serie;
            this.id_producto = id_producto;
            this.cod_sucursal = cod_sucursal;
            this.fecha_entrada_sucursal = fecha_entrada_sucursal;
            this.fecha_consumo = fecha_consumo;
            this.fecha_entrada_cat_global = fecha_entrada_cat_global;
            this.fecha_vencimiento = fecha_vencimiento;
            this.cod_user = cod_user;
            this.disponibilidad = disponibilidad;
        }



        //Este metodo lista la tabla de la base de datos

        public DataTable listar_tabla()
        {
            DataTable datatable = new DataTable();
            DInventario dinventario = new DInventario();
            datatable = dinventario.listar();
            return datatable;

        }

        //Este metodo es para hacer modificaciones dentro de la parte administrativa
        //Ya que es muy sensible a cambios bruscos
        public string modificar(int id, string serie, int id_producto, int cod_sucursal, SqlDateTime fecha_entrada_sucursal, SqlDateTime fecha_consumo, SqlDateTime fecha_entrada_cat_global, SqlDateTime fecha_vencimiento, int cod_user, Boolean disponibilidad)
        {
            string respuesta = "";
            DInventario dinventario = new DInventario(id, serie, id_producto, cod_sucursal, fecha_entrada_sucursal, fecha_consumo, fecha_entrada_cat_global, fecha_vencimiento, cod_user, disponibilidad);
            respuesta = dinventario.Modificar(dinventario);
            return respuesta;
        }

        //Este metodo es para eliminar registros dentro de la parte administrativa
        //Ya que es muy sensible a cambios bruscos
        public string eliminar(int id, string serie, int id_producto, int cod_sucursal, SqlDateTime fecha_entrada_sucursal, SqlDateTime fecha_consumo, SqlDateTime fecha_entrada_cat_global, SqlDateTime fecha_vencimiento, int cod_user, Boolean disponibilidad)
        {
            string respuesta = "";
            DInventario dinventario = new DInventario(id, serie, id_producto, cod_sucursal, fecha_entrada_sucursal, fecha_consumo, fecha_entrada_cat_global, fecha_vencimiento, cod_user, disponibilidad);
            respuesta = dinventario.Eliminar(dinventario);
            return respuesta;
        }

        
        //Cuando se agrega un inventario por primera vez, este va a ser un producto
        // que va a ingresar al catalogo global, la forma para filtrar que pertenezca al
        //catalogo global va ser usando la sucursal 1.
        //Aunque en el metodo principal de la capa de datos se requieren otros campos, he aqui donde
        //se aplica la logica para diferenciar cuando un producto es nuevo, posteriormente otros metodos
        //moveran el producto a la sucursal, la fecha que se cambia, y cuando deja de ser disponible
        //El parametro SqlDateTime.MinValue, será Utilizado como equivalente a null.


        public string agregar_catalogo_global(string serie, int id_producto, SqlDateTime fecha_vencimiento, int cod_user)
        {
            string respuesta = "";

            DInventario dinventario = new DInventario(1, serie, id_producto, 1, SqlDateTime.MinValue, SqlDateTime.MinValue, DateTime.Now, fecha_vencimiento, cod_user, true);
            respuesta = dinventario.Insertar(dinventario);
            return respuesta;
        }

        //Este metodo mueve del inventario global al local, se agrega la fecha y se cambia
        // el codigo de la sucursal

        public string mover_inventario_asucursal(int id, int cod_sucursal, int cod_user)
        {
            string respuesta = "";
            DInventario dinventario = new DInventario();
            respuesta = dinventario.mover_inventario_asucursal(id, cod_sucursal, DateTime.Now, cod_user);
            return respuesta;
            
        }

        //Este metodo consume el inventario

        public string consumir_inventario(int id, int cod_user)
        {
            string respuesta ="";
            DInventario dinventario = new DInventario();
            respuesta = dinventario.consumir_inventario(id, DateTime.Now, cod_user);
            return respuesta;
        }


        //Lista el inventario que no tiene sucursal
        public DataTable inventario_noasignado()
        {
            DataTable datatable = new DataTable();
            DInventario dinventario = new DInventario();
            datatable = dinventario.inventario_noasignado();
            return datatable;

        }

        //Productos que han sido consumidos x todas las sucursales
        public DataTable inventario_consumido_global()
        {
            DataTable datatable = new DataTable();
            DInventario dinventario = new DInventario();
            datatable = dinventario.inventario_consumido_global();
            return datatable;
        }

        //Inventario Disponible x Sucursal
        public DataTable inventario_disponible(int cod_sucursal)
        {
            DataTable datatable = new DataTable();
            DInventario dinventario = new DInventario();
            datatable = dinventario.estado_inventario_local(cod_sucursal, 1);
            return datatable;
        }

        //Inventario Agotado x Sucursal
        public DataTable inventario_agotado(int cod_sucursal)
        {
            DataTable datatable = new DataTable();
            DInventario dinventario = new DInventario();
            datatable = dinventario.estado_inventario_local(cod_sucursal, 0);
            return datatable;
        }




    }
}
