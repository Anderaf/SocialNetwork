using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Views;
using System.Runtime.CompilerServices;

namespace SocialNetwork
{
    public class Program
    {
        static UserService userService;
        static MessageService messageService;
        public static AuthenticationView authenticationView;
        public static MainView mainView;
        public static MessageSendingView messageSendingView;
        public static RegistrationView registrationView;
        public static UserDataUpdateView userDataUpdateView;
        public static UserIncomingMessageView userIncomingMessageView;
        public static UserInfoView userInfoView;
        public static UserMenuView userMenuView;
        public static UserOutgoingMessageView userOutcomingMessageView;
        public static UserFriendsView userFriendsView;
        public static FriendAddingView friendAddingView;
        static void Main(string[] args)
        {
            userService = new UserService();
            messageService = new MessageService();

            authenticationView = new AuthenticationView(userService);
            mainView = new MainView();
            messageSendingView = new MessageSendingView(userService, messageService);
            registrationView = new RegistrationView(userService);
            userDataUpdateView = new UserDataUpdateView(userService);
            userIncomingMessageView = new UserIncomingMessageView();
            userInfoView = new UserInfoView();
            userMenuView = new UserMenuView(userService);
            userOutcomingMessageView = new UserOutgoingMessageView();
            userFriendsView = new UserFriendsView();
            friendAddingView = new FriendAddingView(userService);

            while (true)
            {
                mainView.Show();
            }
        }
    }
}