// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1



// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = (num /10) % 10;

// Console.WriteLine(result);
 







// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6





Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int num1= num / 100;
int num2= (num % 100) / 10;
int num3 = num % 10;
int result = num3;
Console.WriteLine(result);

if (num < 100)
{
  Console.WriteLine("третьей цифры нет");  
}















// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет




// Console.WriteLine("Введите число");
// int number=Convert.ToInt32(Console.ReadLine());
// if (number==1)
// {
//     Console.WriteLine(" Нет");
// }
// else if (number==2)
// {
//    Console.WriteLine(" Нет"); 
// }
// else if (number==3)
// { 
//    Console.WriteLine(" Нет"); 
// }
// else if (number==4)
// {
//    Console.WriteLine( " Нет");
// }
// else if (number==5)
// {
//    Console.WriteLine(" Нет"); 
// }
// else if (number==6)
// {
//    Console.WriteLine(" Да"); 
// }
// else if (number==7)
// {
//    Console.WriteLine(" Да"); 
// }
// else 
// {
//    Console.WriteLine("Такого дня нет"); 
// }
