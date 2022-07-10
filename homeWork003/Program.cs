int[] array  = { 3 ,7 , 22 , 2 , 78}; 
int minimal = array[0];
int maximal = array[1];
if (array[0] < array[1]) 
{
    minimal = array[0];
    maximal = array[1];
}    
else
{
    minimal = array[1];
    maximal = array[0];
}
for (int i = 2 ; i < array.Length; i++)
{
    if (array[i] > maximal) 
    {
        maximal = array[i];
    } 
    if (array[i] < minimal)
    {
        minimal = array[i];
    }
}
Console.WriteLine();
Console.WriteLine(" разница составляет : " + ( maximal - minimal ) );