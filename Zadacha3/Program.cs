Console.WriteLine("Введите число от 1 до 7 ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 6)
{
    System.Console.WriteLine("Это будний день");
}
else
{
    Console.WriteLine("Это выходной");
}