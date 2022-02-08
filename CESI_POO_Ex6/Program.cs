using CESI_POO_Ex6.Model.VideoRessource;
using CESI_POO_Ex6.Services;
using System;

namespace CESI_POO_Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video("Top 10 des trucs", 10000, "<uri format:mp4//AZEFSQdqsd/>");
            VideoEncoder encoder = new();

            MailService mailService = new();

            EncodedVideo encodedVideo = encoder.Encode(video);

            mailService.Send("michel@gmail.com", "je t'envoie la vidéo asap");
            waitforInputAndClear();

            mailService.Send("michel@gmail.com", "c'est imminent", "promis je la cherche hein");
            waitforInputAndClear();

            mailService.Send("michel@gmail.com", "la voila", encodedVideo);
            Console.WriteLine();
        }

        private static void waitforInputAndClear()
        {
            Console.ReadLine();
            Console.Clear();
        }
    }
}
