// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Promt(string message) // метод вызова ввода числа в терминале
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int Zadacha(int number) // метод нахождения третьего числа 
{
    while (number > 999) // пока число больше 999 дели его на 10 
        {
        number = number / 10;
        }
    return number % 10; // когда оно стало трехзначным верни остаток от деления
}
   
 

int number = Promt("Введите число "); //иницаиализация переменной с присвоением ей результата метода
if (number < 100) // если число меньше 100 
{
    Console.Write("Третьей цифры нет "); //то вот так
}
else //иначе 
{
   Console.Write(Zadacha(number)); //вот так
}
  