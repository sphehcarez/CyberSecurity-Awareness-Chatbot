using System;
using System.Collections.Generic;

class ChatbotResponses
{
    // Predefined topic-to-response mapping with random tip support
    private static readonly Dictionary<string, List<string>> topicResponses =
        new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase)
        {
            {
                "password tips", new List<string>
                {
                    "Use strong passwords with uppercase, lowercase, numbers, and symbols.",
                    "Avoid using the same password across multiple accounts.",
                    "Never include personal information like your birthdate in passwords."
                }
            },
            {
                "phishing scams", new List<string>
                {
                    "Be cautious of emails asking for personal information.",
                    "Don't click links in unexpected messages — verify the sender first.",
                    "Watch out for urgent messages pressuring you to act quickly."
                }
            },
            {
                "safe browsing", new List<string>
                {
                    "Always check that URLs start with https:// before entering personal info.",
                    "Avoid downloading attachments from untrusted sources.",
                    "Use updated antivirus software and browser security extensions."
                }
            }
        };

    /// <summary>
    /// Responds to user input with a random response from the matching topic.
    /// </summary>
    public static void RespondToUser(string input)
    {
        if (topicResponses.TryGetValue(input, out List<string> responses))
        {
            var random = new Random();
            string reply = responses[random.Next(responses.Count)];
            Utils.TypingEffect(reply, useVoice: false); // optional: change to true
        }
        else
        {
            Utils.TypingEffect(
                "I'm not sure about that. Try topics like 'password tips', 'phishing scams', or 'safe browsing'."
            );
        }
    }

    /// <summary>
    /// Returns a random phishing tip for keyword-based calls (used in Chatbot.cs).
    /// </summary>
    public static string GetRandomPhishingTip()
    {
        if (topicResponses.TryGetValue("phishing scams", out var phishingTips))
        {
            var rand = new Random();
            return phishingTips[rand.Next(phishingTips.Count)];
        }

        return "Stay alert — phishing is one of the most common cyber threats!";
    }
}
