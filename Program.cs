using System;
using System.Speech.Synthesis;
using System.Threading;
using CyberSecurity_Awareness_chatbot;

namespace CyberSecurity_Awareness_Chatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CyberSecurity Awareness Chatbot";  // Set Console Title
            ASCIIArt.ShowLogo();       // Show ASCII Logo
            VoiceGreeting.PlayGreeting();  // Play Voice Greeting
            Chatbot.StartChat();       // Start Chatbot Interaction
        }
    }
}