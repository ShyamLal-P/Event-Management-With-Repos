using EventManagementSystemRepos.Models;

namespace EventManagementSystemRepos.Repositories.Interfaces
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetAllEventsAsync();
        Task<Event> GetEventByIdAsync(int id);
        Task AddEventAsync(Event evententity);
        Task UpdateEventAsync(Event eventEntity);
        Task DeleteEventAsync(int id);
    }
}
