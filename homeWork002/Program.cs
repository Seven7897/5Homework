Console.WriteLine("задайте длину массива : ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0 ;
int [] array = new int [number];
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100 , 101);
    Console.Write(array[i] + " ");
    if ( i % 2 != 0)
        {
            result += array[i];
        }
}
Console.Write("]");
Console.WriteLine("result = " + result );
