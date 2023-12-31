﻿using System.Linq.Expressions;

namespace _03._07;

public class Task2 : ITask
{
    public void Do()
    {
        Console.WriteLine("Введите цифру буквами на английском");
        string? _input = Console.ReadLine();
        if (!GetNumber.ContainsKey(_input))
            throw new ArgumentException("Неверный ввод, цифры с таким названием не существует");
        Console.WriteLine(GetNumber[_input]);
    }
    private readonly Dictionary<string, int> GetNumber = new Dictionary<string, int>()
        {
            {"zero", 0},
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9}
        };
}
