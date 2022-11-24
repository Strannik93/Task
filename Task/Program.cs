string[] NewArrayMaxLength (string[] array, int maxStringLen)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxStringLen) count++;
    }
    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxStringLen)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray (string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write(array[i] + "; ");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

int maxLength = 3;
// string[] array = {"hello", "2", "world", ":-)"};
// string[] array = {"1234", "1567", "-2", "computer science"};
string[] array = {"Russia", "Denmark", "Kazan"};
PrintArray(array);
string[] newArray = NewArrayMaxLength(array,maxLength);
PrintArray(newArray);