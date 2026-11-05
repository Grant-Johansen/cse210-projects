class BaseActivity
{
    public BaseActivity()
    {
       // COMPLETE 
    }
    public void RunCountDownMeassage (string message, int seconds)
    {
        Console.CursorVisible = false;
        for(int i =5; i>0; i--)
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