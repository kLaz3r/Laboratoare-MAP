using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Composite
{
    public interface IMessagingService
    {
        void SendMessage(string message);
        void SendFile(string file);
        void VoiceCall();
        void VideoCall();
    }
}
