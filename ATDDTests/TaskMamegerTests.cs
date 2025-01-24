using Xunit;
using ATDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATDD.Tests
{
    public class TaskMamegerTests
    {
        [Fact()]
        public void AddTaskTest()
        {
            var manager = new TaskMameger();
            manager.AddTask("Первая задача");
            var task = manager.GetTasks();
            var test2 = "Первая задача";
            var test3 = "не начато";
            Assert.Equal(1, task.Count);
            Assert.Equal(task[0].Description, test2);
            Assert.Equal(task[0].Status, test3);
        }

        [Fact()]
        public void UpdateTest()
        {
            var manager = new TaskMameger();
            manager.AddTask("Первая задача");
            var taskId = manager.GetTasks()[0].Id;
            manager.Update(taskId, "в работе");
            var test1 = "в работе";
            var task = manager.GetTasks().First(t => t.Id == taskId);
            Assert.Equal(task.Status, test1);
        }
        [Fact()]
        public void DeleteTest()
        {
            var manager = new TaskMameger();
            manager.AddTask("Первая задача");
            var taskId = manager.GetTasks()[0].Id;
            manager.Delete(taskId);
            List<Task> tasks = manager.GetTasks();
            Assert.Empty(tasks);
        }
    }
}