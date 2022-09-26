// программа, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
Console.WriteLine("введите трёхзначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber/100 < 1)
{
    Console.WriteLine("ошибка, число не трёхзначное");
    return;
}
if (userNumber/100 >= 10)
{
    Console.WriteLine("ошибка, число не трёхзначное");
    return;
}
int numP = userNumber/10;
int showN = numP% 10;
Console.WriteLine($" {showN}");
