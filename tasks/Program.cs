// // 0
// // Вывести квадрат числа
// int Pow(int t)
// {
//     return t * t;
// }
// int t = 5;
// Console.WriteLine(Pow(t));

// // 1
// // По двум числам проверять, является ли первое квадратом второго
// bool Q(int first, int second)
// {
//     return (first == second * second);
// }
// Console.WriteLine(Q(9, 3));


// //2
// //Даны два числа. Показать большее и меньшее число
// string MaxMin(int first, int second)
// {
//     string res = string.Empty;
//     if (first < second)
//     {
//         res = first.ToString() + " минимальное число; " + second.ToString() + " максимальное число";
//     }
//     else
//     {
//         res = first.ToString() + " максимальное число;  " + second.ToString() + " минимальное число";
//     }
//     return res;
// }
// Console.WriteLine(MaxMin(89,90));


// //3
// //По введенному номеру дня недели вывести его название
// Console.Write("Введите номер дня недели от 1 до 7: ");
// string WeekEnd(string N)
// {
//     string result = string.Empty;
//     if (N == "1")
//     {
//         result = "Понедельник";
//     }
//     if (N == "2")
//     {
//         result = "Вторник";
//     }
//     if (N == "3")
//     {
//         result = "Среда";
//     }
//     if (N == "4")
//     {
//         result = "Четверг";
//     }
//     if (N == "5")
//     {
//         result = "Пятница";
//     }
//     if (N == "6")
//     {
//         result = "Суббота";
//     }
//     if (N == "7")
//     {
//         result = "Воскресенье";
//     }
//     return result;
// }
// Console.WriteLine(WeekEnd(Console.ReadLine()));

// //4
// //Найти максимальное из трех чисел
// int F(int x, int y, int z)
// {
//     return Math.Max(Math.Max(x, y), z);
// }

// Console.WriteLine(F(2, 11, 6));

// // 5
// // Написать программу вычисления значения функции y=f(x)
// double y(double x)
// {
//     return Math.Sin(x);
// }

// Console.WriteLine(y(30));


// //6
// //Выяснить, является ли число четным
// bool Ch(int n)
// {
//     return (n % 2 == 0);
// }
// Console.WriteLine(Ch(4));


// //7 
// //Показать числа от -N до N

// string Gen(int N)
// {
//     string res = string.Empty;
//     for (int m = -N; m <= N; m++)
//     {
//         res+= m.ToString() + " ";
//     }
//     return res;
// }
// Console.WriteLine(Gen(6));

// //8 
// //Показать четные числа от 1 до N
// string Ans(int N)
// {
//     string result = string.Empty;
//     for (int m = 0; m <= N; m++)
//     {
//         if (m % 2 == 0)
//         {
//             result += m.ToString() + " ";
//         }
//     }
//     return result;
// }
// Console.WriteLine(Ans(9));


// //9
// //Показать последнюю цифру трехзначного числа
// int Method(int number)
// {
//     int cif = number % 10; 
//     return cif;
// }
// int res1 = Method(500);
// Console.WriteLine(res1);

// //10
// //Показать вторую цифру трехзначного числа
// int secondC(int abc)
// {
//     int b = (abc % 100) / 10;
//     return b;
// }
// int res2 = secondC(211);
// Console.WriteLine(res2);

// //11
// //Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// int Met(int X)
// {
//     int last = X % 10;
//     int first = X / 10;
//     if (first > last)
//     {
//         return first;
//     }
//     else
//     {
//         return last;
//     }
// }
// int result11 = Met(new Random().Next(10, 100));
// Console.WriteLine(result11);

//12
//Удалить вторую цифру трехзначного числа
// int deleteSecond(int abc)
// {
//     int c = abc % 10;
//     int a = (abc/100)*10;
//     return a+c;
// }
// int res12 = deleteSecond(109);
// Console.WriteLine(res12);

// //13
// // Выяснить, кратно ли число заданному, если нет, вывести остаток
// string Method(int one, int two)
// {
//     string res = String.Empty;
//     int m = two%one;
//     {
//         if (m == 0)
//         {
//             res = "Второе число кратно первому";
//         }
//         else
//         {            
//             res = m.ToString();
//         }
//     }
//     return res;
// }
// string R = Method(10, 17);
// Console.WriteLine(R);

// //14
// //Найти третью цифру числа или сообщить, что ее нет.
// string F(int a)
// {
//     string result = string.Empty;
//     if (a/100 == 0)
//     {
//         result = "Третьей цифры нет";
//     }
//     else
//     {
//         if (a>0)
//         {
//             result = ((a/100)%10).ToString();
//         }
//         else
//         {
//             result = ((a/100)%10*(-1)).ToString();
//         }
//     }
//     return result;
// }
// Console.WriteLine(F(-1353));

// //15
// //Дано число. Проверить, кратно ли оно 7 и 23
// string Z(int number, int a, int b)
// {
//     string res1 = String.Empty;
//     string res2 = String.Empty;
//     if (number % a == 0)
//     {
//         res1 = "Число кратно "+a.ToString();
//     }
//     else
//     {
//         res1 = "Число не кратно "+a.ToString();
//     }
//     if (number % b == 0)
//     {
//         res2 = "Число кратно "+b.ToString();
//     }
//     else
//     {
//         res2 = "Число не кратно "+b.ToString();
//     }
//     return res1+" "+res2;
// }
// string R = Z(46, 7, 23);
// Console.WriteLine(R);

// //16
// //Дано число, обозначающее день недели. Выяснить, является ли номер дня недели выходным днем
// bool weekend2(int day)
// {
//     return ((day == 6) || (day == 7));
// }
// Console.WriteLine(weekend2(4));


// //17
// //По двум данным числам проверять является ли одно квадратом другого
// bool YesNo2(int first, int second)
// {
//     return (first == second * second || second == first * first);
// }
// Console.WriteLine(YesNo2(3,12));

// // 18
// //Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// bool F(bool X, bool Y)
// {
//     return (!(X||Y)) == ((!X) && (!Y));
// }
// Console.WriteLine(F(false, false));

// // 19
// // Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// int R(int X, int Y)
// {
//     int res = 0;
//     if (X > 0 && Y > 0)
//     {
//         res = 1;
//     }
//     if (X < 0 && Y > 0)
//     {
//         res = 2;
//     }
//     if (X < 0 && Y < 0)
//     {
//         res = 3;
//     }
//     if (X > 0 && Y < 0)
//     {
//         res = 4;
//     }

// return res;
// }
// Console.WriteLine(R(-5, -6));

// // 20
// // Задать номер четверти, показать диапазоны для возможных координат
// string D(int N)
// {
//     string res = string.Empty;
//     if (N == 1)
//     {
//         res = "X = (0;infinity); Y = (0;infinity)";
//     }
//     if (N == 2)
//     {
//         res = "X = (-infinity;0); Y = (0;infinity)";

//     }
//     if (N == 3)
//     {
//         res = "X = (-infinity;0); Y = (-infinity;0)";

//     }
//     if (N == 4)
//     {
//         res = "X = (0;infinity); Y = (-infinity;0)";
//     }
//     return res;
// }
// Console.WriteLine(D(3));

// //21
// // Программа проверяет пятизначное число на полиндром
// bool Polin(int r)
// {
//     int a = r % 10;
//     int b = (r%100)/10;
//     int d = (r/1000)%10;
//     int e = r/10000;
//     return (a==e && b==d);
// }
// Console.WriteLine(Polin(54345));


// // 22
// // Найти расстояние между точками в пространстве 2D/3D
// double Distance2D(int xa, int ya, int xb, int yb)
// {
//     return Math.Sqrt(Math.Pow((xa-xb), 2) + Math.Pow((ya-yb), 2));
// }
// Console.WriteLine(Distance2D(5, 5, 3, 3));

// double Distance3D(int xa, int ya, int za, int xb, int yb, int zb)
// {
//     return Math.Sqrt(Math.Pow((xa-xb), 2) + Math.Pow((ya-yb), 2) + Math.Pow((za-zb), 2));
// }
// Console.WriteLine(Distance3D(5, 5, 3, 3, 6, 7));

// //23
// //Показать таблицу квадратов чисел от 1 до N
// String F1(int n)
// {
//     string result = string.Empty;
//     for (int m = 1; m<=n; m++)
//     {
//         result+= $"{m*m}  ";
//     }
//     return result;
// }
// Console.WriteLine(F1(9));

// //24
// //Найти кубы чисел от 1 до N
// String F3(int N)
// {
//     string result = string.Empty;
//     for (int m = 1; m<=N; m++)
//     {
//         result+= $"{m*m*m}  ";
//     }
//     return result;
// }
// Console.WriteLine(F3(9));

// //25
// //Найти сумму чисел от 1 до A
// int Sum(int A)
// {
//     return (A*(A+1)/2);
// }
// Console.WriteLine(Sum(0));

// //26
// //Возведите число A в натуральную степень B используя цикл
// double F (int A, int B)
// {
//     double S = 1;
//     for (int m = 1; m<=B; m++)
//     {
//         S*=A;
//     }
//     return S;
// }
// Console.WriteLine(F(5, 3));

// //27
// //Определить количество цифр в числе
// int F(int number)
// {
//     int digits = 0;
//     while (number > 0)
//     {
//         number = number/10;
//         digits++;
//     }
//     return digits;
// }
// Console.WriteLine(F(6437));

// //28
// //Посчитать сумму цифр в числе
// int Sum(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum += number%10;
//         number = number/10;
//     }
//     return sum;
// }
// Console.WriteLine(Sum(621437));

// //29
// //Написать программу вычисления произведения чисел от 1 до N
// double M(int N)
// {
//     if (N==1) return 1;
//     return N * M(N - 1);

// }
// Console.WriteLine(M(3));

// //30
// //Показать кубы чисел, заканчивающихся на четную цифру
// string Cube(int N)
// {
//     string res = string.Empty;
//     for (int m=1; m<=N; m++)
//     {
//         if (m%2==0)
//         {
//             res += $"{Math.Pow(m, 3)}  ";
//         }
//     }    
//     return res;
// }
// Console.WriteLine(Cube(6));


// //31
// //Задать массив из 8 элементов и вывести их на экран
// int[] array = new int [8];
// string F (int[] array)
// {
//     string res = string.Empty;
//     for (int m=0; m < array.Length; m++)
//     {
//         array[m] = new Random().Next(-10, 10);
//     }
//     for (int m=0; m<array.Length; m++)
//     {
//         res+= $"{array[m]}  ";
//     }
//     return res;
// }
// Console.WriteLine(F(array));

// //32
// //Задать массив из 8 элементов, заполненных нулями и единицами и вывести их на экран
// int[] array = new int [8];
// string F (int[] array)
// {
//     string res = string.Empty;
//     for (int m=0; m < array.Length; m++)
//     {
//         array[m] = new Random().Next(0, 2);
//     }
//     for (int m=0; m<array.Length; m++)
//     {
//         res+= $"{array[m]}  ";
//     }
//     return res;
// }
// Console.WriteLine(F(array));

// //33
// //Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива 
// int[] array = new int [12];
// string F (int[] array)
// {
//     string res = string.Empty;
//     int sum = 0;
//     for (int m=0; m < array.Length; m++)
//     {
//         array[m] = new Random().Next(0, 10);
//     }
//     for (int m=0; m<array.Length; m++)
//     {
//         res+= $"{array[m]}  ";
//         sum+= array[m];
//     }
//     return res + "  " + sum;
// }
// Console.WriteLine(F(array));

// //34
// //Написать программу замены элементов массива на противоположные
// int[] array = new int [10];
// string F (int[] array)
// {
//     string res = string.Empty;
//     for (int m=0; m < array.Length; m++)
//     {
//         array[m] = new Random().Next(-10, 10);
//     }
//     for (int m=0; m<array.Length; m++)
//     {
//         res+= $"{array[m]*(-1)}  ";
//     }
//     return res;
// }
// Console.WriteLine(F(array));

// //35
// //Определить, присутствует ли в заданном массиве некоторое число
// int[] array = new int [10];
// string F(int[] array, int N)
// {
//     string result1 = string.Empty;
//     string result2 = string.Empty;
//     for (int m=0; m < array.Length; m++)
//     {
//         array[m] = new Random().Next(0, 10);
//     }

//     for (int m=0; m < array.Length; m++)
//     {        
//         result1 += $"{array[m]} ";

//     }
//     for (int m=0; m < array.Length; m++)
//     {
//         if (array[m] == N)
//         {
//             result2 = $"/ {array[m]} exists";
//         }              
//     }
//     return result1 + result2;
// }
// Console.WriteLine(F(array, 3));

// //36
// //Задать массив, заполнить случайными положительными трехзначными числами. Показать количество нечетных/четных чисел
// int[] array = new int [20];
// string G (int[] array)
// {
//     string arr = string.Empty;
//     int k = 0;
//     int t = 0;
//     for (int m=0; m < array.Length; m++)
//     {
//         array[m] = new Random().Next(100, 1000);
//     }
//     for (int m=0; m<array.Length; m++)
//     {
//         arr+= $"{array[m]}  ";
//     }
//     for (int m=0; m<array.Length; m++)
//     {
//         if (array[m]%2 == 0)
//         {
//             k++;
//         }
//         else
//         {
//             t++;
//         }
//     }
//     return arr + $"/{t}  /{k}";
// }
// Console.WriteLine(G(array));

// //37
// //В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// int[] array = new int [123];
// string F (int[] array)
// {
//     int k=0;
//     string res = string.Empty;
//     for (int m=0; m < array.Length; m++)
//     {
//         array[m] = new Random().Next(-1000, 1000);
//     }
//     for (int m=0; m < array.Length; m++)
//     {
//         res+= $"{array[m]} ";
//     }
//     for (int m=0; m<array.Length; m++)
//     {
//         if ((array[m]>=10) && (array[m]<=99))
//         {
//             k++;
//         }
//     }
//     return res + $"  /  {k}";
// }
// Console.WriteLine(F(array));

// //38
// //Найти сумму чисел одномерного массива стоящих на нечетных позициях

// int[] array = new int [10];
// string F (int[] array)
// {
//     int sum = 0;
//     string arr = string.Empty;
//     for (int m=0; m < array.Length; m++)
//     {
//         array[m] = new Random().Next(-100, 100);
//     }
//     for (int m=0; m < array.Length; m++)
//     {
//         arr += $"{array[m]} ";
//     }
//     for (int m=0; m<array.Length; m++)
//     {
//         if (m%2 == 0)
//         {
//             sum+= array[m];
//         }
//     }
//     return arr + $" /{sum}";
// }
// Console.WriteLine(F(array));

// //39
// //Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// int[] array = new int [4];
// string F (int[] array)
// {
//     string res1 = string.Empty;
//     string res2 = string.Empty;
//     string res3 = string.Empty;
//     for (int m=0; m < array.Length; m++)
//     {
//         array[m] = new Random().Next(-10, 10);
//     }
//     for (int m=0; m < array.Length; m++)
//     {
//         res1+= $"{array[m]} ";
//     }
//     for (int m=0; m < array.Length/2; m++)
//     {
//         res2+= $"{array[m]*array[array.Length-1-m]} ";
//     }
//     if (array.Length%2 > 0)
//     {
//         res3 = $"{array[(array.Length)/2]}";
//     }

//     return res1 + "    /    " + res2 + res3; 
// }
// Console.WriteLine(F(array));

// //40
// //В указанном масcиве вещественных чисел найти разницу между макс и мин элементом

// double[] array = {12.3, 4.5, 6.5, 12.3, 4.5, 4.1};
// double Diff (double[] array)
// {
//     double res = 0;
//     double max = array[0];
//     double min = array[0];
//     for (int m=0; m < array.Length; m++)
//     {
//         if (array[m]>max)
//         {
//             max = array[m];
//         }
//         if (array[m]<min) 
//         {
//             min = array[m];
//         }
//     res = max - min;
//     }
//     return res;    


// }
// Console.WriteLine(Diff(array));

// //41
// //Выяснить, являются ли три числа сторонами треугольника

// bool YesNo(int a, int b, int c)
// {
//     return ((a< b+c) && (b< a+c) && (c< a+b));

// }
// Console.WriteLine(YesNo(3,4,7));

// //42
// //Определить, сколько чисел больше нуля введено с клавиатуры
// Console.Write("Введите числа: ");
// int[] array = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToArray();
// int Numbers (int[] array)
// {
//     int count = 0;
//     for (int m = 0; m < array.Length; m++)
//     {
//         if (array[m] > 0)
//     {
//         count++;
//     }
//     }
//     return count;

// }
// Console.WriteLine(Numbers(array));

// 43
// Написать программу преобразования десятичного числа в двоичное

// double Transform (int N)
// {
//     int mod = 0;
//     double d = 0;
//     for (int m = 0; N>0; m++)
//     {
//         mod = N%2;
//         N = (N - mod) / 2;
//         d += mod * Math.Pow(10,m);

//     }
//     return d;
// }
// Console.WriteLine(Transform(1234));

// 44
// Найти точку пересечения двух прямых, заданных уравнением y=kx+b, a1 k1 и a2 и k2 заданы
// y=k1*x + b1
// y=k2*x + b2
// x = (b2-b1)/(k1-k2)
// y = (k1*(b2-b1)/(k1-k2))+b1

// string X(int k1, int k2, int b1, int b2)
// {
//     string res = string.Empty;
//     int x = 0;
//     int y = 0;
//     x = (b2-b1)/(k1-k2);
//     y = (k1*(b2-b1)/(k1-k2))+b1;
//     res = $"({x}, {y})";
//     return res;
// }
// Console.WriteLine(X(2, -3, -3, 2));


// // 45
// // Показать числа Фибоначчи

// double Fibonacci(int n)
// {
//     if (n==1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }

// for (int m=1; m < 20; m++)
// {
//     Console.WriteLine($"f({m}) = {Fibonacci(m)}");
// }

// 46
// Написать программу масштабирования фигуры

// (0,0) (2,0) (2,2) (0,2) 

// string Scaling(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, double k)
// {
//     x2 = x2*k;
//     y2 = y2*k;
//     x3 = x3*k;
//     y3 = y3*k;
//     x4 = x4*k;
//     y4 = y4*k;
//     return $"({x1}, {y1}) ({x2}, {y2}) ({x3}, {y3}) ({x4}, {y4})";
// }
// Console.WriteLine(Scaling(0,0, 2,0, 2,2, 0,2, 0.5));

// 47
// Написать программу копирования массива

// int[] array = new int[20];
// string Array(int[] array)
// {
//     string arr = string.Empty;
//     string arr2 = string.Empty;
//     for (int m = 0; m < array.Length; m++)
//     {
//         array[m] = new Random().Next(-100, 100);
//     }
//     for (int m = 0; m < array.Length; m++)
//     {
//         arr += $"{array[m]}  ";
//         arr2 = arr + arr;
//     }
//     return arr2;
// }
// Console.WriteLine(Array(array));

// 48
// Показать двумерный массив размером m×n заполненный целыми числами

// void PrintArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             Console.Write($"{matr[m, n]} ");

//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             matr[m, n] = new Random().Next(1, 10);

//         }
//     }
// }
// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// 49
// Показать двумерный массив размером m×n заполненный вещественными числами
// void PrintArray(double[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             Console.Write($"{matr[m, n]} ");

//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(double[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             matr[m, n] = new Random().NextDouble();

//         }
//     }
// }
// double[,] matrix = new double[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

//50
//В двумерном массиве n×k заменить четные элементы на противоположные

// void PrintArray(int[,] matr)
// {
//     for (int n = 0; n < matr.GetLength(0); n++)
//     {
//         for (int k = 0; k < matr.GetLength(1); k++)
//         {
//             Console.Write($"{matr[n, k]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int n = 0; n < matr.GetLength(0); n++)
//     {
//         for (int k = 0; k < matr.GetLength(1); k++)
//         {
//             matr[n, k] = new Random().Next(1, 10);
//         }
//     }
// }
// void ReplaceArray(int[,] matr)
// {
//     for (int n = 0; n < matr.GetLength(0); n++)
//     {
//         for (int k = 0; k < matr.GetLength(1); k++)
//         {
//             if (matr[n, k] % 2 == 0) 
//             {
//                 matr[n, k] = -matr[n, k];
//             }
//         }
//     }
// }
// int[,] matrix = new int[3, 4];

// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// ReplaceArray(matrix);
// PrintArray(matrix);



//51
//Задать двумерный массив следующим правилом: Aₘₙ = m+n
// void PrintArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             Console.Write($"{matr[m, n]} ");

//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             matr[m, n] = m+n;

//         }
//     }
// }
// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// 52
// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

// void PrintArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             Console.Write($"{matr[m, n]} ");

//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             matr[m, n] = new Random().Next(0, 100);

//         }
//     }
// }

// void Replace(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             if ((m % 2 == 0) && (n % 2 == 0))
//             {
//                 matr[m, n] = matr[m, n] * matr[m, n];
//             }
//             Console.Write($"{matr[m, n]} ");

//         }
//         Console.WriteLine();
//     }
// }

// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);
// Console.WriteLine();
// Replace(matrix);

//53
// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
// void PrintArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             Console.Write($"{matr[m, n]} ");

//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             matr[m, n] = new Random().Next(1, 10);

//         }
//     }
// }

// int N = Convert.ToInt32(Console.ReadLine());
// string Show(int[,] matr)
// {
//     string res = string.Empty;
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             if (matr[m, n] == N)
//             {
//                 res += $"({m}, {n})";
//             }
//         }
//     }
//     if (res == string.Empty) res = "Такого элемента нет";
//     return res;
// }
// int[,] matrix = new int[3, 4];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// Console.WriteLine(Show(matrix));

// 54
// В матрице чисел найти сумму элементов главной диагонали

// void PrintArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             Console.Write($"{matr[m, n]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             matr[m, n] = new Random().Next(1, 10);
//         }
//     }
// }
// int Sum (int[,] matr)
// {
//     int sum = 0;
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             if (m==n) sum += matr[m,n];
//         }
//     }
//     return sum;

// }
// int[,] matrix = new int[4, 4];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// Console.WriteLine(Sum(matrix));

// 55
// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
// void PrintArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             Console.Write($"{matr[m, n]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             matr[m, n] = new Random().Next(1, 10);
//         }
//     }
// }
// string ArithmeticMean(int[,] matr)
// {
//     string result = string.Empty;

//     for (int n = 0; n < matr.GetLength(1); n++)
//     {
//         int sum = 0;
//         int count = 0;
//         double mean = 0;
//         for (int m = 0; m < matr.GetLength(0); m++)
//         {
//             sum += matr[m, n];
//             count++;
//         }
//         mean = sum / count;
//         result += mean.ToString() + " ";
//     }
//     return result;
// }
// int[,] matrix = new int[4, 4];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// Console.WriteLine(ArithmeticMean(matrix));

// 56
// Написать программу, которая обменивает элементы первой строки и последней строки
// void PrintArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             Console.Write($"{matr[m, n]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             matr[m, n] = new Random().Next(1, 10);
//         }
//     }
// }
// void Replace(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             int save = matr[0, n];
//             matr[0, n] = matr[matr.GetLength(0)-1, n];
//             matr[matr.GetLength(0)-1, n] = save;

//             Console.Write($"{matr[m, n]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] matrix = new int[3, 4];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// Replace(matrix);

// 57
// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива
// void PrintArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             Console.Write($"{matr[m, n]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             matr[m, n] = new Random().Next(1, 10);
//         }
//     }
// }
// void Ordering(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             for (int k = 0; k < matr.GetLength(1) - n - 1; k++)
//             {
//                 if (matr[m, k] < matr[m, k + 1])
//                 {
//                     int t = matr[m, k];
//                     matr[m, k] = matr[m, k + 1];
//                     matr[m, k + 1] = t;

//                 }
//             }
//         }
//     }
// }

// int[,] matrix = new int[3, 4];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// Ordering(matrix);
// PrintArray(matrix);

// 58
// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно
// void PrintArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             Console.Write($"{matr[m, n]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             matr[m, n] = new Random().Next(1, 10);
//         }
//     }
// }
// void Ordering(int[,] matr)
// {
//     if (matr.GetLength(0) == matr.GetLength(1))
//     {
//         int[,] nums = new int[matr.GetLength(0), matr.GetLength(1)];
//         for (int m = 0; m < matr.GetLength(0); m++)
//         {
//             for (int n = 0; n < matr.GetLength(1); n++)
//             {
//                 nums[m, n] = matr[m, n];
//             }
//         }
//         for (int m = 0; m < matr.GetLength(0); m++)
//         {
//             for (int n = 0; n < matr.GetLength(1); n++)
//             {
//                 matr[m, n] = nums[n, m];
//             }
//         }
//     }
//     else
//     {
//         Console.WriteLine("Матрица непрямоугольная");
//     }
// }
// int[,] matrix = new int[4, 4];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// Ordering(matrix);
// PrintArray(matrix);


// 59
// В прямоугольной матрице найти строку с наименьшей суммой элементов.
// void PrintArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             Console.Write($"{matr[m, n]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             matr[m, n] = new Random().Next(1, 10);
//         }
//     }
// }
// string MinSum(int[,] matr)
// {
//     string result = string.Empty;
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         int sum = 0;

//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             sum += matr[m, n];

//         }
//         result += $"{sum} ";
//     }
//     return result;
// }
// int[,] matrix = new int[4, 4];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// Console.WriteLine(MinSum(matrix));

// 66
// Показать натуральные числа от 1 до N, N задано
// string K(int n)
// {
//     if (n==1) return "1";
//     else return $"{K(n - 1)} {n}";
// }
// Console.WriteLine(K(7));


// 67
// Показать натуральные числа от N до 1, N задано
// string Natur(int N)
// {
//     if (N==1) return "1";
//     else return $"{N} {Natur(N - 1)}";
// }
// Console.WriteLine(Natur(6));

// 68
// Показать натуральные числа от M до N, N и M заданы
// string MN(int m, int n)
// {
//     if (n==m) return $"{n}";
//     else return $"{m} {MN(m+1,n)}";
// }
// Console.WriteLine(MN(1,6));

// 69
// Найти сумму элементов от M до N, N и M заданы
// int MN(int m, int n)
// {
//     if (n == m) return n;
//     else return m + MN(m + 1, n);
// }
// Console.WriteLine(MN(1, 6));

// 70
// Найти сумму цифр числа
// int Sum(int a)
// {
//     if (a == 0) return 0;
//     return a % 10 + Sum(a/10);
// }
// Console.WriteLine(Sum(345));

// 71
// Написать программу вычисления функции Аккермана
// int Ack(int m, int n)
// {
//     if (m>6 || n>6 || m<0 || n<0) return -1;
    
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0)
//     {
//         return Ack(m - 1, 1);
//     }
//     else
//     {
//         return Ack(m - 1, Ack(m, n - 1));
//     }
// }
// Console.WriteLine(Ack(1, 3));


// 72
// Написать программу возведения числа А в целую стень B
// int Degree (int a, int b)
// {
//     if (b==0) return 1;
//     return a*Degree(a, b-1);
// }
// Console.WriteLine(Degree(3, 3));

// 73
// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем.

// string Fib(int a, int b)
// {
//     if ((a + b) > 30000) return $"{a + b}";
//     return $" {a + Fib(b, b + a)}";
// }
// Console.WriteLine(Fib(2, 4));

// 74
// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита
int n =1;
void Words(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}");
        return;
    }
    for (int i = 0; i<alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        Words(alphabet, word, length + 1);
    }
}
Words("аисв", new char[3]);
