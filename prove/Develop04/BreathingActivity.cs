class BreathingActivity : BaseActivity
{

    public BreathingActivity(string name, string description): base(name, description)
    {
        description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void RunActivity()
    {
        StartActivity();

        DateTime endTime = DateTime.Now.AddSeconds(20);
        RunCountDownMeassage("Get Ready", 5);
        StartTimer();
        while (! HasTimerExpiered())
        {
            RunCountDownMeassage("Breath in", 4);
            RunCountDownMeassage("Breath out", 6);
        }
        
        EndActivity();
    }
}