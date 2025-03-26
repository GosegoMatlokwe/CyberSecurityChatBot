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
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@"                                                                                                                                                                                                                                   
     _/_/_/            _/                              _/_/_/                                          _/    _/                      _/_/                                                                                              
  _/        _/    _/  _/_/_/      _/_/    _/  _/_/  _/          _/_/      _/_/_/  _/    _/  _/  _/_/      _/_/_/_/  _/    _/      _/    _/  _/      _/      _/    _/_/_/  _/  _/_/    _/_/    _/_/_/      _/_/      _/_/_/    _/_/_/   
 _/        _/    _/  _/    _/  _/_/_/_/  _/_/        _/_/    _/_/_/_/  _/        _/    _/  _/_/      _/    _/      _/    _/      _/_/_/_/  _/      _/      _/  _/    _/  _/_/      _/_/_/_/  _/    _/  _/_/_/_/  _/_/      _/_/        
_/        _/    _/  _/    _/  _/        _/              _/  _/        _/        _/    _/  _/        _/    _/      _/    _/      _/    _/    _/  _/  _/  _/    _/    _/  _/        _/        _/    _/  _/            _/_/      _/_/     
 _/_/_/    _/_/_/  _/_/_/      _/_/_/  _/        _/_/_/      _/_/_/    _/_/_/    _/_/_/  _/        _/      _/_/    _/_/_/      _/    _/      _/      _/        _/_/_/  _/          _/_/_/  _/    _/    _/_/_/  _/_/_/    _/_/_/        
              _/                                                                                                      _/                                                                                                               
         _/_/                                                                                                    _/_/                                                                                                                  
                                                                          
     _/_/_/  _/                    _/      _/_/_/                _/       
  _/        _/_/_/      _/_/_/  _/_/_/_/  _/    _/    _/_/    _/_/_/_/    
 _/        _/    _/  _/    _/    _/      _/_/_/    _/    _/    _/         
_/        _/    _/  _/    _/    _/      _/    _/  _/    _/    _/          
 _/_/_/  _/    _/    _/_/_/      _/_/  _/_/_/      _/_/        _/_/  _/   
                                                                          
                                                                          
");
            Console.ResetColor();
            Console.WriteLine("Hello! Welcome to the Cybersecurity Awareness ChatBot. I am here to help you stay safe online");
        }
    }
}