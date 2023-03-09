using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Services
{
    public class FriendService
    {
        IFriendRepository friendRepository = new FriendRepository();
        IUserRepository userRepository = new UserRepository();

        public IEnumerable<Friend> GetFriendsById(int id)
        {
            var friends = new List<Friend>();

            friendRepository.FindAllByUserId(id).ToList().ForEach(f =>
            {
                var friendEmail = userRepository.FindById(f.friend_id).email;
                friends.Add(new Friend(f.id, f.user_id, f.friend_id, friendEmail));
            });

            return friends;
        }

        public void AddFriend(FriendAddingData friendAddingData)
        {
            var userEntity = userRepository.FindById(friendAddingData.FriendId);
            if (userEntity == null)
                throw new UserNotFoundException();

            FriendEntity friendEntity = new FriendEntity()
            {
                user_id = friendAddingData.UserId,
                friend_id = friendAddingData.FriendId
            };
            friendRepository.Create(friendEntity);
            userEntity.
            userRepository.Update()
        }

    }
}
