using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Powerpoint_clicker
{
    public partial class Form1 : Form
    {
        private bool enabledBool = false;
        private string hostName;
        private string IP;
        private int port = 8080; // Replace with your desired HTTP port

        private HttpListener httpListener;
        private Thread serverThread;
        private Socket httpServer;

        public Form1()
        {
            InitializeComponent();
            customports.Text = Convert.ToString(port);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!enabledBool)
            {
                enabledBool = true;
                serverLogsText.Text = "";
                StartServer();
            }
            else
            {
                enabledBool = false;
                StopServer();
            }
            enabled();
        }

        public void enabled()
        {
            if (enabledBool)
            {
                button1.Text = "Disable";
                status.Text = "Running";
                hostName = Dns.GetHostName();
                IP = Dns.GetHostByName(hostName).AddressList[0].ToString();
                iplable.Text = "Ip: " + IP;
                portlable.Text = "Port: " + port.ToString();
                webaddress.Text = "http://" + IP + ":" + port;
            }
            else
            {
                button1.Text = "Enable";
                status.Text = "Not Enabled";
                iplable.Text = "Ip: ";
                portlable.Text = "Port: ";
                webaddress.Text = "";
            }
        }

        private void customports_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(customports.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                customports.Text = customports.Text.Remove(customports.Text.Length - 1);
            }
            else
            {
                if (customports.Text.Length > 0)
                {
                    port = Convert.ToInt32(customports.Text);
                }
            }
        }

        private void webaddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (enabledBool)
            {
                System.Diagnostics.Process.Start("http://" + IP + ":" + port);
            }
        }

        private void StartServer()
        {
            try
            {
                // Initialize the httpServer socket and bind it to the desired IP address and port
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, port);
                httpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                httpServer.Bind(endpoint);
                httpServer.Listen(1);

                serverThread = new Thread(new ThreadStart(this.ConnectionThreadMethod));
                serverThread.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while starting the server");
                serverLogsText.Text = "Server Starting Failed \n";
            }

            serverLogsText.Text = "Server Started";
        }

        private void StopServer()
        {
            try
            {
                // Close the Socket
                httpServer.Close();

                // Kill the Thread
                serverThread.Abort();

                // Disable and Enable Buttons
            }
            catch (Exception ex)
            {
                Console.WriteLine("Stopping Failed");
            }
        }

        private void ConnectionThreadMethod()
        {
            while (true)
            {
                DateTime time = DateTime.Now;

                String data = "";
                byte[] bytes = new byte[2048];

                Socket client = httpServer.Accept(); // Blocking Statement

                // Reading the inbound connection data
                while (true)
                {
                    int numBytes = client.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, numBytes);

                    if (data.IndexOf("\r\n") > -1)
                        break;
                }

                // Data Read

                serverLogsText.Invoke((MethodInvoker)delegate
                {
                    // Runs inside the UI Thread
                    // serverLogsText.Text += "\r\n\r\n";
                    // serverLogsText.Text += data;
                    // serverLogsText.Text += "\n\n------ End of Request -------";
                });

                // Handle button clicks and simulate arrow key presses
                if (data.Contains("button?direction=Left"))
                {
                    // Simulate the left arrow key press
                    SendKeys.SendWait("{LEFT}");
                }
                else if (data.Contains("button?direction=Right"))
                {
                    // Simulate the right arrow key press
                    SendKeys.SendWait("{RIGHT}");
                }

                // Send back the Response with HTML buttons
                string resHeader = "HTTP/1.1 200 OK\nServer: my_csharp_server\nContent-Type: text/html; charset: UTF-8\n\n";
                string resBody = @"
<!DOCTYPE html>
<html>
<head>
    <title>Arrow Controls</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <style>
        body {
            font-family: Arial, sans-serif;
            text-align: center;
            margin: 0;
            padding: 0;
            display: flex;
            flex-direction: column;
            justify-content: space-between;
            height: 100vh; /* Set the body to full viewport height */
            background-color: black;
        }
        h1 {
            margin-top: 20px;
        }
        .button-container {
            display: flex;
            flex-direction: column;
            align-items: stretch;
        }
        .arrow-button {
            padding: 20px;
            font-size: 24px;
            cursor: pointer;
            margin: 10px;
            background-color: #212121;
            color: white;
            border: none;
            outline: none;
            border-radius: 10px;
            flex-grow: 1; /* Allow buttons to grow and fill available space */
            height: 50vh;
        }
        #result {
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <div class=""button-container"">
        <button class=""arrow-button"" onclick=""buttonClicked('Left')"">Left</button>
        <button class=""arrow-button"" onclick=""buttonClicked('Right')"">Right</button>
    </div>
    <div id=""result""></div>
    <script>
        function buttonClicked(direction) {
            var xhttp = new XMLHttpRequest();
            xhttp.open('GET', '/button?direction=' + direction, true);
            xhttp.send();
        }
    </script>
</body>
</html>

";
                string response = resHeader + resBody;
                byte[] resData = Encoding.ASCII.GetBytes(response);

                client.SendTo(resData, client.RemoteEndPoint);

                client.Close();
            }
        }
    }
}
