using System;
using System.Speech.Synthesis;
using System.Threading;
using CyberSecurity_Awareness_chatbot;

class Utils
{
    public static void PrintWithColor(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public static void TypingEffect(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine();
    }
}
