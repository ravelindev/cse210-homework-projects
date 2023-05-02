using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Tester";
        job1._company = "Github";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Q & A Tester";
        job2._company = "Twitter";
        job2._startYear = 2018;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Rudy Ravein";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
