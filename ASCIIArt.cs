using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity_Awareness_chatbot
{
    internal class ASCIIArt
    {
        public static void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
                  ____        _     _            _         
                 / ___|  ___ | |__ (_)_ __   ___| |_ _ __  
                 \___ \ / _ \| '_ \| | '_ \ / _ \ __| '_ \ 
                  ___) | (_) | |_) | | | | |  __/ |_| | | |
                 |____/ \___/|_.__/|_|_| |_|\___|\__|_| |_|");
            Console.ResetColor();
        }
    }
}
