using  Jessica;
using Resumes;
class Program
{
    static void Main(string[] args)
    {
        Jessica.Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Mile Stone";
        job1._startYear = 2002;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Teacher";
        job2._company = "Stepping Stone Montessori";
        job2._startYear = 2024;
        job2._endYear = 2026;

        Resumes.Resume resume = new Resumes.Resume();
        resume._name = "Catherine Boyd";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();

        
        
    }
}
class Resume
{
    private string _name = "";
    private List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"{_name}");
        foreach (Job job in _jobs)
        {
            Console.WriteLine($"{job}");
        }
    }
}







