string[] CreateArrayFromArr(string[] array)
{
    int count = 0;
    string[] result = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            result[count] = array[i];
            count ++;
        }
    }
    Array.Resize(ref result, count);
    return result;
}