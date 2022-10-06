Console.WriteLine("Введите день недели");
 int Day;
if(int.TryParse( Console.ReadLine(), out Day))
{
    if(Day <= 5)
    {
        Console.WriteLine("Сегодня будний день");
    }
    else
    {
       if (Day <= 7)
       {
         Console.WriteLine("Cегодня входной!");
       }
       else
       {
       Console.WriteLine("В неделе 7 дней!");
       }

    }
}
else
{
    Console.WriteLine($"Ошибка ввода!");
}