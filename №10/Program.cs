Console.WriteLine("Введите число");
int newNumber;
int.TryParse( Console.ReadLine(), out newNumber);
int A = newNumber / 10;
int B = A % 10;
Console.WriteLine (B);

