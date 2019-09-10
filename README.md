# EventsAndDelegates
This program is a small example on Events and Delegates in C#. It has a Song Class which is our main object/Subject.
It also has a SongComposer Class which composes a Song. The song Composer class here consist the Delegate, the Event and the Method that raises the Event.
We also have 3 subscribers to this Event in the song composer class namely the Email, Message and Notification Classes.
These classes are notified when an Event is raised and perform specific tasks like Sending and Email, a message and a notification
to a user when a song is composed.
