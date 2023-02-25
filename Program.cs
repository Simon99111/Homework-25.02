int Size (string msg) //Определяем размер массива
{
    Console.Write(msg);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}


int [] Array (int size) //Заполняем массив случайными трехзначными числами
{
    int [] array = new int [size];
    for (int i = 0; i<size; i++)
    {
        array [i] = new Random().Next(100, 1000);
        Console.Write (array[i]+ " ");
    }
return array;
}

int col (int [] NewArray) //Определяем количество четных элементов
{
    int a = 0;
    for (int i = 0; i<NewArray.Length; i++)
    {
        if (NewArray[i]%2 == 0) a=a+1;
    }
    return a;
}

int n = Size("Введите размер количество элементов массива ");
int [] Print = Array (n);
int Col = col (Print);
Console.WriteLine ("Количество четных элементов = " + Col);
