using System;

class Program
{
    static void Main(string[] args)
    {
       
        Menu myMenu = new Menu();
        int response = 0;

        while (response !=4)
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
                    ListingActivity Listing = new ListingActivity("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    Listing.SetPrompts();
                    Listing.RunActivity();
                    break;
                case 4:              
                    break;
            }  
        }

    }
}