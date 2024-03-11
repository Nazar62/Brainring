using System.Net;
using System.Text;

namespace Brainring
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

    }
}
