namespace Weather.Utilities.TemperatureConverter
{
    public static class Converter
    {
        public static double ToFahrenheit(double degreeCelciusTemp)
        {
            return (degreeCelciusTemp * 9 / 5) + 32;
        }
        public static double ToDegreeCelcius(double fahrenheitTemp)
        {
            return (fahrenheitTemp - 32) * 5 / 9;
        }
    }
}
