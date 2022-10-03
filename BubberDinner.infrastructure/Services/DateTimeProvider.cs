using BubberDinner.application.Common.Services;

namespace BubberDinner.infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}