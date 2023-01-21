int[] FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
Console.Write("Введите число элеметов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int [number];
FillArrayWithRandom(array);
Console.WriteLine("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Колличество четных элементов в массиве = {count}");