string fio = "Чумаченко Михаил"; 
string group = "ИСП-242";          


Console.WriteLine("ПРИВЕТ");


Console.WriteLine($"Разработчик: {fio}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Текущая дата и время: {DateTime.Now}\n");

bool isRunning = true;

while (isRunning){
    Console.WriteLine("МЕНЮ");
    Console.WriteLine("1 — Показать ФИО");
    Console.WriteLine("2 — Показать группу");
    Console.WriteLine("3 — Показать дату");
    Console.WriteLine("4 — Выход");
   

    string choice = Console.ReadLine();
    Console.WriteLine(); 

    switch (choice){
    
        case "1":
            Console.WriteLine($"[ФИО]: {fio}");
            break;
        case "2":
            Console.WriteLine($"[Группа]: {group}");
            break;
        case "3":
            Console.WriteLine($"[Текущая дата и время]: {DateTime.Now}");
            break;
        case "4":
            Console.WriteLine("Выход из программы");
            isRunning = false;
            break;
        default:
            Console.WriteLine("Ошибка: неверный ввод. Пожалуйста, выберите пункт от 1 до 4.");
            break;
    }

    if (isRunning){
    
        Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню...");
        Console.ReadKey();
        Console.Clear();
    }
}