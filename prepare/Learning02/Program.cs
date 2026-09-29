using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2012;
        job1._endYear = 2023; 

        job2._jobTitle = "IT Support";
        job2._company = "Verizon";
        job2._startYear = 2023;
        job2._endYear = 2026; 

        Resume resume1 = new Resume();

        resume1._name = "Hanna";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }
}