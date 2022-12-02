// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числ

int FindMax(int num)
{
   int first = num /10;
   int second = num%10;
   if (first > second) return first;
   else return second;
}

int random = new Random().Next(10, 100);
int result = FindMax(random);
Console.WriteLine($"The number is {random} and the result is {result}");





// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

bool IsDiv (int number, int firstDiv, int secoundDiv)
{
   if (number%firstDiv == 0 && number %secoundDiv == 0) return true;
   else return false;
}

Console.WriteLine("Write your number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write your first divided: ");
int firstDiv = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write your secounnd divided: ");
int secoundDiv = Convert.ToInt32(Console.ReadLine());


bool boolCheck = IsDiv(number, firstDiv, secoundDiv);

Console.WriteLine(boolCheck);






// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool IsSquare (int firstNum, int secoundNum)
{
   if (firstNum/secoundNum == secoundNum || secoundNum / firstNum == firstNum)
   {
      return true;
   }
   else return false;
}

Console.WriteLine("Write your first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write your secound number: ");
int secoundNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsSquare(firstNumber, secoundNumber));
