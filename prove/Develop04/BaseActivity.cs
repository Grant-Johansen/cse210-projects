public class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration; 
    private DateTime _endTime;
    
    
    public BaseActivity(string name, string description)
    {
        _name = name;
        _description= description;
        
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_name} activity! {_description}");
        ObtainDuration();
    }
    public void EndActivity()
    {
        Console.WriteLine($"Thanks for participating in the {_name}!");
        
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

    public void RunSpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        Console.Clear();
        Console.WriteLine($"{message}");
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
        Console.Clear();
        Console.CursorVisible = true; 
    }

    public int ObtainDuration()
    {
    Console.WriteLine("How long many seconds would you like to do this activity for?");
    _duration = int.Parse(Console.ReadLine());
    return _duration;
    }
}