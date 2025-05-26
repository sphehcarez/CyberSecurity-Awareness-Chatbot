using System;
using System.Collections.Generic;
using CyberSecurity_Awareness_chatbot;

class Chatbot
{
    private static string userName = "";
    private static List<string> userInterests = new List<string>();
    private static string currentTopic = "";

    public static void StartChat()
    {
        Utils.PrintWithColor("Welcome! What is your name?", ConsoleColor.Cyan);
        userName = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(userName))
        {
            Utils.PrintWithColor("Invalid input. Please enter a valid name:", ConsoleColor.Red);
            userName = Console.ReadLine();
        }

        Utils.TypingEffect($"Hello, {userName}! Ask me anything about cybersecurity.");
        ProcessUserInput();
    }

    public static void ProcessUserInput()
    {
        while (true)
        {
            Utils.PrintWithColor("\nType a topic (e.g., 'password tips', 'phishing scams', 'safe browsing') or type 'more' or 'exit':", ConsoleColor.Yellow);
            string input = Console.ReadLine()?.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                Utils.PrintWithColor("Input cannot be empty. Try again.", ConsoleColor.Red);
                continue;
            }

            if (input == "exit")
            {
                Utils.PrintWithColor("Goodbye! Stay safe online.", ConsoleColor.Green);
                break;
            }

            // Repeat last topic
            if (input == "more")
            {
                if (!string.IsNullOrEmpty(currentTopic))
                {
                    ChatbotResponses.RespondToUser(currentTopic);
                }
                else
                {
                    Utils.PrintWithColor("I'm not sure about that. Try topics like 'password tips', 'phishing scams', or 'safe browsing'.", ConsoleColor.Red);
                }
                continue;
            }

            // Sentiment detection
            string mood = SentimentHelper.DetectSentiment(input);
            if (mood != "neutral")
            {
                Utils.PrintWithColor(SentimentHelper.RespondToSentiment(mood), ConsoleColor.Magenta);
            }

            // Recognize topics based on keywords
            if (input.Contains("password"))
            {
                currentTopic = "password tips";
                ChatbotResponses.RespondToUser(currentTopic);
                continue;
            }

            if (input.Contains("phishing"))
            {
                currentTopic = "phishing scams";
                ChatbotResponses.RespondToUser(currentTopic);
                continue;
            }

            if (input.Contains("browsing"))
            {
                currentTopic = "safe browsing";
                ChatbotResponses.RespondToUser(currentTopic);
                continue;
            }

            // Store interest
            if (input.Contains("privacy") && !userInterests.Contains("privacy"))
            {
                userInterests.Add("privacy");
                Utils.TypingEffect("Got it! I'll remember that you're interested in privacy.");
                continue;
            }

            // Handle fallback tips for unmatched input
            string keywordTip = HandleKeywordInput(input);
            if (keywordTip != null)
            {
                currentTopic = input;
                Utils.TypingEffect(keywordTip);
                continue;
            }

            // Fallback response
            Utils.PrintWithColor("I'm not sure I understand. Can you try asking about another topic?", ConsoleColor.Red);
        }
    }

    private static string HandleKeywordInput(string input)
    {
        var tips = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "scam", "Scams often look real. Always verify links and don't share private info." },
            { "privacy", "Your privacy matters. Review app permissions and avoid oversharing online." }
        };

        foreach (var keyword in tips.Keys)
        {
            if (input.Contains(keyword))
            {
                return tips[keyword];
            }
        }

        return null;
    }
}
