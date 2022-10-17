Итоговая проверочная работа
Задача. Написать програму, которая из имеющегося массива строк формирует массив из строк, длинна которого меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

![Алгоритм](shema.jpg)

Перебираем заданный массив и проверяем длину каждого элемента массива, если он <4 то добавляем этот элемент в новый массив, возвращаем новый массив.

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