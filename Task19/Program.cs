//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
System.Console.WriteLine(" Введите число ");
string name = Console.ReadLine();
if (name.Length > 5 || name.Length < 5 )
{
    System.Console.WriteLine("Это число нам не подходит, попробуй ещё! =)");
}
else if (name [0] == name [4] && name [1] == name [3])
{
    System.Console.WriteLine($" Число: {name} - является палиндром");
}
else
{
    System.Console.WriteLine($" Число: {name} - не является палиндромом");
}