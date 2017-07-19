using System;
using System.IO;

namespace Negocio
{
 public class ConsoleLog
    {
        public string _emisor;
        public String Archivo;

        public ConsoleLog(string Emisor, string archivo)
        {
            Archivo = "c:\\log\\" + archivo;
            _emisor = Emisor;
            
        }

        public void Log(string logmessage)
        {

            string mensaje = DateTime.Now.ToLongTimeString() +  _emisor + logmessage;
            Console.WriteLine(mensaje);
            
        }

       
    }
}