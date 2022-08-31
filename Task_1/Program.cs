// ## Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Первый вариант решения:

double function()
{
    Console.WriteLine("Введите число, которое нужно возвести в степень: ");
    double number1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Введите степень в которую нужно возвести число {number1}: ");
    double number2 = Convert.ToDouble(Console.ReadLine());
    double result = Math.Round(Math.Pow(number1,number2),2);
    return result;
}
try
{
    Console.WriteLine("Ответ: " + function());
}
catch
{
    Console.WriteLine("error");
}

// Второй вариант решения:

// double function()
// {
//     Console.WriteLine("Введите число, которое нужно возвести в степень: ");
//     double number1 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine($"Введите степень в которую нужно возвести число {number1}: ");
//     double number2 = Convert.ToDouble(Console.ReadLine());
//     double result = number1;
//     for (int count = 1; count < number2; count++)
//     {
//         result = result * number1;
//     }
//     result = Math.Round(result,2);
//     return result;
// }
// try
// {
//     Console.WriteLine("Ответ: " + function());
// }
// catch
// {
//     Console.WriteLine("error");
// }