
int n = 8;
int [] array = new int [n];
for(int i = 0; i < n; i++)
{
    array [i] = new Random().Next(0, 100);
    Console.Write(array [i] + " ");
}


// ИЛИ ВОТ ТАК:



// int n = 8;
// int [] GenerateArray(int n)
// {
//     int[] array = new int[n];  //создали  array [] array [] array [] array [] array [] array [] array [] array []
//     for(int i = 0; i < n; i++)
//     {
//     array [i] = new Random().Next(0, 100);
//     }
//     return array;
// }


// void PrintArray(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " "); // созданным  (array [] array [] array [] array [] array [] array [] array [] array []) добавили пробел и вывели.
//     }
// }
// int [] array = GenerateArray(n);
// PrintArray(array);


// ИЛИ ВОТ ТАК:


// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] GenerateArray(int n)
// {
//     int[] array = new int[n];
//     for (int i = 0; i < n; i++)
//     {
//         array[i] = new Random().Next(1, 10);
//     }
//     return array;
// }


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// int[] array = GenerateArray(n);
// PrintArray(array);