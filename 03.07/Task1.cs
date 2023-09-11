namespace _03._07;
public class Task1 : ITask
{
    public void Do()
    {
        int input_mode;
        int result_mode;

        string input;

        Console.WriteLine("Выберите систему счисления числа, из которой будет осуществлятся перевод");
        Console.WriteLine(
            "2 - двоичная\n" +
            "8 - восьмиричная\n" +
            "10 - десятиричная\n" +
            "16 - шеснадцатиричная");

        input_mode = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Выберите систему счисления числа, в которую будет осуществлятся перевод");
        result_mode = Convert.ToInt32(Console.ReadLine());

        if (input_mode == result_mode)
            throw new Exception("Системы счисления одинаковы");

        if (input_mode!= 2 && input_mode != 8 && input_mode != 10 && input_mode != 16)
            throw new Exception("Несуществующая система счисления");

        Console.WriteLine("Введите число");
        string _input = Console.ReadLine();
        string _result = String.Empty;

        switch (result_mode)
        {
            case 2:
                _result = Convert.ToString(Convert.ToByte(_input), 2);
                break;
            case 8:
                _result = Convert.ToString(Convert.ToByte(_input), 8);
                break;
            case 10:
                _result = Convert.ToString(Convert.ToByte(_input), 10);
                break;
            case 16:
                _result = Convert.ToString(Convert.ToByte(_input),16);
                break;
            default:
                throw new Exception("Несуществующая система счисления");
        }
        Console.WriteLine(_result);
    }
}
