
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace RaceDay.API.Models;

public class EventType
{
    public int EventTypeID { get; set; }

    [Required, MaxLength(20)]
    public string TypeName { get; set; } = string.Empty;

    public ICollection<Event> Events { get; set; }
        = new List<Event>();
}
