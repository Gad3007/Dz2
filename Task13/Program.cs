Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99 || number < -99)
{
    int result = number % 1000 / 100;
    Console.Write(result);
}
else
{
    Console.Write("Третьей цифры нет");
} 