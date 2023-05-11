
//Создайте пространство имен "TemperatureConversion", в котором определите статический класс "TemperatureConverter" для конвертации температуры между шкалами Цельсия, Фаренгейта и Кельвина.

//В классе "TemperatureConverter" определите следующие статические методы:

//CelsiusToFahrenheit - метод, принимающий значение температуры в градусах Цельсия и возвращающий его эквивалент в градусах Фаренгейта

//FahrenheitToCelsius" - метод, принимающий значение температуры в градусах Фаренгейта и возвращающий его эквивалент в градусах Цельсия

//CelsiusToKelvin" - метод, принимающий значение температуры в градусах Цельсия и возвращающий его эквивалент в Кельвинах

//"KelvinToCelsius" - метод, принимающий значение температуры в Кельвинах и возвращающий его эквивалент в градусах Цельсия

//"FahrenheitToKelvin" - метод, принимающий значение температуры в градусах Фаренгейта и возвращающий его эквивалент в Кельвинах

//"KelvinToFahrenheit" - метод, принимающий значение температуры в Кельвинах и возвращающий его эквивалент в градусах Фаренгейта

namespace TemperatureConversion
{
   
        class TemperatureConverter
        {
            public double celsius;
            public double fahrenheit;
            public double kelvin;

            public double CelsiusToFahrenheit
            {
                get
                {
                    celsius = 32 + (celsius * 1.8);
                    return celsius;
                }
                set
                {
                    celsius = value;
                }
            }
            public double FahrenheitToCelsius
            {
                get
                {
                    fahrenheit = ((fahrenheit - 32) * 5) / 9;
                    return fahrenheit;
                }
                set
                {
                    fahrenheit = value;
                }
            }
            public double CelsiusToKelvin
            {
                get
                {
                    kelvin = kelvin + 273.15;
                    return kelvin;
                }
                set
                {
                    kelvin = value;
                }
            }
            public double KelvinToCelsius
            {
                get
                {
                    kelvin = kelvin - 273.15;
                    return kelvin;
                }
                set
                {
                    kelvin = value;
                }
            }
            public double FahrenheitToKelvin
            {
                get
                {
                    kelvin = (kelvin - 32) * 5 / 9 + 273.15;
                    return kelvin;
                }
                set
                {
                    kelvin = value;
                }
            }
            public double KelvinToFahrenheit
            {
                get
                {
                    return fahrenheit * 1.8 - 459.67;
                }
                set
                {
                    fahrenheit = (value + 459.67) / 1.8;
                }
            }



        }
    
}



