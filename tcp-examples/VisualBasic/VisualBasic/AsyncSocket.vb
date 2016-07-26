Imports System
Imports System.Text
Imports System.Net
Imports System.Net.Sockets

Namespace Verisurf
    Public Class StateObject
        Public WorkSocket As Socket = Nothing
        Public BufferSize As Integer = 32767
        Public Buffer(32767) As Byte
        Public StrBuilder As New StringBuilder
    End Class

    Public Class AsyncSocket
        Private m_SocketID As String
        Private m_tmpSocket As Socket
        Public Event socketDisconnected(ByVal SocketID As String)
        Public Event socketDataArrival(ByVal SocketID As String, ByVal SocketData As String)
        Public Event socketConnected(ByVal SocketID As String)
        Public Event socketFailed(ByVal SocketID As String)

        Public Sub New(ByVal tmp_Socket As Socket, ByVal tmp_SocketID As String)
            m_SocketID = tmp_SocketID
            m_tmpSocket = tmp_Socket

            Dim obj_Socket As Socket = tmp_Socket
            Dim obj_SocketState As New StateObject

            obj_SocketState.WorkSocket = obj_Socket
            obj_Socket.BeginReceive(obj_SocketState.Buffer, 0, obj_SocketState.BufferSize, 0, New AsyncCallback(AddressOf onDataArrival), obj_SocketState)
        End Sub

        Public Sub New()
            m_tmpSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        End Sub

        Public Sub Send(ByVal tmp_Data As String)
            Try
                Dim obj_StateObject As New StateObject
                obj_StateObject.WorkSocket = m_tmpSocket

                Dim Buffer As Byte() = Encoding.ASCII.GetBytes(tmp_Data)
                m_tmpSocket.BeginSend(Buffer, 0, Buffer.Length, 0, New AsyncCallback(AddressOf onSendComplete), obj_StateObject)
            Catch ex As Exception
            End Try
        End Sub

        Public Sub Close()
            m_tmpSocket.Shutdown(SocketShutdown.Both)
            m_tmpSocket.Close()
        End Sub

        Public Sub Connect(ByVal hostIP As String, ByVal hostPort As Integer)
            Dim remoteEP As New IPEndPoint(IPAddress.Parse(hostIP), hostPort)
            Dim obj_Socket As Socket = m_tmpSocket
            Try
                obj_Socket.BeginConnect(remoteEP, New AsyncCallback(AddressOf onConnectionComplete), obj_Socket)
            Catch ex As Exception
            End Try
        End Sub

        Public Function Connected() As Boolean
            Return m_tmpSocket.Connected
        End Function

        Private Sub onDataArrival(ByVal ar As IAsyncResult)
            Try
                Dim obj_SocketState As StateObject = CType(ar.AsyncState, StateObject)
                Dim obj_Socket As Socket = obj_SocketState.WorkSocket
                Dim sck_Data As String
                Dim BytesRead As Integer = obj_Socket.EndReceive(ar)

                If BytesRead > 0 Then
                    sck_Data = Encoding.ASCII.GetString(obj_SocketState.Buffer, 0, BytesRead)
                    RaiseEvent socketDataArrival(m_SocketID, sck_Data)
                End If
                obj_Socket.BeginReceive(obj_SocketState.Buffer, 0, obj_SocketState.BufferSize, 0, New AsyncCallback(AddressOf onDataArrival), obj_SocketState)
            Catch e As Exception
                RaiseEvent socketDisconnected(m_SocketID)
            End Try
        End Sub

        Private Sub onSendComplete(ByVal ar As IAsyncResult)
            Dim obj_SocketState As StateObject = CType(ar.AsyncState, StateObject)
            Dim obj_Socket As Socket = obj_SocketState.WorkSocket
        End Sub

        Private Sub onConnectionComplete(ByVal ar As IAsyncResult)
            Try
                m_tmpSocket = CType(ar.AsyncState, Socket)

                m_tmpSocket.EndConnect(ar)
                RaiseEvent socketConnected("null")

                Dim obj_Socket As Socket = m_tmpSocket
                Dim obj_SocketState As New StateObject
                obj_SocketState.WorkSocket = obj_Socket
                obj_Socket.BeginReceive(obj_SocketState.Buffer, 0, obj_SocketState.BufferSize, 0, New AsyncCallback(AddressOf onDataArrival), obj_SocketState)
            Catch ex As Exception
                RaiseEvent socketFailed("null")
            End Try
        End Sub

        Public ReadOnly Property SocketID() As String
            Get
                SocketID = m_SocketID
            End Get
        End Property
    End Class
End Namespace