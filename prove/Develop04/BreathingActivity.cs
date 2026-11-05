class BreathingActivity : BaseActivity
{

    public BreathingActivity(): base()
    {
        
    }
    public void RunActivity()
    {
        // call StartActivty() method

        DateTime endTime = DateTime.Now.AddSeconds(20);
        RunCountDownMeassage("Get Ready", 5);
        StartTimer();
        // while (DateTime.Now < endTime) //Delete later
        while (! HasTimerExpiered())
        {
            RunCountDownMeassage("Breath in", 4);
            RunCountDownMeassage("Breath out", 6);
        }


        // CALL EndActivity()
    }
}