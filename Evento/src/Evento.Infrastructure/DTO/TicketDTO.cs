using System;

namespace Evento.Infrastructure.DTO
{
    public class TicketDTO
    {
        public Guid Id { get;  set; }
        public int Seating { get;  set; }
        public decimal Price { get;  set; }
        public Guid? UserId { get;  set; }
        public string Username { get;  set; }
        public DateTime? PruchasedAt { get;  set; }
        public bool Purchased { get;  set; }
    }
}