using System;

class Student
{
    public string Name;
    public int Age;

    // Конструктор без параметров
    public Student()
    {
        Name = "Неизвестно";
        Age = 0;
    }

    // Конструктор с параметрами
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Метод для вывода информации
    public void ShowInfo()
    {
        Console.WriteLine($"Имя: {Name}, возраст: {Age}");
    }
}

class Program
{
    static void Main()
    {
        // Первый объект: данные вводит пользователь
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите возраст: ");
        int age = int.Parse(Console.ReadLine());

        Student student1 = new Student(name, age);

        // Второй объект: данные задаются программно
        Student student2 = new Student("NPC", 18);

        // Вывод информации
        student1.ShowInfo();
        student2.ShowInfo();
    }
}
