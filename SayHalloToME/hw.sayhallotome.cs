using System;

namespace SayHalloToME
{
    class SayHalloToMe
    {
        static void Main()
        {
            Console.WriteLine("Hello, what's your name darling");
            string clientname = Console.ReadLine();
            Console.WriteLine(clientname + " How old are you");
            string clientage = Console.ReadLine();
            Console.WriteLine("ohh i'm  "+ clientage +"  years old too");
        }
    }
}
