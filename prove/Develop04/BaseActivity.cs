class BaseActivity
{
    private int _duration; 
    private DateTime _endTime;

    public BaseActivity()
    {
       _duration = 10; // Replace later with call to ObtainDuration() 
    }

    public void StartActivity()
    {
        //COMPLETE
    }

    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpiered()
    {
        return DateTime.Now > _endTime;
    }

    public void RunCountDownMeassage (string message, int seconds)
    {
        Console.CursorVisible = false;
        for(int i =seconds; i>0; i--)
        {
        Console.Clear();
        Console.WriteLine($"{message} - {i}"); 
        Thread.Sleep(1000);
        }
        Console.CursorVisible = true;
    }

    public void RunSpinnerMessage(string mesage, int seconds)
    {
        Console.CursorVisible = false;
        // DateTime now = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b");
        }
        Console.CursorVisible = true; 
    }

}