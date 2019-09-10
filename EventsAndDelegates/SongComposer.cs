using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class SongEventArgs : EventArgs
    {
        public Song Song { get; set; }
    }
    public class SongComposer
    {
        // 1- Define a delegate
        // 2- Define an Event base on that delegate
        // 3- Raise the Event


        // 1- Define a delegate
        public delegate void SongComposedEventHandler(object source, SongEventArgs args);

        // 2- Define an Event base on that delegate
        public event SongComposedEventHandler SongComposed;

        public void Compose(Song song)
        {
            Console.WriteLine("Composing song ....");
            System.Threading.Thread.Sleep(2000);

            OnSongComposed(song);
        }

        // 3- Raise the Event

            // Notify Subscribers to Event SongComposed.
            // Check if Subcriber list is not Empty
            // Call SongComposed and parse current class(Object source) and event data.
        protected virtual void OnSongComposed(Song song)
        {
            if (SongComposed != null)
                SongComposed(this, new SongEventArgs() {Song = song });
        }
    }
}
