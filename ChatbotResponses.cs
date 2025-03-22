using System;

class ChatbotResponses
{
    public static void RespondToUser(string input)
    {
        switch (input)
        {
            case "password tips":
                Utils.TypingEffect("Use strong passwords with uppercase, lowercase, numbers, and symbols.");
                break;
            case "phishing scams":
                Utils.TypingEffect("Be careful of suspicious emails. Don't click unknown links.");
                break;
            default:
                Utils.TypingEffect("I'm not sure about that. Try 'password tips' or 'phishing scams'.");
                break;
        }
    }
}
