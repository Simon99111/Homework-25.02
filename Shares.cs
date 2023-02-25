public class Shares
{
    public static int Size(string msg) //Определяем размер массива
    {
        Console.Write(msg);
        int n = Convert.ToInt32(Console.ReadLine());
        return n;
    }

    public static int[] Array(int size) //Заполняем массив случайными трехзначными числами
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(100, 1000);
            Console.Write(array[i] + " ");
        }
        return array;
    }

    public static int[] ArrayRandom(int sizeRandom) //Заполняем массив случайными числами от 1 до 100
    {
        int[] array = new int[sizeRandom];
        for (int i = 0; i < sizeRandom; i++)
        {
            array[i] = new Random().Next(1, 100);
            Console.Write(array[i] + " ");
        }
        return array;
    }

    public static int col(int[] NewArray) //Определяем количество четных элементов
    {
        int a = 0;
        for (int i = 0; i < NewArray.Length; i++)
        {
            if (NewArray[i] % 2 == 0) a = a + 1;
        }
        return a;
    }

    public static int sum(int[] NewArray) //Определяем количество четных элементов
    {
        int a = 0;
        for (int i = 1; i < NewArray.Length; i = i + 2)
        {
            a = a + NewArray[i];
        }
        return a;
    }

    public static int maxElement(int[] NewArray) //Определяем максимальный элемент
    {
        int MaxE = NewArray[0];
        for (int i = 1; i < NewArray.Length; i++)
        {
            if (MaxE < NewArray[i]) MaxE = NewArray[i];
        }
        return MaxE;
    }

    public static int minElement(int[] NewArray) //Определяем минимальный элемент
    {
        int MinE = NewArray[0];
        for (int i = 1; i < NewArray.Length; i++)
        {
            if (MinE > NewArray[i]) MinE = NewArray[i];
        }
        return MinE;
    }

}