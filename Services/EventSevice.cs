using Fantastan.Models;

namespace Fantastan.Services;

public class EventService
{
    static List<Event> events {get;}
    private static int nextId = 3; 

    static EventService(){
        events = new List<Event>
        {
            new Event(1, "Oppstart 2023", "test"),
            new Event(2, "Styremøte", "tester2")
        };
    }

    public static List<Event> GetAll() => events;

    public static Event? Get(int id) => events.FirstOrDefault(e => e.id == id);

    public static void Add(Event ev)
    {
        ev.id = nextId++;
        events.Add(ev);
    }

    public static void Remove(int id)
    {   
        var ev = Get(id);
        if (ev is null) return;
        events.Remove(ev);
    }

    public static void Update(Event ev)
    {
        var index = events.FindIndex(e => e.id == ev.id);
        if (index == -1) return;
        events[index] = ev;
    }

}