using System;
using System.Windows.Forms;
using System.Text;
using System.Net.Sockets;
using System.Threading;
namespace ChatClient
{
    public partial class Form1 : Form
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;
        Thread ctThread;

        public Form1()
        {
            InitializeComponent();

            try
            {
                readData = "Conected to Chat Server ...";
                msg();
                clientSocket.Connect("127.0.0.1", 8888);
                serverStream = clientSocket.GetStream();

                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(txtChatName.Text + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                ctThread = new Thread(getMessage);
                ctThread.Start();
            }
            catch (Exception ex)
            {
                txtMessageList.Text = txtMessageList.Text + Environment.NewLine + " >> " + "Unable to connect to server!";
                //this.Close();
            }
        }

        private void btnConnectToServer_Click(object sender, EventArgs e)
        {
             
        } 

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(txtMessage.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }

        private void getMessage()
        {
            while (true)
            {
                try
                {
                    serverStream = clientSocket.GetStream();
                    int buffSize = 0;
                    byte[] inStream = new byte[100025];
                    buffSize = clientSocket.ReceiveBufferSize;
                    serverStream.Read(inStream, 0, buffSize);
                    string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                    readData = "" + returndata;
                    msg();
                }
                catch(Exception ex)
                {
                    
                    //this.Invoke((MethodInvoker)delegate
                    //{
                    //    txtMessageList.Text = txtMessageList.Text + Environment.NewLine + " >> " + "Unable to connect to server!";
                    //});

                    ctThread.Abort();
                    
                }
                
            }
        }

        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
                txtMessageList.Text = txtMessageList.Text + Environment.NewLine + " >> " + readData;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serverStream != null) {
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes("0" + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
            }

            clientSocket.GetStream().Close();
            clientSocket.Close();

            if (ctThread != null) {
                ctThread.Abort();
            }

            //this.Invoke((MethodInvoker)delegate
            //{
            //     close the form on the forms thread

            //});
        }


    }
}
