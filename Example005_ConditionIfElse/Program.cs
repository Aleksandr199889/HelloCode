Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, как же я скучал МАША, теперь мы снова можем кидать друзей, как крысы!");
}
else
{
    if(username.ToLower() == "даньчик")
    {
        Console.WriteLine("Не слушай братан, я тебя ни на кого не променяю! Ты же мой друг... Лучший друг!");
    }
    else
    {
        Console.Write("Привет, ");
        Console.WriteLine(username);
    }
}