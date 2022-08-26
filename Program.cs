void FormArray3Symbols(string[] InitialArray, string[] FinalArray)
{
    int count = 0;
    for (int i = 0; i < InitialArray.Length; i++)
    {
    if(InitialArray[i].Length <= 3)
        {
        FinalArray[count] = InitialArray[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] InitialArray = new string [] {"1234", "23", "hello", "world", "res", "Russia", "Denmark", "-2"};
string[] FinalArray = new string[InitialArray.Length];
FormArray3Symbols(InitialArray, FinalArray);
PrintArray(FinalArray);

