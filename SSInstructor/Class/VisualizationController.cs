using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SSInstructor.Class
{
    public static class VisualizationController
    {
        #region "Fields"
        static TcpListener listener;
        static Thread listenThread;
        #endregion

        #region "Properties"
        #endregion

        #region "Method"
        public static void StartServer()
        {
            listener = new TcpListener(IPAddress.Loopback, 3678);
            listenThread = new Thread(new ThreadStart(ListenForClients));
            listenThread.Start();
        }

        private static void ListenForClients()
        {
            listener.Start();

            while(true)
            {
                // block until a client has connected
                TcpClient client = listener.AcceptTcpClient();

                //create a thread to handle communication with connected client
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }
        }

        private static void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream ns = tcpClient.GetStream();


        }
        #endregion
    }
}
