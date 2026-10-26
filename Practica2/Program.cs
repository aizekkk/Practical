using System;

class Student
{
    public string Surname { get; private set; }
    public string Name { get; private set; }
    public string Patronymic { get; private set; }
    public DateTime BirthDate { get; private set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public int Course { get; set; }
    public string Group { get; set; }
    public string RecordBookNumber { get; private set; }

    // Конструктор без параметров
    public Student()
    {
        Surname = "Не указана";
        Name = "Не указано";
        Patronymic = "Не указано";
        BirthDate = DateTime.MinValue;
        Address = "Не указан";
        Phone = "Не указан";
        Email = "Не указан";
        Course = 1;
        Group = "Не указана";
        RecordBookNumber = "Не указан";
    }

    // Конструктор с параметрами
    public Student(
        string surname,
        string name,
        string patronymic,
        DateTime birthDate,
        string address,
        string phone,
        string email,
        int course,
        string group,
        string recordBookNumber)
    {
        Surname = surname;
        Name = name;
        Patronymic = patronymic;
        BirthDate = birthDate;
        Address = address;
        Phone = phone;
        Email = email;
        Course = course;
        Group = group;
        RecordBookNumber = recordBookNumber;
    }

    // Преобразование информации о студенте в строку
    public override string ToString()
    {
        return $"ФИО: {Surname} {Name} {Patronymic}\n" +
               $"Дата рождения: {BirthDate:dd.MM.yyyy}\n" +
               $"Адрес: {Address}\n" +
               $"Телефон: {Phone}\n" +
               $"Электронная почта: {Email}\n" +
               $"Курс: {Course}\n" +
               $"Группа: {Group}\n" +
               $"Номер зачётной книжки: {RecordBookNumber}";
    }

    // Сравнение студентов по фамилии
    public bool CompareBySurname(Student other)
    {
        return Surname.Equals(
            other.Surname,
            StringComparison.OrdinalIgnoreCase);
    }
}

class Program
{
    static void Main()
    {
        // Первый студент: ввод данных пользователем
        Console.Write("Введите фамилию: ");
        string surname = Console.ReadLine() ?? "";

        Console.Write("Введите имя: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Введите отчество: ");
        string patronymic = Console.ReadLine() ?? "";

        Console.Write("Введите дату рождения (дд.мм.гггг): ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine() ?? "");

        Console.Write("Введите адрес: ");
        string address = Console.ReadLine() ?? "";

        Console.Write("Введите телефон: ");
        string phone = Console.ReadLine() ?? "";

        Console.Write("Введите электронную почту: ");
        string email = Console.ReadLine() ?? "";

        Console.Write("Введите курс: ");
        int course = int.Parse(Console.ReadLine() ?? "1");

        Console.Write("Введите группу: ");
        string group = Console.ReadLine() ?? "";

        Console.Write("Введите номер зачётной книжки: ");
        string recordBookNumber = Console.ReadLine() ?? "";

        Student student1 = new Student(
            surname, name, patronymic, birthDate,
            address, phone, email, course, group,
            recordBookNumber);

        // Второй студент: данные задаются программно
        Student student2 = new Student(
            "Иванов",
            "Иван",
            "Иванович",
            new DateTime(2005, 5, 15),
            "Москва",
            "+79991234567",
            "ivan@example.com",
            2,
            "ПИ-21",
            "123456");

        Console.WriteLine("\nПервый студент:");
        Console.WriteLine(student1);

        Console.WriteLine("\nВторой студент:");
        Console.WriteLine(student2);

        Console.WriteLine("\nСравнение студентов по фамилии:");

        if (student1.CompareBySurname(student2))
            Console.WriteLine("Фамилии совпадают.");
        else
            Console.WriteLine("Фамилии различаются.");
    }
}

