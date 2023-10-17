Console.Write("Введите трёхзначное число - ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number > 99 && number < 1000) || (number < -99 && number > -1000))
{
   int result = number % 100 / 10;
   Console.Write("Вторая цифра этого числа " + result);
}
else
{
    Console.Write("Не верно введено число");
}