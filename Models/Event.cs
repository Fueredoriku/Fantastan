namespace Fantastan.Models;

public class Event
{
    public int id {get; set;}
    public string? title {get; set;}
    public string? description {get; set;}

    public Event(){
        
    }

    public Event(int id, string title, string description){
        this.id = id;
        this.title = title;
        this.description = description;
    }

}