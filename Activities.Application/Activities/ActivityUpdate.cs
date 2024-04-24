using Activities.Model;
using DataAccess;
using MediatR;

namespace Activities.Application{
    public sealed class ActivityUpdate{
        public class Command : IRequest{
            public Activity Activity { get; set; }
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
                dbContext.Activities.Update(request.Activity);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}