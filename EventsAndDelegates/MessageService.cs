using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class MessageService
    {
        public void OnSongComposed(object source, SongEventArgs e)
        {

        Console.WriteLine("Message Service: Sending message ....." + e.Song.Title);

        }
    }
}
