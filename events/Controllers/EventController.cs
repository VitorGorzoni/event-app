using System.Collections.Generic;
using events.Model;
using events.Service;
using Microsoft.AspNetCore.Mvc;

namespace events.Controllers
{
    [ApiController]
    [Route("/events")]
    public class EventController : ControllerBase
    {
        private readonly EventService _service;

        public EventController(EventService eventService)
        {
            _service = eventService;
        }

        [HttpGet]
        public List<EventModel> Get()
        {
            return _service.findAll();
        }
    }
}
