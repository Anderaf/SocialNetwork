using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class UserFriendsView
    {
        public void Show(IEnumerable<Friend> friends)
        {
            Console.WriteLine("Друзья:");
            foreach (var friend in friends)
            {
                Console.WriteLine(friend.FriendEmail);
            }
            Console.WriteLine();
        }
    }
}
