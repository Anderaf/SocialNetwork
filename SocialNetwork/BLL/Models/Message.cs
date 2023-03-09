using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string SenderUserEmail { get; set; }
        public string RecipientUserEmail { get; set; }
        public Message(int id, string content, string senderUserEmail, string recipientUserEmail)
        {
            Id = id;
            Content = content;
            SenderUserEmail = senderUserEmail;
            RecipientUserEmail = recipientUserEmail;
        }
    }
}
