using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Mediator
{
    public interface IUser
    {
        string Name { get; }
        IChatroom Chatroom { get; set; }

        void Send(User toUser, string message);
        void Receive(User fromUser, string message);
    }
}
