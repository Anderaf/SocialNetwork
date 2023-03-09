﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Models
{
    public class Friend
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FriendId { get; set; }
        public string FriendEmail { get; set; }
        public Friend(int id, int userId, int friendId, string friendEmail)
        {
            Id = id;
            UserId = userId;
            FriendId = friendId;
            FriendEmail = friendEmail;
        }
    }
}
