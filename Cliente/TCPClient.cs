using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Negocio;

namespace Cliente
{
    public class TCPClient
    {
        //Log Especial
        public static string Emisor = "[TCPClient] "; //Para efectos de logging dar el nombre a esta clase
        ConsoleLog consolelog = new ConsoleLog(Emisor, "TCPClient.txt");
        public int tID;  //Para efectos de logging, conocer el id del thread.
        //Fin de log especial
        private List<TcpClient> connectedClients = new List<TcpClient>();
        private TcpClient _client;
        private Boolean _isConnected;
        private string ipAddress1;
        private int portNum1;
        public Mensaje msg;
        public Boolean complete = false;

        public TCPClient(String ipAddress, int portNum)
        {
            ipAddress1 = ipAddress;
            portNum1 = portNum;
            _client = new TcpClient();
            _client.Connect(ipAddress, portNum);
            Thread HandleCom = new Thread(HandleCommunication);
            HandleCom.Start();
        }

        public void HandleCommunication()
        {
            connectedClients.Add(_client);
            _isConnected = true;
            
            while (_isConnected)
            {
                try
                {
              
                    NetworkStream strm = _client.GetStream();
                    BinaryFormatter formatter = new BinaryFormatter();
                    msg = (Mensaje)formatter.Deserialize(strm);
                    tID = Thread.CurrentThread.ManagedThreadId;
                    consolelog.Log(" Thread: " + tID + " ---> Deserializado, Mensaje Recibido del Servidor");
                    
                 }
                catch
                {
                    //System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }

            
        }

        //Este metodo hace que el cliente le pregunte al servidor con un mensaje
        public void SendData(Mensaje data)
        {
            if (!_client.Connected)
            {
                _client = new TcpClient();
                _client.Connect(ipAddress1, portNum1);
            }
            BinaryFormatter formatter = new BinaryFormatter(); // the formatter that will serialize my object on my stream
            NetworkStream strm = _client.GetStream(); // the stream
            formatter.Serialize(strm, data); // the serialization process
            consolelog.Log(" Thread: " + tID + " ---> Serializado, Mensaje Enviado al Servidor");

        }

        //Este metodo es para sacar el objeto recibido.
        public Mensaje RecData()
        {
            if (msg == null)
            {
                Thread.Sleep(500);
            }
            Thread.Sleep(10);
            return msg;
        }
    }
}