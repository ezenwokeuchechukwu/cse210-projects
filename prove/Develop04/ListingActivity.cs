public class ListingActivity : MindfulnessActivity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Queue<string> shuffledPrompts;

    public ListingActivity()
    {
        Name = "Listing";
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        ShufflePrompts();
    }

    private void ShufflePrompts()
    {
        shuffledPrompts = new Queue<string>(Prompts.OrderBy(x => Guid.NewGuid()));
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

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("List an item: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
        }
        Console.WriteLine($"You listed {items.Count} items.");
        EndActivity();
    }
}
