// See https://aka.ms/new-console-template for more information
using DatabaseUsage.Config;
using DatabaseUsage.Models;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
List<FootballPlayer> players = new List<FootballPlayer>();
Console.WriteLine("Добро пожаловать в статистическую программу, отображающую всякую дичь\nПожалуйста, нажмите любую кнопку для формирования тестовой таблицы из 10 игроков национальной футбольной лиги, а так же создания её SQL-вариата.:");
Console.ReadKey();
using (PlayersContext playersdatabase = new PlayersContext()) 
{ 
    players = playersdatabase.FootballPlayers.ToList();
}
DisplayPlayers();
Console.WriteLine("Нажмите любую кнопку, чтобы добавить в список легендарного Дэна Марино!(того самого из Эйс Вентуры)");
Console.ReadKey();
using (PlayersContext playersdatabase = new PlayersContext())
{
    playersdatabase.FootballPlayers.Add(new FootballPlayer(11, "Dan", "Marino", "Quarterback", "Dolphins", 61, 3497, 0, -3));
    playersdatabase.SaveChanges();
}
Console.WriteLine("Спаситель \"снежка\" успешно добавлен! Нажмите любую кнопку, чтобы увидеть отсортированный список по общему числу ярдов");
Console.ReadKey();
using (PlayersContext playersdatabase = new PlayersContext())
{
    playersdatabase.FootballPlayers.Add(new FootballPlayer(11, "Dan", "Marino", "Quarterback", "Dolphins", 61, 3497, 0, -3));
    playersdatabase.SaveChanges();
    players = playersdatabase.FootballPlayers.ToList().OrderByDescending(x => x.ScrimmageYards).ThenBy(x => x.Age).ToList();
}
DisplayPlayers();
Console.ReadKey();
Console.WriteLine("Теперь нажмите кнопку, чтобы вывести на экран группировку по позиции, а внутри групп отсортировать игроков по имени");
Console.ReadKey();
var playerGroups = players.GroupBy(x => x.Position);
foreach(var group in playerGroups)
{
    Console.WriteLine($"----------Позиция на поле: {group.Key}");
    var sortedGroup = group.OrderBy(x => x.Name);
    foreach(var player in sortedGroup)
    {
        Console.WriteLine($"{player.Name} {player.Surname} Команда: {player.Team}");
    }
    Console.WriteLine("\n");
}
Console.WriteLine("Демонстрация приложения завершена! Нажмите любую кнопку для выхода из приложения!");
Console.ReadKey();

void DisplayPlayers()
{
    foreach (FootballPlayer player in players)
    {
        Console.WriteLine($"Игрок номер {player.Id}:{player.Name} {player.Surname}, Позиция: {player.Position}, Команда: {player.Team}\n" +
            $"Пасовые ярды: {player.PassingYards}, Ярды на приёме:{player.ReceivingYards}, Выносные ярды: {player.RushingYards}, Общие(scrimmage) ярды:{player.ScrimmageYards}\n");
    }
}

