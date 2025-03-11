using EventManagementSystemRepos.Models;
using EventManagementSystemRepos.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EventManagementSystemRepos.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly IEventRepository _eventRepository;

        public EventsController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEvents()
        {
            var events = await _eventRepository.GetAllEventsAsync();
            return Ok(events);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEventById(int id)
        {
            var eventEntity = await _eventRepository.GetEventByIdAsync(id);
            if (eventEntity == null)
            {
                return NotFound();
            }
            return Ok(eventEntity);
        }

        [HttpPost]
        public async Task<IActionResult> AddEvent(Event eventEntity)
        {
            await _eventRepository.AddEventAsync(eventEntity);
            return CreatedAtAction(nameof(GetEventById), new { id = eventEntity.Id }, eventEntity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEvent(int id, Event eventEntity)
        {
            if (id != eventEntity.Id)
            {
                return BadRequest();
            }
            await _eventRepository.UpdateEventAsync(eventEntity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            await _eventRepository.DeleteEventAsync(id);
            return NoContent();
        }
    }
}
