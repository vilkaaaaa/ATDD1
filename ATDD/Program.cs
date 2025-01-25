namespace ATDD
{
    internal class Program
    {
        static void Main(string[] args)
        {
           TaskMameger taskMameger = new TaskMameger();
            Console.WriteLine("Введите описание задачи");
            taskMameger.AddTask(Console.ReadLine());
            var taskId = taskMameger.GetTasks()[0].Id;
            Console.WriteLine("Выберите действие (цифру):\n1. Изменить статус\n2. Добавить задачу\n3. Удалить задачу");
            var action = Console.ReadKey();
            if (action.KeyChar == '1')
            {
                Console.WriteLine();
                Console.WriteLine("Введите новый статус");
                taskMameger.Update(taskId,Console.ReadLine());
                taskMameger.GetTasks();
            }
            if (action.KeyChar == '2')
            {
                Console.WriteLine();
                Console.WriteLine("Введите описание задачи");
                taskMameger.AddTask(Console.ReadLine());
                Console.WriteLine("Задача добавлена");
                taskMameger.GetTasks();
            }
            if (action.KeyChar == '3')
            {
                Console.WriteLine();
                taskMameger.GetTasks();
                taskMameger.Delete(taskId);
                Console.WriteLine("Задача удалена");
            }
        }
    }
}