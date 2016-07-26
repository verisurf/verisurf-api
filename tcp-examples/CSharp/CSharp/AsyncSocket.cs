using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Verisurf
{
    public class StateObject
    {
        public Socket WorkSocket = null;
        public const int BufferSize = 32767;
        public byte[] Buffer = new byte[BufferSize];
        public StringBuilder StrBuilder;
    }

    public delegate void socketConnected(string SocketID);
    public delegate void socketDisconnected(string SocketID);
    public delegate void socketDataArrival(string SocketID, string SocketData);
    public delegate void socketFailed(string SocketID);

    public class AsyncSocket
    {
        private Socket m_tmpSocket;
        private string m_SocketID;

        public event socketConnected m_connected;
        public event socketDisconnected m_disconnected;
        public event socketDataArrival m_dataarrival;
        public event socketFailed m_failed;

        public AsyncSocket(Socket tmp_Socket, string tmp_SocketID)
        {
            m_SocketID = tmp_SocketID;
            m_tmpSocket = tmp_Socket;

            Socket obj_Socket = tmp_Socket;
            StateObject obj_SocketState = new StateObject();

            obj_SocketState.WorkSocket = obj_Socket;
            obj_Socket.BeginReceive(obj_SocketState.Buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(onDataArrival), obj_SocketState);
        }

        public AsyncSocket()
        {
            m_tmpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Send(string tmp_Data)
        {
            try
            {
                StateObject obj_StateObject = new StateObject();
                obj_StateObject.WorkSocket = m_tmpSocket;

                byte[] Buffer = Encoding.ASCII.GetBytes(tmp_Data);
                m_tmpSocket.BeginSend(Buffer, 0, Buffer.Length, 0, new AsyncCallback(onSendComplete), obj_StateObject);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void Close()
        {
            m_tmpSocket.Shutdown(SocketShutdown.Both);
            m_tmpSocket.Close();
        }

        public void Connect(String hostIP, int hostPort)
        {
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(hostIP), hostPort);
            Socket obj_Socket = m_tmpSocket;
            try 
            {
                obj_Socket.BeginConnect(remoteEP, new AsyncCallback(onConnectionComplete), obj_Socket);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public bool Connected()
        {
            return m_tmpSocket.Connected;
        }

        private void onDataArrival(IAsyncResult ar)
        {
            try
            {
                StateObject obj_SocketState = (StateObject)ar.AsyncState;
                Socket obj_Socket = obj_SocketState.WorkSocket;
                string sck_Data;
                int BytesRead = obj_Socket.EndReceive(ar);

                if(BytesRead > 0)
                {
                    sck_Data = Encoding.ASCII.GetString(obj_SocketState.Buffer, 0, BytesRead);
                    var handler = this.m_dataarrival;
                    if (handler != null)
                        handler(m_SocketID, sck_Data);
                }
                obj_Socket.BeginReceive(obj_SocketState.Buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(onDataArrival), obj_SocketState);
            }
            catch (Exception ex)
            {
                var handler = this.m_disconnected;
                if (handler != null)
                    handler(m_SocketID);
                Console.WriteLine(ex.ToString());
            }
        }

        private void onSendComplete(IAsyncResult ar)
        {
            StateObject obj_SocketState = (StateObject)ar.AsyncState;
            Socket obj_Socket = obj_SocketState.WorkSocket;
        }

        private void onConnectionComplete(IAsyncResult ar)
        {
            try
            {
                m_tmpSocket = (Socket)ar.AsyncState;
                m_tmpSocket.EndConnect(ar);

                var handler = this.m_connected;
                if (handler != null)
                    handler("null");

                Socket obj_Socket = m_tmpSocket;
                StateObject obj_SocketState = new StateObject();
                obj_SocketState.WorkSocket = obj_Socket;
                obj_Socket.BeginReceive(obj_SocketState.Buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(onDataArrival), obj_SocketState);
            }
            catch (Exception ex)
            {
                var handler = this.m_failed;
                if (handler != null)
                    handler("null");
                Console.WriteLine(ex.ToString());
            }
        }

        public string SocketID()
        {
            return m_SocketID;
        }
    }
}
