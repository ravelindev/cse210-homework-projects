using System;

public class Resume
{
    public string _name;

    // Initialization of the list to a new List.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // The loop
        foreach (Job job in _jobs)
        {
            // The Display method for each job
            job.Display();
        }
    }
}
