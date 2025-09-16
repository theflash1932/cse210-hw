using System;
using System.Globalization;
using Job;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Executech";
        job1._jobTitle = "Escalations Engineer";
        job1._startYear = 2014;
        job1._endYear = 2025;
        //job1.Display();

        Job job2 = new Job();
        job2._company = "High Desert Milk";
        job2._jobTitle = "Systems/Network Admin";
        job2._startYear = 2009;
        job2._endYear = 2014;
        //job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Greg Nielson";
        myResume._jobs = [job1, job2];
        myResume.Display();
    }
}
