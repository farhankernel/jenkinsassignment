namespace MyJenkinsAPI
{
 /// <summary>
 /// Class to expose weather functions
 /// </summary>
    public class WeatherForecast
    {
     /// <summary>
     /// Current Date Time
     /// </summary>
        public DateTime Date { get; set; }


        /// <summary>
        /// Retreive temperature
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Temp
        /// </summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}