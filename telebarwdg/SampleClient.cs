using System.Linq;
using TeleSharp.TL;

namespace telebarwdg
{
    public class SampleClient
    {
        public async void Run()
        {
            //TdLib.TdClient client = new TdLib.TdClient();
            //var result = client.Execute(new TdLib.TdApi.GetChats());
            //Debug.WriteLine(result.ToString());
            int appID = 6323761;
            string appHash = "e25b785cb45d6cd4db7c60f61fcaedd0";

            TLSharp.Core.TelegramClient client = new TLSharp.Core.TelegramClient(appID, appHash);
            string number = "+37477006861";
            await client.ConnectAsync(true);
            var hash = await client.SendCodeRequestAsync(number);
            var code = "code";
            var user = await client.MakeAuthAsync(number, hash, code);
            var result = await client.GetContactsAsync();
            var recipiant = result.Users.Where(x => x.GetType() == typeof(TeleSharp.TL.TLUser)).Cast<TeleSharp.TL.TLUser>().FirstOrDefault(x => x.Phone == "37499009868");
            await client.SendMessageAsync(new TLInputPeerUser() { UserId = recipiant.Id }, "Message sent from custom C# client");
        }
    }
}
