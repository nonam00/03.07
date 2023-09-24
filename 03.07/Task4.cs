namespace _03._07;
public class Task4 : ITask
{
    public void Do()
    {
        Console.WriteLine("Введите логическое выражение");
        string? expression = Console.ReadLine();
        Console.WriteLine(eval(expression));
    }
    private bool eval(string? expression)
    {
        int num1 = 0;
        int num2 = 0;
        string operation = String.Empty;

        //проверки на то, есть ли 2 числа в строке
        bool flag1 = false;
        bool flag2 = false;

        //проверка на отрицательность числа
        bool negative1 = false;
        bool negative2 = false;

        int i = 0; //индекс проверяемого элемента
        try //для проверки на наличие всех элементов неравенства (1 число, операция, 2 число)
        {
            //первое число
            if (expression[i] == '-')
            {
                i++;
                negative1 = true;
            }
            while (Char.IsNumber(expression[i]))
            {
                flag1 = true;
                num1 = num1 * 10 + Convert.ToInt32(expression[i++]);
            }
            if (negative1)
                num1 *= -1;

            //операция
            while (Char.IsSymbol(expression[i]))
            {
                operation += expression[i++];
            }

            //второе число
            if (expression[i] == '-')
            {
                i++;
                negative2 = true;
            }
            while (i < expression.Length && Char.IsNumber(expression[i]))
            {
                flag2 = true;
                num2 = num2 * 10 + Convert.ToInt32(expression[i++]);
            }
            if (negative2)
                num2 *= -1;
        }
        catch(IndexOutOfRangeException) { throw new ArgumentException("Неверный формат ввода"); }

        if (!(flag1 && flag2))
            throw new ArgumentException("Неверный формат ввода");

        return res(num1, num2, operation);
    }

    private bool res(int num1, int num2, string operation)
    {
        switch(operation)
        {
            case ">": return num1 > num2;
            case "<": return num1 < num2;
            case ">=": return num1 >= num2;
            case "<=": return num1 <= num2;
            case "!=": return num1 != num2;
            case "==": return num1 == num2;
            default:
                throw new ArgumentException("Неправильный формат ввода");
        }
    }
}