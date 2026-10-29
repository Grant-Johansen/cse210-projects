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

        List<Person> myPeople = new List<Person>();

        myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPolice);

        foreach(Person person in myPeople)
        {
            if(person is Doctor doctor)
            {
                Console.WriteLine("Doctor");
                Console.WriteLine(doctor. GetDoctorInformation());
            }
            else if (person is Police police)
            {
               Console.WriteLine("Police");
                Console.WriteLine(police. GetPoliceInformation()); 
            }
            else
            {
                Console.WriteLine(person.GetPersonInformation());
            }
            
        }

    }
}