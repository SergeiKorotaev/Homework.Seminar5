int[] FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}
Console.Write("Введите число элеметов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int [number];
FillArrayWithRandom(array);
Console.WriteLine("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));
int sum = 0;
for(int i = 0; i < array.Length; i++)
{
    if(i % 2 != 0)
    {
        sum += array[i];
    }
}
Console.WriteLine($"Сумма элементов на нечетных позициях = {sum}");