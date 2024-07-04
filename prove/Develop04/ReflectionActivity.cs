public class ReflectionActivity : MindfulnessActivity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Queue<string> shuffledPrompts;
    private Queue<string> shuffledQuestions;

    public ReflectionActivity()
    {
        Name = "Reflection";
        Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        ShufflePrompts();
    }

    private void ShufflePrompts()
    {
        shuffledPrompts = new Queue<string>(Prompts.OrderBy(x => Guid.NewGuid()));
        shuffledQuestions = new Queue<string>(Questions.OrderBy(x => Guid.NewGuid()));
    }

    public override void PerformActivity()
    {
        StartActivity();
        if (shuffledPrompts.Count == 0)
        {
            ShufflePrompts();
        }

        string prompt = shuffledPrompts.Dequeue();
        Console.WriteLine(prompt);
        PauseWithAnimation(3);

        for (int i = 0; i < Duration; i += 5)
        {
            if (shuffledQuestions.Count == 0)
            {
                ShufflePrompts();
            }
            string question = shuffledQuestions.Dequeue();
            Console.WriteLine(question);
            PauseWithAnimation(5);
        }
        EndActivity();
    }
}
