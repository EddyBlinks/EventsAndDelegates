using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class MessageNotification
    {
        public void OnSongComposed(object source, SongEventArgs args)
        {
            Console.WriteLine("Message Notification: You have got a new Email");
        }
    }
}
