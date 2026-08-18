namespace Domain.Entities;

public class Booking
{
    public Guid Id { get; set; }
    public Guid ClientId { get; set; }
    public Guid ServiceId { get; set; }
    public DateTime RequestedDate { get; set; }
    public BookingStatus Status { get; set; }
    public string? Notes { get; set; }
}

public enum BookingStatus
{
    Requested,
    Confirmed,
    InProgress,
    Delivered,
    Closed
}