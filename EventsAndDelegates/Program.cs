using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
      
        static void Main(string[] args)
        {
            var song = new Song() { Title = "Love dont cost thing" }; // Object/Instance for Song

            var songComposer = new SongComposer(); // Object/instance for Song Composer 

            // Objects/instances for Subscribers
            var eMailService = new EmailService();
            var messageService = new MessageService();
            var messageNotification = new MessageNotification();

            // 1- Using Song Composer Object to call Event Songcomposed
            // 2- using subscribers instances to get subscribtion info through Raised Event Method
            songComposer.SongComposed += eMailService.OnSongComposed;
            songComposer.SongComposed += messageService.OnSongComposed;
            songComposer.SongComposed += messageNotification.OnSongComposed;
           

            songComposer.Compose(song); // Calling Song composer method with it instance and parsing the string from the Song Class

            Console.ReadKey();
        }
    }

}
