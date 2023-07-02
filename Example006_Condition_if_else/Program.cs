Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "fedor")
{
    Console.WriteLine("Ура, это же Fedor!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}