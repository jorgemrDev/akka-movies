
using Akka.Actor;
using MovieStreaming.Messages;
using System;

namespace MovieStreaming.Actors
{
    public class PlaybackActor : ReceiveActor
    {
        public PlaybackActor()
        {
            Console.WriteLine("Creating PlaybackActor");

            Receive<PlayMovieMessage>(message => HandlePlayMovieMessage(message), message => message.UserId == 123);
        }

        private void HandlePlayMovieMessage(PlayMovieMessage message) {
            Console.WriteLine($"Received movie title: {message.MovieTitle}");
            Console.WriteLine($"Received user id: {message.UserId}");
        }

        
    }
}
