/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

/*
void ShowArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write(newArray[i, j] + " ");
        }
    Console.WriteLine("");
    }
}

int[,] RandomArray()
{
    Console.Write("Enter number of rows: ");
    int r = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of collumns: ");
    int c = Convert.ToInt32(Console.ReadLine());
    
    int[,] randomArray = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            randomArray[i,j] = new Random().Next(1, 10);
        }
    }
    ShowArray(randomArray);
    return randomArray;
}

int[,] Sort(int[,] sortArray)
{
    int bank = 0;
    for (int i = 0; i < sortArray.GetLength(0); i++)
    {
        for (int j = 0; j < sortArray.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < sortArray.GetLength(1); k++)
            {
                if (sortArray[i, j] < sortArray[i, k])
                {
                    bank = sortArray[i,k];
                    sortArray[i,k] = sortArray[i, j];
                    sortArray[i, j] = bank;
                }
            }
        }
    }
    return sortArray;
}


int[,] sortArray = RandomArray();
Console.WriteLine("");
Console.WriteLine("Sorted array:");
ShowArray(Sort(sortArray));
*/


/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер 
строки с наименьшей суммой элементов: 1 строка
*/

/*
void ShowArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write(newArray[i, j] + " ");
        }
    Console.WriteLine("");
    }
}

int[,] RandomArray()
{
    Console.Write("Enter number of rows: ");
    int r = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of collumns: ");
    int c = Convert.ToInt32(Console.ReadLine());
    
    int[,] randomArray = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            randomArray[i,j] = new Random().Next(1, 10);
        }
    }
    ShowArray(randomArray);
    return randomArray;
}

int[] Sum(int[,] randomArray)
{
    int [] sum = new int[randomArray.GetLength(0)];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
           sum[i] = sum[i] + randomArray[i,j];
        }
    }
    return sum;
}


int[,] randomArray = RandomArray();
Console.WriteLine("");
int[] summma = Sum(randomArray);

int min = summma[0];
int numberRow = 1;
for (int i = 0; i < summma.Length; i++)
{
    if (min > summma[i])
    {
        min = summma[i];
        numberRow = i+1;
    }
}

Console.WriteLine("Row with min summa of value: " + numberRow);
*/


/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

/*
void ShowArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write(newArray[i, j] + " ");
        }
    Console.WriteLine("");
    }
}

int[,] RandomArray(int r, int c)
{
    int[,] randomArray = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            randomArray[i,j] = new Random().Next(1, 5);
        }
    }
    return randomArray;
}

int[,] MultiMatrix(int[,] randomArray_1, int[,] randomArray_2)
{
    int miscValue = 0;
    int[,] multipleMatrix = new int[randomArray_1.GetLength(0), randomArray_2.GetLength(1)];
    for (int i = 0; i < randomArray_1.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray_2.GetLength(1); j++)
        {
            for (int k = 0; k < randomArray_1.GetLength(1); k++)
            {
                miscValue = miscValue + (randomArray_1[i, k] * randomArray_2[k, j]);

            }
            multipleMatrix[i, j] = miscValue;
            miscValue = 0;
        }
    }
    return multipleMatrix;
}

Console.Write("Enter number of matrix #1 rows: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of matrix #1 collumns (matrix #2 rows): ");
int c1r2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of matrix #2 collumns: ");
int c2 = Convert.ToInt32(Console.ReadLine());

int[,] randomArray_1 = RandomArray(r1, c1r2);
int[,] randomArray_2 = RandomArray(c1r2, c2);
int[,] multipleMatrix = MultiMatrix(randomArray_1, randomArray_2);

Console.WriteLine("Matrix #1");
ShowArray(randomArray_1);
Console.WriteLine("Matrix #2");
ShowArray(randomArray_2);
Console.WriteLine("Multiple Matrix");
ShowArray(multipleMatrix);
*/

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет 
построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


bool Repeat(int[,,] checkArray, int randomVal)
{
    bool boVal = false;
    for (int i = 0; i < checkArray.GetLength(0); i++)
    {
        for (int j = 0; j < checkArray.GetLength(1); j++)
        {
            for (int k = 0; k < checkArray.GetLength(2); k++)
            {
                if (randomVal == checkArray[i, j, k])
                boVal = true;
            }
        }
    }
    return boVal;
}

int[,,] RandomArray()
{
    int randomVal = 0;
    int[,,] randomArray = new int[2,2,2];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            for (int k = 0; k < randomArray.GetLength(2); k++)
            {
                bool boVal = true;
                while (boVal == true)
                {
                randomVal = new Random().Next(10, 21);
                //Console.WriteLine(randomVal);
                boVal = Repeat(randomArray, randomVal);
                }
                randomArray[i, j, k] = randomVal;
            }
        }
    }
    return randomArray;
}


void ShowArray(int[,,] newArray)
{
    for (int i = 0; i < newArray.GetLength(2); i++)
    {
        for (int j = 0; j < newArray.GetLength(0); j++)
        {
            for (int k = 0; k < newArray.GetLength(1); k++)
            {
            Console.Write($"{newArray[j, k, i]}({j},{k},{i})");
            }
            Console.WriteLine("");
        }
    
    }
}


int [,,] matrix3x = RandomArray();
ShowArray(matrix3x);




/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

/*
void ShowArray(int[,] snakeArray)
{
    for (int i = 0; i < snakeArray.GetLength(0); i++)
    {
        for (int j = 0; j < snakeArray.GetLength(1); j++)
        {
            Console.Write(snakeArray[i,j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] Circle(int a, int b, int digit)
{
    int[,] snake = new int[a, b];
    int stepC = 0;
    int stepR = 0;
    int pointRow = 0;
    int pointCol = 0;

//#1
    for (int j = 0; j < snake.GetLength(1)-1; j++)
    {
        digit = digit + 1;
        snake[pointRow, stepC] = digit;
        stepC = stepC + 1;
    }
    pointCol = stepC;
//#2
    for (int j = 0; j < snake.GetLength(0)-1; j++)
    {
        digit = digit + 1;
        snake[stepR, pointCol] = digit;
        stepR = stepR + 1;
    }
    pointRow = stepR;
//#3
    for (int j = 0; j < snake.GetLength(1)-1; j++)
    {
        digit = digit + 1;
        snake[pointRow, stepC] = digit;
        stepC = stepC - 1;
    }
    pointCol = stepC;
//#4
    for (int j = 0; j < snake.GetLength(0)-1; j++)
    {
        digit = digit + 1;
        snake[stepR, pointCol] = digit;
        stepR = stepR - 1;
    }
    pointRow = stepR;
    return snake;
}

int a = 0;
while (a <= 0)
{
Console.Write("Enter size of matrix: ");
a = Convert.ToInt32(Console.ReadLine());
}

int b = a;
int ai = 0, bj = 0;
int[,] snake = new int[a, b];
int digit = 0;

while (a > 0 || b > 0)
{
    int[,] snake2 = new int[a, b];
    if (a == 1 && b == 1)
    {
        snake[ai,bj] = digit + 1;
    }
    else
    snake2 = Circle(a, b, digit);
    
    for (int i = 0; i < snake.GetLength(0); i++)
    {
        for (int j = 0; j < snake.GetLength(1); j++)
        {
            if (snake[i, j] == 0)
                snake[i, j] = snake2[i - ai, j - bj];
        }
    }
    ai++;
    bj++;
    a = a - 2;
    b = b - 2;
    digit = (snake.GetLength(0) * snake.GetLength(1)) - a * b;
}

ShowArray(snake);
*/

