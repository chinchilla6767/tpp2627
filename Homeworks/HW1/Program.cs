using System;
class Minibankomat
{
    static double StartBalanse()
    {
        Console.WriteLine("Нчальный баланс: ");
        s = Console.ReadLine();
        if (s >= 0)
        {
            return s;
        }
        else Console.WriteLine(" Ошибка");
    }
    static void Print(double balance, string r ="P")
    {
        Console.WriteLine($"Баланс: {balance} {r} ");
    }
    static void PopolnChota(double balanсe, List<string>history)
    {
        Console.WriteLine("Сумма пополнения: ");
        string s = Console.ReadLine();
        if (s > 0)
        {
            balance += s;
            string popoln = $"Пополнение на {s} P";
            history.Add(popoln);
        }
        else Console.WriteLine("Нельзя прибавлять отричательное количество денег");
    }
    static void SnatieDeneg(double balanсe, List<string>history)
    {
        Console.WriteLine("Сумма пополнения: ");
        string s = Console.ReadLine();
        if (s > 0 || s <= balance)
        {
            balance -= s;
            string cnato = $"Снято {s} P";
            history.Add(cnato);
        }
        else if (s > balance) Console.WriteLine("Недостаточно средств");
        else Console.WriteLine("Нельзя вычитать отричательное количество денег");
    }
    static void VivodHistory(List<string> history)
    {
        if (history.Count == 0) {
            Console.WriteLine("История операций пуста"); 
            return;
            }
        else
        {
            Console.WriteLine($"История операций: ");
            for (int i = 0; i < history.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{history[i]}");
            }
        }
    }
    static void Main()
    {
        Console.WriteLine("Нчальный баланс: ");
        double balance = StartBalanse();
        bool ch = true;
        List<string>history = new List<string>();
        while(ch)
        {
            Console.WriteLine("1 - Показать баланс\n2 - Пополнить счёт\n3 - Снять деньги\n4 - Показать историю операций\n 5 - Выйти");
            string a = Console.ReadLine();
            if (a == 1) Print(balance);
            else if (a == 2) PopolnChota(balanсe, history);
            else if (a == 3) SnatieDeneg(balanсe, history);
            else if (a == 4) VivodHistory(history);
            else if (a == 0) ch = false;
            else Console.WriteLine("Такого пункта в меню нет");
            }
        }
}
