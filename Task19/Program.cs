// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
string Reverse(int n1)
{
    int digit5 = n1 % 10;
    int digit4 = (n1 / 10) % 10;
    int digit2 = (n1 / 1000) % 10;
    int digit1 = n1 / 10000;
    if (digit1 == digit5 && digit2 == digit4) return "Да";
    return "Нет";
}
string result = Reverse(n);
Console.WriteLine(result);
