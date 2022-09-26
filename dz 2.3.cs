// программа, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
Console.WriteLine("введите ифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day>7)
{
    Console.WriteLine("число не обозночает день недели");
    return;
}
if (day>5)
{
    Console.WriteLine("это выходной, развлекайся :)");
    return;
}
Console.WriteLine("нет, это рабочий день, иди работай :(");