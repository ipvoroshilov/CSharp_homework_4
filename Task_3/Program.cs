// ## Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

string arrayGenPrint(int quantity = 8)
{
    int[] array = new int[quantity];
    string result = "";
    for (int ind = 0; ind < array.Length; ind++)
    {
        array[ind] = new Random().Next(-99,99);
        result = result + array[ind] + ", ";
    }
    return result;
}
try
{
    Console.WriteLine($"Вот 8 элементов массива: " + arrayGenPrint());
}
catch
{
    Console.WriteLine("error");
}




    // for (int ind = 0; ind < array.Length; ind++)
    // {
    //     array[ind] = new Random().Next(-99,99);
    // }
    // // foreach (var x in array)
    // // {
    // //     Console.Write(x + " ");    
    // }