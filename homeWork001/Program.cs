Console.WriteLine("Введите количество трехзначных чисел");
int number = Convert.ToInt32(Console.ReadLine());
int [] array = new int[number] ;
int length = array.Length;
int count = 0;
Console.Write("[");
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write(array[i] + " ");
    if ( array[i] % 2 == 0)
    {
        count += + 1;
    }
}
Console.Write("]");
Console.WriteLine();
Console.WriteLine($"количество четных чисел равно : {count}");