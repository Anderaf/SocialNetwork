using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.DAL.Entities;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class FriendAddingView
    {
        UserService userService;
        public FriendAddingView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show(User user)
        {
            Console.Write("Введите почтовый адрес друга: ");
            string email = Console.ReadLine();

            try
            {
                User friendUser = userService.FindByEmail(email);

                var friendAddingData = new FriendAddingData()
                {
                    FriendEmail = friendUser.Email,
                    UserId = user.Id
                };

                userService.AddFriend(friendAddingData);
                
                SuccessMessage.Show("Друг успешно добавлен!");
            }
            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден");
                throw;
            }
            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка при добавлении в друзья");
            }
        }
    }
}
