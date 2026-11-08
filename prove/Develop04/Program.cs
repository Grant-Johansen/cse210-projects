using System;

class Program
{
    static void Main(string[] args)
    {
        // BaseActivity activity = new BaseActivity();
        // // activity.RunCountDownMeassage("Get Ready", 5);
        // activity.RunSpinnerMessage("Hello", 5);

        Menu myMenu = new Menu();
        int response = 0;

        while (response !=5)
        {
            response = myMenu.MenuOptions();
            
            switch (response)
            {
                case 1:
                 BreathingActivity Breath = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing." );
                 Breath.RunActivity();
                    break;
                case 2: 
                ReflectionActivity Reflect = new ReflectionActivity("Reflection Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    Reflect.SetPromptsAndQuestions();
                    Reflect.RunActivity();
                    break;
                case 3:
                    
                
                    break;
                case 4:              
                    break;
            }  
        }
        
        // while (response != "4")
        // {
        //     if (_userChoice == "1")
        //     {
        //         BreathingActivity Breath = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing." );
        //         Breath.RunActivity();
        //         Console.WriteLine("Would you like to quit? If yes type 4");
        //         _userChoice = Console.ReadLine();

        //     }
        //     else if (_userChoice =="2")
        //     {
        //         //Call Listening Activity
        //     }
        //     else if (_userChoice =="3")
        //     {
        //         //Call Reflection Activity 
        //     }
        //     else if (_userChoice =="4")
        //     {
        //         Console.WriteLine("Goodbye.");
        //     }
        //     else
        //     {
        //         Console.WriteLine("You entered an invalid response, try again.");
        //     }
        // }

    }
}