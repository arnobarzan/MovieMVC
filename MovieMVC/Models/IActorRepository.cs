namespace MovieAppMVC.Models
{
    public interface IActorRepository
    {
        IEnumerable<Actor> AllActors { get; }
        Actor? ActorOfTheWeek { get; }
        Actor? GetActorById(Guid actorId);
        void CreateActor(Actor actor);
        void DeleteActorById(Guid id);
    }
}
