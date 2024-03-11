using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Brainring
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        bool connected = false;

        public MainPage()
        {
            InitializeComponent();
        }

        public string ip;
        public string Color = "green";
        public UdpClient client = new UdpClient();
        // 172.24.144.1
        public async Task GetIP()
        {
            ip = await DisplayPromptAsync("IP", "Введіть ip пк");
            try
            {
                IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ip), 11000); // endpoint where server is listening
                client.Connect(ep);
                connected = true;
            }
            catch
            {
                DisplayAlert("Помилка", "Помилка підключення до сервера відкрийте програму на пк або перезапустіть цю", "Ok");
            }
        }
        public async Task SetColor()
        {
            var colorR = await DisplayAlert("Колір", "Який колір Вибираєте?", "Червоний", "Синій");
            if (colorR)
            {
                Color = "Red";
                button.BackgroundColor = Colors.Red;
            }
            else
            {
                Color = "Blue";
                button.BackgroundColor = Colors.Blue;
            }
            return;
        }
        private void Send()
        {
            client.Send(Encoding.UTF8.GetBytes(Color));
        }

        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();
        //    //OnLoaded();
        //}

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            if(connected)
            {
                Send();
            } else
            {
                await GetIP();
                await SetColor();
            }

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
        async void OnLoaded()
        {
            await Device.InvokeOnMainThreadAsync( async () =>
            {
                await GetIP();
                await SetColor();
            });
        }
    }

}
