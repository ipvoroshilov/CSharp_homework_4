// ## необязательная задача
// Написать программу, которая сортирует массив от большего к меньшему и находит медианное значение. Массив заполняется случайными целыми числами от 1 до 100, а его размерность вводится с клавиатуры.

Console.WriteLine("Введите размерность массива:");
int L = Convert.ToInt32(Console.ReadLine());
int[] array = new int [L];

// Массив заполняется случайными целыми числами от 1 до 100
string FillArray(int i = 0, string result = "")
{
    // заполнение
    for (i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,100);
    }
    // вывод массива на экран
    for (i = 0; i < array.Length; i++)
    {
        result = result + array[i] + " ";
    }
    return result;
}
try
{
    Console.WriteLine(FillArray()+" - сгенерированный массив");
}
catch
{
    Console.WriteLine("error");
}


// сортировка массива от большего к меньшему

string sortFromMaxToMin(int maxInd = 0,int curInd = 0,int temp = 0, int ind = 0,string result = "")
{
        for (maxInd = 0; maxInd < array.Length; maxInd++)
    {
        for (curInd = 0; curInd < array.Length; curInd++)
        {
            if (array[curInd] < array[maxInd])
            {
                temp = array[maxInd];
                array[maxInd] = array[curInd];
                array[curInd] = temp;
            }
        }
    }
    // вывод массива на экран
    for (ind = 0; ind < L; ind++)
    {
        result = result + array[ind] + " ";
    }
    return result;
}
try
{
    Console.WriteLine(sortFromMaxToMin()+" - отсортированный массив от большего к меньшему");
}
catch
{
    Console.WriteLine("error");
}


// нахождение медианного значения

double Mediana(double result = 0)
{
    if (array.Length % 2 == 0)
    {
        int indLeft = array.Length / 2 - 1;
        int indRight = array.Length / 2;
        result = (array[indLeft] + array[indRight]+.0) / 2;
    }
    else result = array[array.Length / 2];
    return result;
}
try
{
    Console.WriteLine(Mediana()+" - медиана");
}
catch
{
    Console.WriteLine("error");
}


// сортирует массив от меньшего к большему

// string sortFromMinToMax(int minInd = 0,int curInd = 0,int temp = 0)
// {
//         for (minInd = 0; minInd < array.Length; minInd++)
//     {
//         for (curInd = 0; curInd < array.Length; curInd++)
//         {
//             if (array[curInd] > array[minInd])
//             {
//                 temp = array[minInd];
//                 array[minInd] = array[curInd];
//                 array[curInd] = temp;
//             }
//         }
//     }
//     // вывод на экран массива
//     int ind = 0;
//     string result = "";
//     for (ind = 0; ind < L; ind++)
//     {
//         result = result + array[ind] + " ";
//     }
//     return result;
// }
// try
// {
//     Console.WriteLine(sortFromMinToMax()+" - отсортированный массив от меньшего к большему");
// }
// catch
// {
//     Console.WriteLine("error");
// }

