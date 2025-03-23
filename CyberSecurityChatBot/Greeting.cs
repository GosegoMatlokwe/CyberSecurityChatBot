using System.Media;
using System;

namespace CyberSecurityChatBot
{
  public class Greeting
    {
        public Greeting()
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\goseg\OneDrive\Documents\GitHub\CyberSecurityChatBot\CyberSecurityChatBot\CyberSecurityAwarenessChatbotGreeting.wav");
            player.PlaySync();
            Console.WriteLine("Hello! Welcome to the Cybersecurity Awareness ChatBot. I am here to help you stay safe online");
        }
    }
}