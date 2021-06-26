using System;
using System.Collections.Generic;
using System.Linq;
using events.context;
using events.Model;

namespace events.Repository
{
    public class EventRepository
    {
        public EventRepository()
        {
        }

        public List<EventModel> findAll()
        {
            using (var db = new EntityFrameworkContext())
            {
                var events = db.Events.ToList();
                return events;
            }
        }
    }
}
