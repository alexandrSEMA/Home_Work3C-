System.Console.WriteLine(" Введите число ");
int number = int.Parse(Console.ReadLine()) + 1;
int[] array = new int[1];
for (int i = 1; i < number; i++)
{
    int[] newArray = array;
    array = new int[array.Length+1];
    for (int j = 0; j < newArray.Length; j++)
    {
        array [j] = newArray[j];
    }
    if (i*i*i %5==0)
    {
        array[array.Length] = i * i * i;
    }
    System.Console.WriteLine( i * i * i);
}
for (int i = 0; i < array.Length ; i++)
{
    System.Console.WriteLine(array[i]);
}