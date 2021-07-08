using System.Linq;
using TeleSharp.TL;
using TLSharp.Core;

namespace TeleBarWdg
{
    public class Client
    {
        public static Client Instance { get => s_instance != null ? s_instance : s_instance = new Client(); }
        public TelegramClient TClient { get => m_client; }
        public string PhoneNumer { get; set; }
        public string PhoneCodeHash { get; set; }

        private static Client s_instance;
        private TelegramClient m_client;

        private Client()
        {
            int appID = 6323761;
            string appHash = "e25b785cb45d6cd4db7c60f61fcaedd0";
            m_client = new TelegramClient(appID, appHash, store: new FakeSessionStore());
            m_client.ConnectAsync(true).Wait();
        }

        public async void Run()
        {
            //TdLib.TdClient client = new TdLib.TdClient();
            //var result = client.Execute(new TdLib.TdApi.GetChats());
            //Debug.WriteLine(result.ToString());

            //string number = "+37477006861";
            //var hash = await client.SendCodeRequestAsync(number);
            //var code = "code";
            //var user = await client.MakeAuthAsync(number, hash, code);
            //var result = await client.GetContactsAsync();
            //var recipiant = result.Users.Where(x => x.GetType() == typeof(TeleSharp.TL.TLUser)).Cast<TeleSharp.TL.TLUser>().FirstOrDefault(x => x.Phone == "37499009868");
            //await client.SendMessageAsync(new TLInputPeerUser() { UserId = recipiant.Id }, "Message sent from custom C# client");
        }
    }
}
