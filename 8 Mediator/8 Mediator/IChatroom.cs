using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Mediator
{
    public interface IChatroom
    {
        void Register(User user);
        void Unregister(User user);
        void Send(User fromUser, User toUser, string message);
    }
}
