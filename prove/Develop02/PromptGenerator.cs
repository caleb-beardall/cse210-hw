using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>();
    }

    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        
        return randomPrompt;
    }

}