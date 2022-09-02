Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "алена")
{
    Console.WriteLine("Привет, дорогая Алена");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
