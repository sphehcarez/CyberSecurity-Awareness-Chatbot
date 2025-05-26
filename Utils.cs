using System;
using System.Speech.Synthesis;
using System.Threading;

class Utils
{
    private static SpeechSynthesizer synthesizer = new SpeechSynthesizer();

    /// <summary>
    /// Prints the message to the console with the specified color.
    /// </summary>
    public static void PrintWithColor(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    /// <summary>
    /// Simulates typing effect with delay per character and optional voice output.
    /// </summary>
    /// <param name="message">The message to type and speak.</param>
    /// <param name="useVoice">Enable text-to-speech.</param>
    /// <param name="delay">Delay in milliseconds per character.</param>
    public static void TypingEffect(string message, bool useVoice = false, int delay = 50)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();

        if (useVoice)
        {
            try
            {
                synthesizer.SpeakAsync(message);
            }
            catch (Exception ex)
            {
                PrintWithColor($"[Voice Error]: {ex.Message}", ConsoleColor.DarkRed);
            }
        }
    }

    /// <summary>
    /// Clears the console and resets formatting.
    /// </summary>
    public static void ResetScreen()
    {
        Console.Clear();
        Console.ResetColor();
    }

    /// <summary>
    /// Exits the app with an animated goodbye.
    /// </summary>
    public static void ExitChat()
    {
        TypingEffect("Thank you for using the Cybersecurity Awareness Bot. Stay safe online!", true);
        Thread.Sleep(1000);
        Environment.Exit(0);
    }
}
