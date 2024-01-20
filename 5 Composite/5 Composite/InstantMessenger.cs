using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Composite
{
    public class InstantMessenger : IInstantMessenger
    {
        private IMessagingService messagingService;

        public InstantMessenger(IMessagingService messagingService)
        {
            this.messagingService = messagingService;
        }

        public void SendMessage(string message)
        {
            messagingService.SendMessage(message);
        }

        public void SendFile(string file)
        {
            messagingService.SendFile(file);
        }
    }
}
