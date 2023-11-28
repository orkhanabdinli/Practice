bool daxilOl = false;

while (!daxilOl)
{
    Console.WriteLine("Username daxil edin");
    string username = Console.ReadLine();
    Console.WriteLine("Password daxil edin");
    string password = Console.ReadLine();

    if (username == "orkhansab" && password == "orkhan123")
    {
        Console.WriteLine("Her vaxtınız xeyir. Xoş gelmisiniz!");
        daxilOl = true;
    }
    else
    {
        Console.WriteLine("Duzgun username veya password daxil edin.");
    }
}

while (daxilOl)
{
    Console.WriteLine("Istediyiniz emeliyyati secin");
    Console.WriteLine("1) Balansi yoxlamaq");
    Console.WriteLine("2) Balansi artirmaq");
    Console.WriteLine("3) Nagdlasdirma");
    Console.WriteLine("4) Hesabdan cixis");
    int number = Convert.ToInt32(Console.ReadLine());
    int balans = 1000000;

    switch (number)
    {
        case 1:
            Console.WriteLine($"Balans: {balans}");
            break;
        case 2:
            Console.WriteLine("Ne qeder artirmaq isteyirsiniz?");
            int Add = Convert.ToInt32(Console.ReadLine());
            balans += Add;
            Console.WriteLine($"Balans: {balans}");
            break;
        case 3:
            Console.WriteLine("Ne qeder nagdlasdirmaq isteyirsiniz?");
            int Out = Convert.ToInt32(Console.ReadLine());
            balans -= Out;
            Console.WriteLine($"Balans: {balans}");
            break;
        case 4:
            Console.WriteLine("Hesabdan ugurla cixildi.");
            daxilOl = false;
            break;
        default:
            Console.WriteLine("Duzgun emeliyyat secin.");
            break;
    }
}