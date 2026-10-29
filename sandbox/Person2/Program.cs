class Program
{
    public static void Main()
    {
        Person myPerson = new Person("John", "Revelator", 50, 180.0);

        // myPerson.GetPersonInformation();
        Console.WriteLine(myPerson.GetPersonInformation());
        Doctor myDoctor = new Doctor ("Bob", "Payne", 45, 279, "Gabbel");
        Police myPolice = new Police ("Greg", "Grim", 51, 181, "Guns");

        Console.WriteLine(myDoctor.GetPersonInformation());
        Console.WriteLine(myDoctor.GetDoctorInformation());
        Console.WriteLine(myPolice.GetPoliceInformation());
    }
}