using System;

class Program
{
    static void Main(string[] args)
    {
        // BaseActivity activity = new BaseActivity();
        // // activity.RunCountDownMeassage("Get Ready", 5);
        // activity.RunSpinnerMessage("Hello", 5);

        Menu myMenu = new Menu();
        // myMenu.MenuOptions();
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