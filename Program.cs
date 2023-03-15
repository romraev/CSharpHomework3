// Подготовил Раевский Р.Ю.

// Task 19.

// bool Palindrom(int N)
// {
//     int count = 10;
//     int num = N;
//     while ((num / 10) > 9)
//     {
//         num = num / 10;
//         count = count * 10;
//     }
//     while (count > 0)
//     {
//         if (N / count == N % 10)
//         {
//             N = (N % count) / 10;
//             count = count/100;
//         }
//         else return false;
//     }
//     return true;
// }

// Console.Write("Hello, friend. Enter your number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 10) Console.WriteLine("Нужно больше цифр!");
// else Console.WriteLine("Это число палиндром? - " + Palindrom(number));

// Task 21.

// double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     return Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
// }

// int EnterCoordinate(string message)
// {
//     Console.Write(message);
//     int number = Convert.ToInt32(Console.ReadLine()); 
//     return number;
// }

// int x1 = EnterCoordinate("Enter x1: ");
// int y1 = EnterCoordinate("Enter y1: ");
// int z1 = EnterCoordinate("Enter z1: ");
// int x2 = EnterCoordinate("Enter x2: ");
// int y2 = EnterCoordinate("Enter y2: ");
// int z2 = EnterCoordinate("Enter z3: ");

// Console.Write("Distnce equals: " + Distance(x1, y1, z1, x2, y2, z2));

// Task 3.

// void Cube(int N)

// {
//     int count = 1;
//     while (count <= N)
//     {
//         Console.WriteLine(count + " - " + Math.Pow(count, 3));
//         count++;
//     }
// }
// Console.Write("Введите N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Вот таблица предшествующих чисел в кубе:");
// Cube(N);
