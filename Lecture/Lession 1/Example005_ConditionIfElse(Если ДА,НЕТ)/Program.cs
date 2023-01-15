Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура это же МАША!");
}
else
{
    // Console.WriteLine("Привет,пользователь"); - можно так

    Console.Write("Привет "); // а можно 
    Console.WriteLine(username); // вот так
}