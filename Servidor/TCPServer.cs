using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Negocio;
using Cliente;

//Tomado de http://stackoverflow.com/questions/23592264/tcp-multiple-clients-one-server-sending-serialized-objects
//Y modificado para trabajar con esta aplicacion.

namespace Servidor
{
    public class TCPServer
    {
        //Log Especial
        public static string Emisor = "[TCPServer] "; //Para efectos de logging dar el nombre a esta clase
        ConsoleLog consolelog = new ConsoleLog(Emisor, "TcpServer.log");
        public int tID;  //Para efectos de logging, conocer el id del thread.

        private TcpListener _server;
        private Boolean _isRunning;
        public NetworkStream strm;
        public BinaryFormatter ReaderForm;
        public BinaryFormatter WriterForm;
        StreamWriter sWriter;
        StreamReader sReader;


        private List<TcpClient> connectedClients = new List<TcpClient>();

        public TCPServer(int port)
        {
            _server = new TcpListener(IPAddress.Any, port);
            _server.Start();
            
            consolelog.Log("Servidor Corriendo en " + port);
            _isRunning = true;
            LoopClients();
        }

        public async void LoopClients()
        {
            while (_isRunning)
            {

                // wait for client connection
                //Add the client to the connected clients list
                
                consolelog.Log("Thread: " + tID + " Esperando Conexion");
                TcpClient newClient = await _server.AcceptTcpClientAsync();
                connectedClients.Add(newClient);
                string ipAddr = newClient.Client.RemoteEndPoint.ToString();
                consolelog.Log("Thread: " + tID + " Conexion de: " + ipAddr);
                  


                // client found.
                // create a thread to handle communication
                Thread t = new Thread(new ParameterizedThreadStart(HandleClient));
                    t.Start(newClient);
                
            }
        }

        public void HandleClient(object obj)
        {
            // retrieve client from parameter passed to thread
            TcpClient client = (TcpClient)obj;
            int managedThreadId = Thread.CurrentThread.ManagedThreadId;
            consolelog.Log("Thread Trabajando : " + managedThreadId);
            // sets two streams
            sWriter = new StreamWriter(client.GetStream(), Encoding.ASCII);
            sReader = new StreamReader(client.GetStream(), Encoding.ASCII);
            // you could use the NetworkStream to read and write, 
            // but there is no forcing flush, even when requested
            
            Boolean bClientConnected = true;
            while (bClientConnected)
            {
                //Recepcion y Emision
                try
                {
                    
                    if (!client.Connected)
                        return;
                    
                    strm = client.GetStream();
                    ReaderForm = new BinaryFormatter();
                    Mensaje msg = (Mensaje)ReaderForm.Deserialize(strm);
                    enviarRespuesta(msg);
                    
                  
                }
                catch (Exception ex)
                {
                    consolelog.Log("Thread: " + tID + " [ERROR]: " + ex);
                }
            }

        }

        public void enviarRespuesta(Mensaje msg)
        {
            if (msg.Codigo == 100)
            {
                
                //Codigo 100, Inventario no Asignado
                NInventario ninventario = new NInventario();
                msg = new Mensaje(100, ninventario.inventario_noasignado());
                WriterForm = new BinaryFormatter();
                WriterForm.Serialize(strm, msg);
                consolelog.Log("Thread" + tID + " [ENVIADO]: Codigo 100:  ++ Inventario no Asignado ++");
            }

            if (msg.Codigo == 101)
            {
                //Codigo 101, Catalogo Local
                NInventario ninventario = (NInventario)msg.Obj;
                msg = new Mensaje(101, ninventario.inventario_disponible(ninventario.Cod_sucursal));
                BinaryFormatter Responseform = new BinaryFormatter();
                Responseform.Serialize(strm, msg);
                consolelog.Log("Thread" + tID + " [ENVIADO]: Codigo 101:  ++ Inventario Disponible ++");
                
                
            }

            if (msg.Codigo == 102)
            {
                //Codigo 101, Lista inteligente de compras
                NInventario ninventario = (NInventario)msg.Obj;
                msg = new Mensaje(102, ninventario.inventario_agotado(ninventario.Cod_sucursal));
                BinaryFormatter Responseform = new BinaryFormatter();
                Responseform.Serialize(strm, msg);
                consolelog.Log("Thread" + tID + " [ENVIADO]: Codigo 102:  ++ Inventario Agotado ++");
            }

            if (msg.Codigo == 103)
            {
                //Codigo 103, retorna los productos, sirve para llenar el combobox
                NProductos nproductos = (NProductos)msg.Obj;
                msg = new Mensaje(103, nproductos.listar_tabla());
                BinaryFormatter Responseform = new BinaryFormatter();
                Responseform.Serialize(strm, msg);
                consolelog.Log("Thread" + tID + " [ENVIADO]: Codigo 103:  ++ Listar Productos ++");
            }

            if (msg.Codigo == 104)
            {
                //Introduce un producto nuevo al catalogo global
                NInventario ninventario = (NInventario)msg.Obj;
                msg = new Mensaje(104, ninventario.agregar_catalogo_global(ninventario.Serie, ninventario.Id_producto, ninventario.Fecha_vencimiento, ninventario.Cod_user));
                BinaryFormatter Responseform = new BinaryFormatter();
                Responseform.Serialize(strm, msg);
                consolelog.Log("Thread" + tID + " [ENVIADO]: Codigo 104:  ++ Producto Agregado a Catalogo Global ++");
            }

            if (msg.Codigo == 105)
            {
                //Introduce un producto nuevo al catalogo global
                NInventario ninventario = (NInventario)msg.Obj;
                msg = new Mensaje(105, ninventario.mover_inventario_asucursal(ninventario.Id, ninventario.Cod_sucursal, ninventario.Cod_user));
                BinaryFormatter Responseform = new BinaryFormatter();
                Responseform.Serialize(strm, msg);
                consolelog.Log("Thread" + tID + " [ENVIADO]: Codigo 101:  ++ Producto Movido a Catalogo Local ++");
            }

            if (msg.Codigo == 106)
            {
                //Introduce un producto nuevo al catalogo global
                NInventario ninventario = (NInventario)msg.Obj;
                msg = new Mensaje(106, ninventario.consumir_inventario(ninventario.Id, ninventario.Cod_user));
                BinaryFormatter Responseform = new BinaryFormatter();
                Responseform.Serialize(strm, msg);
                consolelog.Log("Thread" + tID + " [ENVIADO]: Codigo 106:  ++ Producto Consumido de Catalogo Local ++");
            }

            if (msg.Codigo == 107)
            {
                //Valida al usuario
                NUsuarios nusuarios = (NUsuarios)msg.Obj;
                msg = new Mensaje(107, nusuarios.autenticar_usuario(nusuarios.Username, nusuarios.Password, false));
                BinaryFormatter Responseform = new BinaryFormatter();
                Responseform.Serialize(strm, msg);
                consolelog.Log("Thread" + tID + " [ENVIADO]: Codigo 107:  ++ Autenticacion de Usuario ++");
            }

        }
    }
}
    

