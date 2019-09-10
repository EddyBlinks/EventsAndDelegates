using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class EmailService
    {
        public void OnSongComposed(object source, SongEventArgs args)
        {

            Console.WriteLine("Mail Service: Sending Email ..." + args.Song.Title);

        }
    }
}
