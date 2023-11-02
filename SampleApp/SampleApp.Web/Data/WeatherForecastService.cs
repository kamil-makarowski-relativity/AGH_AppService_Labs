namespace SampleApp.Web.Data
{
	public class WeatherForecastService : IWeatherForecastService
	{
		private readonly HttpClient _httpClient;

		public WeatherForecastService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<WeatherForecast[]> GetForecastAsync()
		{
			return await _httpClient.GetFromJsonAsync<WeatherForecast[]>("weatherforecast");
		}
	}
}