using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity_Awareness_chatbot
{
    internal class VoiceGreeting
    {
        public static void PlayGreeting()
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Speak("Hello! Welcome to the Cybersecurity Awareness Chatbot.");
        }
    }
}
