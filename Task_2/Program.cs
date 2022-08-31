// ## Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Напишите число: ");
int number  = Convert.ToInt32(Console.ReadLine());

int function()
{
    string string_number = Convert.ToString(number);
    int length = string_number.Length - 1;
    int sum = 0;
    for (int count = 0; count <= length; count++)
        {
            sum = sum + number%10;
            number = number/10;
        }
    return sum;
}
try
{
    Console.WriteLine("Сумма цифр равна: " + function());
}
catch
{
    Console.WriteLine("error");
}