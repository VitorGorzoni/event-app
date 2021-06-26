using System;
using System.Collections.Generic;
using events.Model;
using events.Repository;

namespace events.Service
{
    public class EventService
    {
        private readonly EventRepository _repository;

        public EventService(EventRepository eventRepository)
        {
            _repository = eventRepository;
        }

        public List<EventModel> findAll()
        {
            return _repository.findAll();
        }
    }
}
