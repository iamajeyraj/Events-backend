using Activities.Model;
using DataAccess;
using MediatR;

namespace Activities.Application{
    public class ActivityDelete {
        public class Command: IRequest {
            public Guid Id { get; set;}
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly ApplicationDbContext dbContext;

            public Handler(ApplicationDbContext dbContext)
            {
                this.dbContext = dbContext;
            }
            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                 var activity = await dbContext.Activities.FindAsync(request.Id);
                 dbContext.Activities.Remove(activity);
                 await dbContext.SaveChangesAsync();
            }
        }
    }
}