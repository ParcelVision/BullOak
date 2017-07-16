﻿namespace BullOak.Test.EndToEnd.Stub.Shared.Ids
{
    using System;
    using BullOak.Common;

    internal class SeatId : IId, IEquatable<SeatId>
    {
        public string Id { get; private set; }

        public SeatId(string id)
        {
            Id = id;
        }

        public override string ToString() => Id;
        public override int GetHashCode() => Id.GetHashCode();
        public override bool Equals(object obj) => Equals(obj as SeatId);
        public bool Equals(SeatId other) => Id == other?.Id;
    }
}