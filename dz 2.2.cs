// программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("введите ваше число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber/100<1)
{
    Console.WriteLine("третьей цифры нет");
    return;
}
int numS = userNumber;
while (numS/100 >= 10)
{
    numS= numS/10;
}
int numShows = numS% 10;
Console.WriteLine($"{numShows}");