using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Esta es la unica clase que se va a serializar.
//El objetivo de esta clase es tomar las clases previamente convertidas a objetos
// De esta manera se mandan dos variables, una con un codigo y el otro un objeto.
// Se utiliza mas que todo para el lado del cliente
// La idea es que si se quiere decirle al servidor que ejecute X funcion entonces
// Se manda el codigo de esta, por ejemplo el 153, el 153 puede significar inserccion
// de categorias, y a continuacion se envia el objeto a insertar
// Del otro lado debe de hacer un decodificador que diga, ok, 153 pertenece a insercion de
// categoria, por lo cual castea el objeto a un tipo NCategoria.

namespace Cliente
{
    [Serializable]
    public class Mensaje
    {
        private int codigo;
        private object obj;


        public Mensaje(int codigo, object obj)
        {
            this.codigo = codigo;
            this.obj = obj;

        }

        //Getters y Setters
        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public object Obj
        {
            get
            {
                return obj;
            }

            set
            {
                obj = value;
            }
        }

    }
}
