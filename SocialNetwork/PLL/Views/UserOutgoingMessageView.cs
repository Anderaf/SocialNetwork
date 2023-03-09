using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class UserOutgoingMessageView
    {
        public void Show(IEnumerable<Message> outgoingMessages)
        {
            Console.WriteLine("Исходящие сообщения");
            foreach (var message in outgoingMessages)
            {
                Console.WriteLine(message.SenderUserEmail);
                Console.WriteLine(message.Content + '\n');
            }
        }
    }
}
