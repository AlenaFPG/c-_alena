//Console.WriteLine("Введите число");
//int num = Convert.ToInt32(Console.ReadLine());
//int nume = Convert.ToInt32(Console.ReadLine());
//if( num == nume * nume )
//{
//    Console.Write("да");
//}
//else
//{
//    Console.Write("нет");
//}

Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
string day = ("день");
if(num == 1) 
{
    day = ("понедельник");
}
if(num == 2) 
{
    day = ("вторни");
}
if(num == 3) 
{
    day = ("среда");
}

Console.WriteLine(day);