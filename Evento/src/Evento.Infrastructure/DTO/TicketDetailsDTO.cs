using System;

namespace Evento.Infrastructure.DTO
{
    public class TicketDetailsDTO : TicketDTO
    {
        public Guid EventId { get; set; }
        public string EventName { get; set; }
    }
}