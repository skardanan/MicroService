using System;
using System.Collections.Generic;
using System.Text;

namespace MicroService.Shoping.Framework
{
    public class AggregateRoot : Entity
    {
        public int Version { get; private set; }
        private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();
        public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();
        
        public AggregateRoot()
        {

        }
        public AggregateRoot(IEnumerable<IDomainEvent> events)
        {
            if (events == null) return;
            foreach (var @event in events)
            {
                Mutate(@event);
                Version++;
            }
        }
       
        protected void Apply(IEnumerable<IDomainEvent> events) {
            foreach (var @event in events)
            {
                Apply(@event);
            }        
        }
        protected void Apply(IDomainEvent @event)
        {
            Mutate(@event);
            AddDomainEvent(@event);
        }
        protected void AddDomainEvent(IDomainEvent @event) => _domainEvents.Add(@event); 
        protected void RemoveDomainEvent(IDomainEvent @event) => _domainEvents.Remove(@event);
        protected void ClearDomainEvents() => _domainEvents.Clear();
        
        private void Mutate(IDomainEvent @event) => ((dynamic)this).on((dynamic)@event);
    }
}
