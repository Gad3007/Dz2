Console.WriteLine("Введите цифру от 1 до 7 ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 0 && num < 8 )
{
    if(num > 5 )
    {
      Console.Write("Yes");  
    }
    else
    {
      Console.Write("No");
    }
}
else
{
    Console.Write("Такого дня недели не существует");
}