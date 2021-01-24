using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var encoder = new VideoEncoder();
            encoder.VideoEncoded += Encoder_VideoEncoded;
            Console.WriteLine("Encoding started");

            encoder.Encode(new Video("Terminator"));

            encoder.Encode(new Video("Rambo"));

            encoder.Encode(new Video("Shining"));
        }

        private static void Encoder_VideoEncoded(object sender, EventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Video encoding done ---> event was fired.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
