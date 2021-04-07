using Akka.Actor;
using MovieStreaming.Actors;
using MovieStreaming.Messages;
using System;

namespace MovieStreaming
{
    class Program
    {

        private static ActorSystem MovieStreamingActorSystem;
        static void Main(string[] args)
        {
            MovieStreamingActorSystem = ActorSystem.Create("MovieStreamingActorSystem");
            Console.WriteLine("Actor system created");
            Props playbackProps = Props.Create<PlaybackActor>();
            IActorRef playbackActorRef = MovieStreamingActorSystem.ActorOf(playbackProps, "PlaybackActor");

            playbackActorRef.Tell(new PlayMovieMessage("Akka.NET The Movie", 123));
            

            Console.ReadLine();
            MovieStreamingActorSystem.Terminate();
        }
    }
}
