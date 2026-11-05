class BreathingActivity : BaseActivity
{
    public void RunActivity()
    {
        // call StartActivty() method

        DateTime endTime = DateTime.Now.AddSeconds(20);
        RunCountDownMeassage("Get Ready", 5);
        while (DateTime.Now < endTime)
        {
            RunCountDownMeassage("Breath in", 4);
            RunCountDownMeassage("Breath out", 6);
        }


        // CALL EndActivity()
    }
}