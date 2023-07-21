void FillArray(int[] array, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    int length = array.Length;
    int index = 0;
    while(index<length)
    {
        array[index]=new Random().Next(minValue,maxValue);
        index++;
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while(position<count)
    {
        Console.Write(array[position] + " ");
        position++;
    }
}

void Task34()
{
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers, 100, 1000);
    PrintArray(numbers);
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (numbers[i]%2 == 0) count += 1;
    }
    Console.WriteLine($"Количество чётных элементов в массиве: {count}");
}
void Task36()
{
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 != 0) sum += numbers[i];
    }
    Console.WriteLine($"Сумма элементов с нечётными индексами: {sum}");
}


 void Task38()
 {
    float[] floatArray = new float[6];
    int i=0;
    int length = floatArray.Length;
    while(i<length)
    {
        floatArray[i] = new Random().Next(-1000,1000) / 100.0f;
        Console.Write(floatArray[i].ToString("F2") + " ");
        i++;
    }
    float maxValue = floatArray[0];
    for (i = 0; i < floatArray.Length; i++)
    {
        if (floatArray[i]>maxValue) maxValue=floatArray[i];
    }
    float minValue = floatArray[0];
    for (i = 0; i < floatArray.Length; i++)
    {
        if (floatArray[i]<minValue) minValue=floatArray[i];
    }
    float diff = maxValue-minValue;
    Console.WriteLine($"Разница между максимальным и минимальным элементами: {diff}");
    
 }
Task38();

