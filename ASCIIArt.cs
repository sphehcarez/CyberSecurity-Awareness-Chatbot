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
                  _____      _                                      _ _         
                 / ____|    | |                                    (_) |        
                | |    _   _| |__   ___ _ __ ___  ___  ___ _   _ _ _| |_ _   _ 
                | |   | | | | '_ \ / _ \ '__/ __|/ _ \/ __| | | | | | __| | | |
                | |___| |_| | |_) |  __/ |  \__ \  __/ (__| |_| | | | |_| |_| |
                 \_____\__, |_.__/ \___|_|  |___/\___|\___|\__,_|_|_|\__|\__, |
                        __/ |                                              __/ |
                       |___/                                              |___/ 
                    _                                          ____        _   
                   / \__      ____ _ _ __ ___ _ __   ___  ___ | __ )  ___ | |_ 
                  / _ \ \ /\ / / _` | '__/ _ \ '_ \ / _ \/ __||  _ \ / _ \| __|
                 / ___ \ V  V / (_| | | |  __/ | | |  __/\__ \| |_) | (_) | |_ 
                /_/   \_\_/\_/ \__,_|_|  \___|_| |_|\___||___/|____/ \___/ \__|
                                                               
                ");
;
            Console.ResetColor();
        }
    }
}
