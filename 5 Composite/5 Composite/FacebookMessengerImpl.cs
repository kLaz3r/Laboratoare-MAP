using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Composite
{
    public class FacebookMessengerImpl : IMessagingService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Facebook Messenger: Sending message - {message}");
        }

        public void SendFile(string file)
        {
            Console.WriteLine($"Facebook Messenger: Sending file - {file}");
        }

        public void VoiceCall()
        {
            Console.WriteLine("Facebook Messenger: Voice call");
        }

        public void VideoCall()
        {
            Console.WriteLine("Facebook Messenger: Video call");
        }
    }
}
