using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Composite
{
    public class WhatsAppImpl : IMessagingService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"WhatsApp: Sending message - {message}");
        }

        public void SendFile(string file)
        {
            Console.WriteLine($"WhatsApp: Sending file - {file}");
        }

        public void VoiceCall()
        {
            Console.WriteLine("WhatsApp: Voice call");
        }

        public void VideoCall()
        {
            Console.WriteLine("WhatsApp: Video call");
        }
    }
}
