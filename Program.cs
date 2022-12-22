// написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string [] array = new string[size];
Console.WriteLine("Введите элементы массива:");
for (int i = 0; i < array.Length; i++)
{
    string txt = Console.ReadLine();
    array[i] = txt;
}
SortingArray(array, size);
string [] array2 = SortingArray(array, size);


string [] SortingArray(string [] arr1, int s) 
{
    string [] arr2 = new string[s];  // создаем массив и включаем в него строки не более 3 символов
    int j = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length < 4)
        {
            arr2[j] = arr1[i];
            j++;
        }
    }
    string [] arr3 = new string [j];  // создаем 3 массив по размеру соответсвующему количеству найденных элементов
    int l = 0;
    for (int k = 0; k < j; k++)
    {
        arr3[l] = arr2[k];
        l++;
    }
    return arr3;
}
