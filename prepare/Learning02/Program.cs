using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Google";
        job1._startYear = 2023;
        job1._endYear = 2025;
        job1.DisplyJobInfo();

        Job job2 = new Job();
        job2._jobTitle = "Programmer";
        job2._company = "Microsoft";
        job2._startYear = 2024;
        job2._endYear = 2028;
        job2.DisplyJobInfo();

        Resume myResume = new Resume();
        myResume._name = "Kevin Hernandez";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();

    }
}
