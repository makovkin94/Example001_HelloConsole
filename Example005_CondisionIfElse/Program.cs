Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "пупа")
{
    Console.WriteLine("Ура это же Пупа");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}