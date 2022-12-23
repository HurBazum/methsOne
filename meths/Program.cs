(string name, int age,string[] favcolors) user = ("", 0,new string[3]);
Console.Write("Введите имя: ");
user.name = Console.ReadLine();
Console.Write("\nВведите возраст: ");
user.age = int.Parse(Console.ReadLine());

for(int i = 0; i < user.favcolors.Length; i++)
{
    user.favcolors[i] = ShowColors(user.name, user.age, i);
}

foreach(string color in user.favcolors)
{
    Console.WriteLine(color);
}

static string ShowColors(string str, int a, int counter)
{
    string color = "";
    Console.WriteLine($"{str}, введите свой любимый цвет по английски с маленькой буквы: ");
    color = Console.ReadLine();
    switch (color)
    {
        case "red":
        case "green":
        case "cyan":
            char[] c = color.ToCharArray();
            c[0] = char.ToUpper(c[0]);
            color = String.Join("", c);
            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
            Console.ForegroundColor = default;
            Console.WriteLine($"{str}, {a} лет\nВаш любимый цвет #{counter} - {color}");
            break;
        default:
            color = "Yellow))";
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = default;
            Console.WriteLine($"{str}, {a} лет\nВаш любимый цвет #{counter} - {color}");
            break;
    }
    Console.ResetColor();
    return color;
}