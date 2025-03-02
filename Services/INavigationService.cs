namespace Explosion.Services
{
    public interface INavigationService
    {
        Task GoToAsync(string route);

        Task GoToAsync(string route, object? paramValue = null);

        Task GoBackAsync();
    }
}
