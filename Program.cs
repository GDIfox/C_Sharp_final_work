string[] arr_1 = { "Hello", "2", "world", ":-)" };
string[] arr_2 = { "1234", "1567", "-2", "computer science" };
string[] arr_3 = { "Russia", "Denmark", "Kazan" };

int max_simvol = 3;

string[] NewArray(string[] array)
{
    int length = array.Length;
    string[] rez = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= max_simvol)
        {
            rez[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref rez, count);
    return rez;
}
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        // var rezultat = "[" + String.Join(", ", arr) + "]";
        // Console.WriteLine(rezultat);
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}
void Rezult(string[] array)
{
    PrintArray(array);
    string[] FinishArray = NewArray(array);

    PrintArray(FinishArray);
    Console.WriteLine();
}

Rezult(arr_1);
Rezult(arr_2);
Rezult(arr_3);
