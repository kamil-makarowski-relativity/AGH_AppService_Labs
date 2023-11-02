namespace SampleApp.Web.Data
{
    public interface IWeatherForecastService
    {
		Task<WeatherForecast[]> GetForecastAsync();
	}
}
