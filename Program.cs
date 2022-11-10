using торты;
string bbc = "Выберите параметр торта\n" +
       "----------------------------------\n" +
            "  Форма\n" +
            "  Размер\n" +
            "  Вкус коржей\n" +
            "  Количество коржей\n" +
            "  Глазурь\n" +
            "  Декор\n" +
            "  Конец заказа";
bb.AA(1);
bb.yaebalsenuvrot(bbc, 8);
ConsoleKeyInfo a;
do
{
    Console.Clear();
    Console.WriteLine("Спасибо за заказ, если хотите сделать еще один заказ - нажмите любую клавишу, если нет - введите 0");
    a = Console.ReadKey();
    switch (a.Key)
    {
        case ConsoleKey.D0:
            break;

        default:
            bb.AA(2);
            bb.och();
            bb.yaebalsenuvrot(bbc, 8);
            break;

    }
} while (a.Key != ConsoleKey.D0);
Console.Clear();
Console.WriteLine("Спасибо, что сделали заказ в нашей кондитерской, ждем Ваш заказ еще раз\u263a");