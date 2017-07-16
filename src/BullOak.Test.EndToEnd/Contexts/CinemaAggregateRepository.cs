﻿namespace BullOak.Test.EndToEnd.Contexts
{
    using BullOak.EventStream;
    using System.Collections.Generic;
    using BullOak.Infrastructure.TestHelpers.Application.Stubs;
    using BullOak.Test.EndToEnd.Stub.AggregateBased.CinemaAggregate;
    using BullOak.Test.EndToEnd.Stub.Shared.Ids;

    public class CinemaAggregateRepository : Repository<CinemaAggregateRoot, CinemaAggregateRootId>
    {
        private readonly InMemoryEventStore eventStore;
        public List<IParcelVisionEventEnvelope> this[string id] => eventStore[id];

        public CinemaAggregateRepository(InMemoryEventStore eventStore) : base(eventStore)
        {
            this.eventStore = eventStore;
        }
    }
}
