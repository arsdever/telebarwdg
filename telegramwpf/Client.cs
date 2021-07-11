using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using TLSharp.Core;

namespace TeleBarWdg
{
    public class Client
    {
        public static Client Instance { get => s_instance != null ? s_instance : s_instance = new Client(); }
        public TelegramClient TClient { get => m_client; }
        public bool IsLogged { get; private set; }

        private string _phoneNumer { get; set; }
        private string _phoneHash { get; set; }

        private CancellationTokenSource cancellation = new CancellationTokenSource();

        private static Client s_instance;
        private TelegramClient m_client;

        private Client()
        {
            int appID = 6323761;
            string appHash = "e25b785cb45d6cd4db7c60f61fcaedd0";
            m_client = new TelegramClient(
                appID,
                appHash,
                new FileSessionStore(GetTeleBarWdgFolder()));
            m_client.ConnectAsync(true).Wait();
            if (m_client.IsConnected && m_client.IsUserAuthorized())
            {
                IsLogged = true;
            }
        }

        public async Task Login(string phoneNumber)
        {
            cancellation.Cancel();
            cancellation = new CancellationTokenSource();
            _phoneNumer = phoneNumber;
            _phoneHash = await TClient.SendCodeRequestAsync(phoneNumber, cancellation.Token);
        }

        public async Task VerifyCode(string code)
        {
            cancellation.Cancel();
            cancellation = new CancellationTokenSource();
            IsLogged = await TClient.MakeAuthAsync(_phoneNumer, _phoneHash, code, cancellation.Token) != null;
        }

        public static DirectoryInfo GetTeleBarWdgFolder()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".telebarwdg");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return new DirectoryInfo(path);
        }
    }
}
