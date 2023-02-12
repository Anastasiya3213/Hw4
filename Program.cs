//ДЗ 4
/*
Задача 25:
Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
ToDegree(numberA, numberB);


void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

/*
Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
/*
int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}
*/

/*
Задача 29: 
Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
*/
/*
int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/












//Напишите программу, которая принимает на вход число (А) 
//и выдаёт сумму чисел от 1 до А.
/*
int GetSum(int num)
{
    int sum =0;
    
    for(int current = 1; current <=num; current++)
    sum += current; 

    return sum;
}
Console.Write("Input a posititve number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = GetSum(a);
Console.WriteLine($"Sum of elements from 1 to {a} is {result}"); */


//Напишите программу, которая принимает 
//на вход число и выдаёт количество цифр в числе.  

/*
int DigitCount(int number)
{
    int count = 0;
    while(number!=0)
    {
        count++;
        number /= 10;
    }
    return count;
}
Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number of digits is: " + DigitCount(num));
*/

//Напишите программу, 
//которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Factorial(int number)
{
    int result = 1;
    for(int i = 1; i <= number; i++)
        result*= i;
    return result;
}
Console.Write("Enter number N :");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Factorial is: " + Factorial(numN));*/

//МАССИВЫ
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
   
    for(int i = 0; i <size; i++)
        array[i] = new Random().Next(minValue, maxValue +1);

return array;
} 
не работает
*/
/*
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
не работает */