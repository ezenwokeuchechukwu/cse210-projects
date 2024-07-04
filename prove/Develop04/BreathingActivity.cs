public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
    {
        Name = "Breathing";
        Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void PerformActivity()
    {
        StartActivity();
        for (int i = 0; i < Duration; i += 4)
        {
            Console.WriteLine("Breathe in...");
            AdvancedAnimation(2);
            Console.WriteLine("Breathe out...");
            AdvancedAnimation(2);
        }
        EndActivity();
    }

    private void AdvancedAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b/");
            Thread.Sleep(500);
            Console.Write("\b-");
            Thread.Sleep(500);
            Console.Write("\b\\");
            Thread.Sleep(500);
            Console.Write("\b|");
        }
        Console.WriteLine();
    }
}
