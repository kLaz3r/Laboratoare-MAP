using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Mediator
{
    internal class Program
    {
        static void Main()
        {
            IChatroom chatroom = new Chatroom();

            User user1 = new User("User1");
            User user2 = new User("User2");
            User user3 = new User("User3");

            chatroom.Register(user1);
            chatroom.Register(user2);
            chatroom.Register(user3);

            user1.Send(user2, "Hello, User2!");
            user2.Send(user1, "Hi, User1!");

            chatroom.Unregister(user3);
            user1.Send(user3, "Are you there, User3?");
        }
    }
}
