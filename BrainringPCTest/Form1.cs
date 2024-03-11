using System.Net;
using System.Net.Sockets;
using System.Text;

namespace BrainringPCTest
{
    // https://stackoverflow.com/questions/20038943/simple-udp-example-to-send-and-receive-data-from-same-socket
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UdpClient client = new UdpClient();

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // send data
            client.Send(Encoding.UTF8.GetBytes("Red"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // send data
            client.Send(Encoding.UTF8.GetBytes("Blue"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(textBox1.Text), 11000); // endpoint where server is listening
            client.Connect(ep);
        }
    }
}
