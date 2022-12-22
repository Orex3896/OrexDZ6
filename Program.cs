/* Задача через массив
int[] CreateArray(int size)// размер массива
{
    int[] array = new int[size]; //выделили память
    for(int i = 0;i<size;i++)
    {
        array[i]= Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
//выводим массив

void ShowArray(int[] array)
{
    for(int i =0;i<array.Length; i++)
    {
        Console.WriteLine($"{i+1} element is {array[i]}");
    }
}
int KolVoNull(int[] array)
{   
    int kolvo=0;
    for( int i=0;i<array.Length;i++)
    if(array[i]==0)
    kolvo+=1;
    return kolvo;
}

Console.Write("Input a number of elements ");
int length = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateArray(length);
ShowArray(myArray);
int result = KolVoNull(myArray);
Console.WriteLine($"Колличество нулей = {result}");*/

//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int KolVoBolheNull(int n)
{
    int kolvo=0;
   
    for(int i=0; i<n;i++)
    {
        Console.WriteLine("Введите элемент");
        int k=  Convert.ToInt32(Console.ReadLine());
        if(k>0)
        kolvo+=1;
    }
    return kolvo;
}
Console.WriteLine("Введите кол-во элементов");
int num = Convert.ToInt32(Console.ReadLine());
int result = KolVoBolheNull(num);
Console.WriteLine($"Кол-во элементов >0 = {result}");
*/
/*
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 
//и k2 задаются пользователем.
double[] TochkaPeresecheniyaPryamix(double k1,double b1, double k2, double b2)//Создали одномерный массив
{ 
    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;

    double[] coordinatiArray = new double[2];
    coordinatiArray[0] = y;
    coordinatiArray[1] = x;
    return coordinatiArray;
}

Console.WriteLine("введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if(k1 == k2 && b1 == b2)//проверка на совпадение прямых
    Console.WriteLine("Прямые совпадают");

else 
    if(k1 == k2)//проверка на параллельность прямых
    Console.WriteLine("Линии параллельны");

else
{
    double[] tochka = TochkaPeresecheniyaPryamix(k1, b1, k2, b2);
    Console.WriteLine( $"Coordinates of intersection point is ({tochka[0]}: {tochka[1]})");
}
*/