﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATDD
{
    public class TaskMameger
    {
        public List <Task> tasks = new List <Task> ();
        public void AddTask(string description) 
        {
        tasks.Add(new Task { Id = Guid.NewGuid(), Description = description, Status="не начато"});
        }
        public List<Task> GetTasks() {
            foreach (var task in tasks)
            {
                for (int i = 1; i <= tasks.Count; i++)
                {
                    Console.WriteLine($"№ {i} Id: {task.Id} Описание: {task.Description} Статус: {task.Status}");
                    break;
                }

            }
            return tasks;
        }
        public void Update(Guid id, string newStatus)
        {
        var task = tasks.FirstOrDefault(t => t.Id == id);
            if(task!= null)
            {
                task.Status = newStatus;
            }
        }
        public void Delete(Guid id) 
        {
        tasks.RemoveAll(task => task.Id == id);
        }
    }
    public class Task
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
