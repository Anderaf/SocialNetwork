using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class UserIncomingMessageView
    {
        public void Show(IEnumerable<Message> incomingMessages)
        {
            Console.WriteLine("Входящие сообщения");
            foreach (var message in incomingMessages)
            {
                Console.WriteLine(message.SenderUserEmail);
                Console.WriteLine(message.Content + '\n');
            }
        }
    }
}
