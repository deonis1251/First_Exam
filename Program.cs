Console.Write("Введите элементы массива через пробел: ");
string[] AddArr = AddArray();
string[] OutArr = new string[AddArr.Length];
LimitLenghtArray(AddArr, OutArr);
PrintArray(OutArr);

//Вводим элементы массива, который будем перебирать 
string[] AddArray()
{
    return Console.ReadLine().Split(" ");
}

//Метод выбора элементов, которые короче 3 элементов, из массива
void LimitLenghtArray(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[j] = array1[i];
        j++;
        }
    }
}

//Печать массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
