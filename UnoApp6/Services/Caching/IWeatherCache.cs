namespace UnoApp6.Services.Caching;
using WeatherForecast = UnoApp6.Client.Models.WeatherForecast;
public interface IWeatherCache
{
    ValueTask<IImmutableList<WeatherForecast>> GetForecast(CancellationToken token);
}
