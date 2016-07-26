using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp
{
    public partial class Form1 : Form
    {
        private Verisurf.AsyncSocket client = new Verisurf.AsyncSocket();
        private string client_message = "";
        private string server_message = "";

        private void Command1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(client.Connected() == false)
            {
                try
                {
                    client = new Verisurf.AsyncSocket();
                    client.m_failed += new Verisurf.socketFailed(socketFailed);
                    client.m_dataarrival += new Verisurf.socketDataArrival(socketDataArrival);
                    client.Connect("127.0.0.1", 33666);
                    client_message = "Verisurf Connection Established";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                client_message = "Verisurf Connection Already Established";
                UpdateResults();
            }
        }

        private void Command2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendCommand("<command_list />");
        }

        private void Command3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (client.Connected())
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Verisurf Files (*.mcam)|*.*";
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    SendCommand("<file_open filename='" + openFileDialog1.FileName + "' />");
                }
            }
            else
            {
                client_message = "Verisurf Connection Not Established";
                UpdateResults();
            }
        }

        private void Command4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendCommand("<inspect_plan_list />");
        }

        private void Command5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendCommand("<inspect_plan_load id='0' />");
        }

        private void Command6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendCommand("<inspect_plan_info />");
        }

        private void Command7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendCommand("<inspect_object_measure id='0' />");
        }

        private void Command8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendCommand("<inspect_object_info id='0' />");
        }

        private void Command9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (client.Connected())
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Verisurf Files (*.mcam)|*.*";
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    SendCommand("<file_save filename='" + saveFileDialog1.FileName + "' />");
                }
            }
            else
            {
                client_message = "Verisurf Connection Not Established";
                UpdateResults();
            }
        }

        private void Command10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (client.Connected())
            {
                client.Close();
                client_message = "Verisurf Connection Closed";
                UpdateResults();
            }
            else
            {
                client_message = "Verisurf Connection Not Established";
                UpdateResults();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SendCommand(Command.Text);
        }

        private void UpdateResults()
        {
            if(client_message.Length > 0 || server_message.Length > 0)
            {
                string message = "";
                if (client_message.Length > 0)
                    message += "CLIENT: " + client_message + "\r\n\r\n";
                if (server_message.Length > 0)
                    message += "SERVER: " + server_message + "\r\n\r\n";

                client_message = "";
                server_message = "";

                if(Results.InvokeRequired)
                {
                    Results.Invoke((MethodInvoker) delegate { Results.Text = message; });
                }
                else
                {
                    Results.Text = message;
                }
            }
        }

        private void SendCommand(string command)
        {
            if(client.Connected())
            {
                client_message = command;
                client.Send(command + "\n");
            }
            else 
            {
                client_message = "Verisurf Connection Not Established";
                UpdateResults();
            }
        }

        public void socketFailed(string SocketID)
        {
            client_message = "Verisurf Connection Failed";
            UpdateResults();
        }

        public void socketDataArrival(string SocketID, string SocketData)
        {
            server_message = SocketData;
            UpdateResults();
        }

        public Form1()
        {
            InitializeComponent();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is LinkLabel)
                {
                    LinkLabel ll = (LinkLabel)ctrl;
                    ll.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
                }
            }
        }
    }
}
