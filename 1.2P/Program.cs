using System;

namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            Message myMessage;
            Message[] messages = {new Message("Hi Bao, welcome back!"),
                                new Message("Great to see you again, Huy ^^"),
                                new Message("Isn't it Duc the showman himself!"),
                                new Message("Yo, Hung!"),
                                new Message("Welcome, nice to meet you.")
                                };
            string name;

            myMessage = new Message("Hello World!");
            myMessage.Print();

            while (true)
            {
                Console.WriteLine("Enter name: ");
                name = Console.ReadLine();
                if (name.ToLower() == "bao")
                {
                    messages[0].Print();
                }
                else if (name.ToLower() == "huy")
                {
                    messages[1].Print();
                }
                else if (name.ToLower() == "duc")
                {
                    messages[2].Print();
                }
                else if (name.ToLower() == "hung")
                {
                    messages[3].Print();
                }
                else
                {
                    messages[4].Print();
                }
            }


        }
    }
}
