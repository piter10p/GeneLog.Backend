using System;

namespace GeneLog.Domain.SeedWork
{
    public class Event
    {
        public Event(DateTime dateTime, string placeName)
        {
            if (dateTime.Kind != DateTimeKind.Utc)
                throw new ArgumentException($"'{nameof(dateTime)}' is not an utc date.", nameof(dateTime));

            if (string.IsNullOrWhiteSpace(placeName))
                throw new ArgumentException($"'{nameof(placeName)}' cannot be null or whitespace.", nameof(placeName));

            DateTimeUtc = dateTime;
            PlaceName = placeName;
        }

        public DateTime DateTimeUtc { get; }
        public string PlaceName { get; }
    }
}
