using System;
using System.Collections.Generic;

namespace ToDo_console
{
    class Program
    {
        static List<string> todoList = new List<string>();

        static void Main()
        {
            Console.WriteLine("Добро пожаловать в приложение ToDo!");

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Посмотреть список задач");
                Console.WriteLine("2. Добавить новую задачу");
                Console.WriteLine("3. Удалить задачу");
                Console.WriteLine("0. Выйти");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowTodoList();
                        break;
                    case "2":
                        AddTask();
                        break;
                    case "3":
                        RemoveTask();
                        break;
                    case "0":
                        Console.WriteLine("До свидания!");
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                        break;
                }
            }
        }

        static void ShowTodoList()
        {
            Console.WriteLine("\nСписок задач:");
            if (todoList.Count == 0)
            {
                Console.WriteLine("Нет задач.");
            }
            else
            {
                for (int i = 0; i < todoList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {todoList[i]}");
                }
            }
        }

        static void AddTask()
        {
            Console.Write("\nВведите новую задачу: ");
            string newTask = Console.ReadLine();
            todoList.Add(newTask);
            Console.WriteLine("Задача добавлена!");
        }

        static void RemoveTask()
        {
            ShowTodoList();
            if (todoList.Count == 0)
            {
                return;
            }

            Console.Write("\nВведите номер задачи, которую хотите удалить: ");
            if (int.TryParse(Console.ReadLine(), out int taskIndex) && taskIndex > 0 && taskIndex <= todoList.Count)
            {
                todoList.RemoveAt(taskIndex - 1);
                Console.WriteLine("Задача удалена!");
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Задача не удалена.");
            }
        }
    }
}
