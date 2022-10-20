// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями:
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

float [,] array = new float [2, 2];
Console.Write("Введите значение k1: "); array[0, 0] = float.Parse(Console.ReadLine());
Console.Write("Введите значение k2: "); array[1, 0] = float.Parse(Console.ReadLine());
array[0, 1] = -1; //коэфициент при y1
array[1, 1] = -1; //коэфициент при y2
Console.Write("Введите значение b1: "); float b1 = float.Parse(Console.ReadLine());
Console.Write("Введите значение b2: "); float b2 = float.Parse(Console.ReadLine());

// int h = array.GetLength(0); // просто показать, что Я умею печатать двумерный массив
// int w = array.GetLength(1);
// for (int i =0; i < h; i++)
// {
//    for (int j =0; j < w; j++)
//    {
//       Console.Write(array[i, j] + "\t");
//    }
//    Console.WriteLine();
// }

float delta = ((array[0, 0] * array[1, 1])-(array[1, 0] * array[0, 1])); // нахождение главного определителя
float deltaX = (((-b1) * array[0, 1])-((-b2) * array[1, 1])); // нахождение X определителя
float deltaY = (array[0, 0] * (-b2))-(array[1, 0] * (-b1)); // нахождение Y определителя
float x = (deltaX/delta);
float y = (deltaY/delta);
if (delta != 0)
{
    Console.WriteLine("Прямые пересекаются!");
    Console.Write($"b1 = {b1}, k1 = {array[0, 0]}, b2 = {b2}, k2 = {array[1, 0]}, -> ({x}, {y})");
}
if (delta == 0 & deltaX != 0 & deltaY != 0)
{
    Console.WriteLine("Прямые параллельны!");
}
if (delta == deltaX & delta == deltaY)
{
    Console.WriteLine("Прямые совпадают");
}