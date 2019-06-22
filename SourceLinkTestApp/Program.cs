namespace SourceLinkTestApp
{
    using System;
    using SourceLinkTestLib;

    class Program
    {
        static void Main(string[] args)
        {
            HappyEchoService echoService = new HappyEchoService();
            string happyWorld = echoService.Echo("Hello World!");

            Console.WriteLine(happyWorld);
        }
    }
}
