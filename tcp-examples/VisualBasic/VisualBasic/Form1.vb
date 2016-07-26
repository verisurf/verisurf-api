Imports System

Public Class Form1
    Private WithEvents client As New Verisurf.AsyncSocket

    Shared client_message As String = ""
    Shared server_message As String = ""

    Private Sub Command1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Command1.LinkClicked
        If client.Connected() = False Then
            Try
                client = New Verisurf.AsyncSocket
                client.Connect("127.0.0.1", 33666)
                client_message = "Verisurf Connection Established"
            Catch ex As Exception
            End Try
        Else
            client_message = "Verisurf Connection Already Established"
            UpdateResults()
        End If
    End Sub

    Private Sub Command2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Command2.LinkClicked
        SendCommand("<command_list />")
    End Sub

    Private Sub Command3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Command3.LinkClicked
        If client.Connected() = True Then
            Dim openFileDialog1 As New OpenFileDialog()
            openFileDialog1.Filter = "Verisurf Files (*.mcam)|*.*"
            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                SendCommand("<file_open filename='" + openFileDialog1.FileName + "' />")
            End If
        Else
            client_message = "Verisurf Connection Not Established"
            UpdateResults()
        End If
    End Sub

    Private Sub Command4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Command4.LinkClicked
        SendCommand("<inspect_plan_list />")
    End Sub

    Private Sub Command5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Command5.LinkClicked
        SendCommand("<inspect_plan_load id='0' />")
    End Sub

    Private Sub Command6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Command6.LinkClicked
        SendCommand("<inspect_plan_info />")
    End Sub

    Private Sub Command7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Command7.LinkClicked
        SendCommand("<inspect_object_measure id='0' />")
    End Sub

    Private Sub Command8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Command8.LinkClicked
        SendCommand("<inspect_object_info id='0' />")
    End Sub

    Private Sub Command9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Command9.LinkClicked
        If client.Connected() = True Then
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "Verisurf Files (*.mcam)|*.*"
            If saveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                SendCommand("<file_save filename='" + saveFileDialog1.FileName + "' />")
            End If
        Else
            client_message = "Verisurf Connection Not Established"
            UpdateResults()
        End If
    End Sub

    Private Sub Command10_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Command10.LinkClicked
        If client.Connected() = True Then
            client.Close()
            client_message = "Verisurf Connection Closed"
            UpdateResults()
        Else
            client_message = "Verisurf Connection Not Established"
            UpdateResults()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SendCommand(Command.Text)
    End Sub

    Sub UpdateResults()
        If client_message.Length() & server_message.Length() Then
            Dim message As String = ""
            If client_message.Length() Then
                message += "CLIENT: " + client_message & vbCrLf & vbCrLf
            End If
            If server_message.Length() Then
                message += "SERVER: " + server_message & vbCrLf & vbCrLf
            End If

            client_message = ""
            server_message = ""

            If InvokeRequired Then
                Invoke(Sub() Results.Text = message)
            Else
                Results.Text = message
            End If
        End If
    End Sub

    Private Sub SendCommand(ByVal command As String)
        If client.Connected() = True Then
            client_message = command
            client.Send(command & vbLf)
        Else
            client_message = "Verisurf Connection Not Established"
            UpdateResults()
        End If
    End Sub

    Private Sub socketDataArrival(ByVal SocketID As String, ByVal SocketData As String) Handles client.socketDataArrival
        server_message = SocketData
        UpdateResults()
    End Sub

    Private Sub socketFailed(ByVal SocketID As String) Handles client.socketFailed
        client_message = "Verisurf Connection Failed"
        UpdateResults()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ctrl As Control
        For Each ctrl In Me.Controls
            If (ctrl.GetType() Is GetType(LinkLabel)) Then
                Dim ll As LinkLabel = CType(ctrl, LinkLabel)
                ll.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
            End If
        Next
    End Sub
End Class