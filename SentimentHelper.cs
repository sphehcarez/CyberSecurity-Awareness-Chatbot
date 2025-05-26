using System;

namespace CyberSecurity_Awareness_chatbot
{
    internal static class SentimentHelper
    {
        /// <summary>
        /// Detects the sentiment in user input by checking for key emotional keywords.
        /// </summary>
        /// <param name="input">The user's input message.</param>
        /// <returns>Sentiment string: 'concerned', 'curious', or 'neutral'</returns>
        public static string DetectSentiment(string input)
        {
            input = input.ToLower();

            if (input.Contains("worried") || input.Contains("scared") || input.Contains("anxious") || input.Contains("concerned"))
                return "concerned";

            if (input.Contains("curious") || input.Contains("interested") || input.Contains("keen") || input.Contains("wondering"))
                return "curious";

            return "neutral";
        }

        /// <summary>
        /// Provides an empathetic response based on detected sentiment.
        /// </summary>
        /// <param name="mood">The detected sentiment string.</param>
        /// <returns>A supportive or informative response string.</returns>
        public static string RespondToSentiment(string mood)
        {
            switch (mood)
            {
                case "concerned":
                    return "It's completely understandable to feel that way. Let's take steps to stay safe online.";
                case "curious":
                    return "Curiosity is the first step toward being cyber-smart! What would you like to learn more about?";
                default:
                    return "Let’s continue learning more about cybersecurity topics.";
            }
        }
    }
}
