using System;

class Program
{
    static void Main(string[] args)
    {
        BaseActivity activity = new BaseActivity();
        // activity.RunCountDownMeassage("Get Ready", 5);
        activity.RunSpinnerMessage("Hello", 5);
    }
}