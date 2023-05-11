

using TemperatureConversion;

int choice;
do
{
    Console.WriteLine("1 Метод, принимающий значение температуры в градусах Цельсия и возвращающий его эквивалент в градусах Фаренгейта");
    Console.WriteLine("2 Метод, принимающий значение температуры в градусах Фаренгейта и возвращающий его эквивалент в градусах Цельсия");
    Console.WriteLine("3 Метод, принимающий значение температуры в градусах Цельсия и возвращающий его эквивалент в Кельвинах");
    Console.WriteLine("4 Метод, принимающий значение температуры в Кельвинах и возвращающий его эквивалент в градусах Цельсия");
    Console.WriteLine("5 Метод, принимающий значение температуры в градусах Фаренгейта и возвращающий его эквивалент в Кельвинах");
    Console.WriteLine("6 Метод, принимающий значение температуры в Кельвинах и возвращающий его эквивалент в градусах Фаренгейта");
    Console.WriteLine("0 - выход");
    Console.Write("Введите команду: ");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            TemperatureConverter person = new TemperatureConverter();
            Console.Write("Введите градусы Цельсия: ");

            double age;
            if (double.TryParse(Console.ReadLine(), out age))
            {
                person.CelsiusToFahrenheit = age;
            }
            else
            {
                Console.WriteLine("Неверный формат ");
            }
            Console.WriteLine(person.CelsiusToFahrenheit);
            break;
        case 2:
            TemperatureConverter person1 = new TemperatureConverter();
            Console.Write("Введите градусы Фарингейта: ");

            double age1;
            if (double.TryParse(Console.ReadLine(), out age1))
            {
                person1.FahrenheitToCelsius = age1;
            }
            else
            {
                Console.WriteLine("Неверный формат ");
            }
            Console.WriteLine(person1.FahrenheitToCelsius);
            break;
        case 3:
            TemperatureConverter person2 = new TemperatureConverter();
            Console.Write("Введите градусы Цельсия: ");

            double age2;
            if (double.TryParse(Console.ReadLine(), out age2))
            {
                person2.CelsiusToKelvin = age2;
            }
            else
            {
                Console.WriteLine("Неверный формат ");
            }
            Console.WriteLine(person2.CelsiusToKelvin);
            break;
        case 4:
            TemperatureConverter person3 = new TemperatureConverter();
            Console.Write("Введите градусы Кельвина: ");

            double age3;
            if (double.TryParse(Console.ReadLine(), out age3))
            {
                person3.CelsiusToKelvin = age3;
            }
            else
            {
                Console.WriteLine("Неверный формат ");
            }
            Console.WriteLine(person3.KelvinToCelsius);
            break;
            case 5:
            TemperatureConverter person4 = new TemperatureConverter();
            Console.Write("Введите градусы фарингейта: ");

            double age4;
            if (double.TryParse(Console.ReadLine(), out age4))
            {
                person4.CelsiusToKelvin = age4;
            }
            else
            {
                Console.WriteLine("Неверный формат ");
            }
            Console.WriteLine(person4.FahrenheitToKelvin);
            break;
            case 6:

            TemperatureConverter person5 = new TemperatureConverter();
            Console.Write("Введите градусы Кельвина: ");

            double age5;
            if (double.TryParse(Console.ReadLine(), out age5))
            {
                person5.CelsiusToKelvin = age5;
            }
            else
            {
                Console.WriteLine("Неверный формат ");
            }
            Console.WriteLine(person5.KelvinToFahrenheit);
            break;
        case 0:
            Console.WriteLine("Выход из программы...");
            break;
        default:
            Console.WriteLine("Неверный ввод, попробуйте снова.");
            break;
    }
} while (choice != 0);



