using _03._07;


ITask task;
Console.WriteLine("Выберите задание");
string choice = Console.ReadLine();
try
{
    switch (choice)
    {
        case "1":
            task = new Task1();
            break;
        case "2":
            task = new Task2();
            break;
        case "4":
            task = new Task4();
            break;
        default:
            throw new Exception("Такого задания не существует");
    }
    task.Do();
}
catch (Exception ex) { Console.WriteLine(ex.Message); }