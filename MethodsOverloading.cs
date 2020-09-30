using System;
class Programm
{
    static void show(string txt)
    {
        Console.WriteLine("Текст: " + txt);
    }
    static void show(int num)
    {
        Console.WriteLine("Целое число: " + num);
    }
    static void show(double num)
    {
        Console.WriteLine("Действительнок число: " + num);
    }
    static void show(char s)
    {
        Console.WriteLine("Символ: " + s);
    }
    static void show(int num, char s)
    {
        Console.WriteLine("Аргументы {0} и {1}", num, s);
    }
    static void Main()
    {
        int num = 5;
        double z = 3.14;
        char symb = 'Z';
        show(symb);
        show("Знакомимся с перегрузкой методов");
        show(num);
        show(z);
        show(num, 'A');
    }
}