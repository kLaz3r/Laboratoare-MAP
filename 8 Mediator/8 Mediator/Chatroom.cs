using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Mediator
{
    public class Chatroom : IChatroom
    {
        private List<User> users = new List<User>();

        public void Register(User user)
        {
            if (!users.Contains(user))
            {
                users.Add(user);
                user.Chatroom = this;
            }
        }

        public void Unregister(User user)
        {
            if (users.Contains(user))
            {
                users.Remove(user);
                user.Chatroom = null;
            }
        }

        public void Send(User fromUser, User toUser, string message)
        {
            if (users.Contains(fromUser) && users.Contains(toUser))
            {
                toUser.Receive(fromUser, message);
            }
        }
    }
}
