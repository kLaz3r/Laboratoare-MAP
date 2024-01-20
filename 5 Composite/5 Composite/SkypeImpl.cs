using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Composite
{
    public class SkypeImpl : IMessagingService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Skype: Sending message - {message}");
        }

        public void SendFile(string file)
        {
            Console.WriteLine($"Skype: Sending file - {file}");
        }

        public void VoiceCall()
        {
            Console.WriteLine("Skype: Voice call");
        }

        public void VideoCall()
        {
            Console.WriteLine("Skype: Video call");
        }
    }
}
