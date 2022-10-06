int newNumber = new Random().Next(1, 10000);
Console.WriteLine(newNumber);
if (newNumber > 100)
{
    int A = newNumber / 10;
    int B = A % 10;
    Console.WriteLine (B);
} 
else
{
    Console.WriteLine("Третьей цифры нет");
}