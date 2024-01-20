using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Mediator
{
    public class User : IUser
    {
        public string Name { get; }
        public IChatroom Chatroom { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public void Send(User toUser, string message)
        {
            Console.WriteLine($"{Name} sends message to {toUser.Name}: {message}");
            Chatroom.Send(this, toUser, message);
        }

        public void Receive(User fromUser, string message)
        {
            Console.WriteLine($"{Name} receives message from {fromUser.Name}: {message}");
        }
    }
}
