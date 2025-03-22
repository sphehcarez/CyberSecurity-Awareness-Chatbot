using System;

class Chatbot
{
    public static void StartChat()
    {
        Utils.PrintWithColor("Welcome! What is your name?", ConsoleColor.Cyan);
        string name = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(name))
        {
            Utils.PrintWithColor("Invalid input. Please enter a valid name:", ConsoleColor.Red);
            name = Console.ReadLine();
        }

        Utils.TypingEffect($"Hello, {name}! Ask me anything about cybersecurity.");
        ProcessUserInput();
    }

    public static void ProcessUserInput()
    {
        while (true)
        {
            Utils.PrintWithColor("\nType a topic (e.g., 'password tips') or 'exit' to quit:", ConsoleColor.Yellow);
            string input = Console.ReadLine().ToLower();

            if (input == "exit")
            {
                Utils.PrintWithColor("Goodbye!", ConsoleColor.Green);
                break;
            }

            ChatbotResponses.RespondToUser(input);
        }
    }
}
