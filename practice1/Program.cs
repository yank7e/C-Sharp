using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        List<ITask> tasks = new List<ITask>
        {
            new Task1(),
            new Task2(),
            new Task3(),
            new Task4()
        };

        foreach (var task in tasks)
        {
            task.Execute();
        }
    }
}