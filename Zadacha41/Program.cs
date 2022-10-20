// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел вы хотите ввести?"); // ввод размера массива
int M = int.Parse(Console.ReadLine());
int [] array = new int[M];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i}-ое число: "); // последовательный ввод элементов массива
    array[i] = int.Parse(Console.ReadLine());
}
void Print (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < (array.Length - 1))
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }   
    }
}
Console.Write("Введенные числа: "); Print(array); Console.WriteLine();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
        if (array[i] > 0)
        {
            count = count + 1;
        }

}
Console.WriteLine($"Среди введенных чисел {count} > 0");