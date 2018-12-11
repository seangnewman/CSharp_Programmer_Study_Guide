namespace Chap2_TempConverter
{
    static class FahrenheitAndCelsius
    {
        public static double FarhenheitTemperature(double celsius)
        {
            double convFactor = 9d / 5d;
            return (celsius * convFactor) + 32;
        }

        public static double CelsiusTemperature(double fahrenheit)
        {
            double convFactor = 5d / 9d;
            return (fahrenheit - 32) * convFactor;
        }

    }
}
