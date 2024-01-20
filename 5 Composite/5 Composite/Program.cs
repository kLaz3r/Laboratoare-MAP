using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Composite
{
    internal class Program
    {
        static void Main()
        {
            IMessagingService skypeService = new SkypeImpl();
            IInstantMessenger skypeMessenger = new InstantMessenger(skypeService);

            skypeMessenger.SendMessage("Hello from Skype!");
            skypeMessenger.SendFile("Document.pdf");

            IMessagingService facebookService = new FacebookMessengerImpl();
            IInstantMessenger facebookMessenger = new InstantMessenger(facebookService);

            facebookMessenger.SendMessage("Hi from Facebook Messenger!");
            facebookMessenger.SendFile("Image.jpg");

            IMessagingService whatsappService = new WhatsAppImpl();
            IInstantMessenger whatsappMessenger = new InstantMessenger(whatsappService);

            whatsappMessenger.SendMessage("Hey from WhatsApp!");
            whatsappMessenger.SendFile("Video.mp4");
        }
    }
}
