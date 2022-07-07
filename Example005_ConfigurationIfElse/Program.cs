Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "александра")
{
    Console.WriteLine("Вот это ДА, сама Александра явила свой лик!");
}
else
{
    Console.Write("Даров, ");
    Console.WriteLine(username);
}