using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video("Terminator");

            var encoder = new VideoEncoder();
            encoder.VideoEncoded += Encoder_VideoEncoded;
            Console.WriteLine("Encoding started");
            encoder.Encode(video);         
        }

        private static void Encoder_VideoEncoded(object sender, EventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Video encoding done, ---> event was fired.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
