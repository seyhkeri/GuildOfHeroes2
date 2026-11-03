// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);

// Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

// yaroslav.TakeDamage(25);
// anastasia.TakeDamage(30);

// Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

// yaroslav.TakeDamage(-20);
// Console.WriteLine($"После неверного урона: {yaroslav.Health}");

// artem.TakeDamage(200);
// Console.WriteLine($"После сильного урона, Артём: {artem.Health}");

// yaroslav.Heal(10);
// yaroslav.GainExperience(40);
// yaroslav.GainExperience(25);

// Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
// Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");

// bool yaroslavAlive = yaroslav.IsAlive();
// Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
// Console.WriteLine($"Артём жив: {artem.IsAlive()}");

// if (yaroslavAlive) {
//     Console.WriteLine("Ярослав может продолжать приключение.");
// } else {
//     Console.WriteLine("Ярослав больше не может сражаться.");
// }

// string info = yaroslav.GetInfo();
// Console.WriteLine("Строка получена. Сейчас выведем её:");
// Console.WriteLine(info);

// Console.WriteLine();
// Console.WriteLine(anastasia.GetInfo());
// Console.WriteLine();
// Console.WriteLine(artem.GetInfo());

Game persona = new Game("Persona 3 Reload", "JRPG");
Game zelda = new Game("The Legend Of Zelda: Breath Of The Wild", "Cool");
Game gta = new Game("GTA VI", "Action");

persona.ReleaseYear = 2022;
persona.Rating = 10.0;

zelda.ReleaseYear = 2018;
zelda.Rating = 10.0;

gta.ReleaseYear = 2026;
gta.Rating = 10.0;

Console.WriteLine("До изменений");
Console.WriteLine($"Игра: {persona.Title}, Рейтинг: {persona.Rating}");
Console.WriteLine($"Игра: {zelda.Title}, Рейтинг: {zelda.Rating}");

persona.UpdateRating(9.5);

zelda.UpdateRating(15.0);

Console.WriteLine("\nПосле Вызовов Методов");
Console.WriteLine($"Игра: {persona.Title}, Рейтинг (изменился): {persona.Rating}");
Console.WriteLine($"Игра: {zelda.Title}, Рейтинг (остался прежним): {zelda.Rating}");

Console.WriteLine("Игра 1");
Console.WriteLine($"Название: {persona.Title}");
Console.WriteLine($"Жанр: {persona.Genre}");
Console.WriteLine($"Год выхода: {persona.ReleaseYear}");
Console.WriteLine($"Рейтинг: {persona.Rating}");

Console.WriteLine();

Console.WriteLine("Игра 2");
Console.WriteLine($"Название: {zelda.Title}");
Console.WriteLine($"Жанр: {zelda.Genre}");
Console.WriteLine($"Год выхода: {zelda.ReleaseYear}");
Console.WriteLine($"Рейтинг: {zelda.Rating}");

Console.WriteLine();

Console.WriteLine("Игра 3");
Console.WriteLine($"Название: {gta.Title}");
Console.WriteLine($"Жанр: {gta.Genre}");
Console.WriteLine($"Год выхода: {gta.ReleaseYear}");
Console.WriteLine($"Рейтинг: {gta.Rating}");