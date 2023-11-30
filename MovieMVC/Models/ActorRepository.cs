
using Microsoft.EntityFrameworkCore;

namespace MovieAppMVC.Models
{
    public class ActorRepository : IActorRepository
    {
        private readonly MovieAppDbContext _dbContext;

        public ActorRepository(MovieAppDbContext context)
        {
            _dbContext = context;            
        }

        public IEnumerable<Actor> AllActors
        {
            get
            {
                return _dbContext.Actors;
            }
        }

        public Actor? ActorOfTheWeek
        {
            get
            {
                int rowCount = _dbContext.Actors.Count();
                Random random = new Random();
                int randomIndex = random.Next(0, rowCount);
                return _dbContext.Actors.Skip(randomIndex).FirstOrDefault();
            }
        }

        public void CreateActor(Actor actor)
        {
            _dbContext.Actors.Add(actor);
            _dbContext.SaveChanges();
        }

        public void DeleteActorById(Guid id)
        {
            // TODO
            throw new NotImplementedException();
        }

        public Actor? GetActorById(Guid actorId)
        {
            return _dbContext.Actors.FirstOrDefault(a => a.Id == actorId);
        }
    }
}
