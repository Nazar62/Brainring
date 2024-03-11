
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Media;
using System.Reflection;

namespace BrainringPC
{
    public partial class Form1 : Form
    {
        UdpClient udpServer = new UdpClient(11000);
        bool redAns, blueAns, nowAnswer;
        int m, s, totalSeconds;
        public static int max = 60;
        SoundPlayer player = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = "gong-9.wav";
            player.Load();
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(x => x.AddressFamily == AddressFamily.InterNetwork);
            return "Ip: " + string.Join(" або ", host);
        }

        private void labelTimer_Click(object sender, EventArgs e)
        {

        }

        private void labelRedCount_Click(object sender, EventArgs e)
        {

        }

        private void labelBlueCount_Click(object sender, EventArgs e)
        {

        }
        public void NullateAnswer()
        {
            nowAnswer = false;
            blueAns = false;
            redAns = false;
        }

        public void NullateSec()
        {
            s = 0;
            m = 0;
            totalSeconds = 0;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && labelTimer.Text != "Фальш")
            {
                panelColor.BackColor = Color.White;
                if (redAns)
                {
                    var rate = int.Parse(labelRedCount.Text) + 1;
                    labelRedCount.Text = $"{rate}";
                    NullateAnswer();
                    labelTimer.Text = "Таймер";
                    panelColor.BackColor = Color.White;
                    NullateSec();
                    timer.Stop();
                } else if (blueAns)
                {
                    var rate = int.Parse(labelBlueCount.Text) + 1;
                    labelBlueCount.Text = $"{rate}";
                    NullateAnswer();
                    labelTimer.Text = "Таймер";
                    panelColor.BackColor = Color.White;
                    NullateSec();
                    timer.Stop();
                } else
                {
                    NullateSec();
                    labelTimer.Text = "0:0";
                    NullateAnswer();
                    timer.Start();
                    //string executablePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    //string wavFilePath = Path.Combine(executablePath, "gong-9.wav");
                    player.Play();
                }
            }
            //if (e.KeyCode == Keys.Left)
            //{
            //    timer.Stop();
            //    labelTimer.Text = "Таймер";
            //    panelColor.BackColor = Color.White;
            //    blueAns = false;
            //}
            //if (e.KeyCode == Keys.Right)
            //{
            //    var rate = int.Parse(labelBlueCount.Text) + 1;
            //    labelBlueCount.Text = $"{rate}";
            //}
            if (e.KeyCode == Keys.Up)
            {
                //labelTimer.Text = "Таймер";
                panelColor.BackColor = Color.White;
                timer.Start();
                NullateAnswer();
            }
            if (e.KeyCode == Keys.Down)
            {
                labelTimer.Text = "Таймер";
                panelColor.BackColor = Color.White;
                NullateSec();
                timer.Stop();
                labelBlueCount.Text = "0";
                labelRedCount.Text = "0";
                NullateAnswer();
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            s++;
            totalSeconds++;
            if (s == 60)
            {
                m++;
                s = 0;
            }
            if (totalSeconds == max)
            {
                timer.Stop();
            }
            labelTimer.Text = $"{m}:{s}";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                settings s = new settings();
                s.Show();
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(GetLocalIPAddress());
            _ = Task.Run(async () =>
            {
                while (true)
                {
                    var remoteEP = new IPEndPoint(IPAddress.Any, 11000);
                    var data = udpServer.Receive(ref remoteEP); // listen on port 11000
                    var mess = Encoding.UTF8.GetBytes("hello client");
                    var res = Encoding.UTF8.GetString(data);

                    labelTimer.Invoke(new System.Windows.Forms.MethodInvoker(delegate
                    {
                        if (labelTimer.Text != "Таймер")
                        {
                            if (!nowAnswer)
                            {
                                if (res == "Red")
                                {
                                    panelColor.BackColor = Color.Red;
                                    redAns = true;
                                    blueAns = false;
                                    nowAnswer = true;
                                    timer.Stop();
                                }
                                else if (res == "Blue")
                                {
                                    panelColor.BackColor = Color.Blue;
                                    blueAns = true;
                                    redAns = false;
                                    nowAnswer = true;
                                    timer.Stop();
                                }
                            }
                        } else
                        {
                            labelTimer.Text = "Фальш";
                            if (!nowAnswer)
                            {
                                if (res == "Red")
                                {
                                    panelColor.BackColor = Color.Red;
                                    nowAnswer = true;
                                    //timer.Stop();
                                }
                                else if (res == "Blue")
                                {
                                    panelColor.BackColor = Color.Blue;
                                    nowAnswer = true;
                                    //timer.Stop();
                                }
                            }
                        }
                    }));
                }
            });
            //MessageBox.Show("Started");
        }
    }
}
