using Activities.Model;
using DataAccess;
using MediatR;

namespace Activities.Application{
    public sealed class ActivityDetails{
        public class Query: IRequest<Activity>{
            public Guid Id {get;set;}
        }
        public class Handler : IRequestHandler<Query, Activity>
        {
            private readonly ApplicationDbContext dbContext;

            public Handler(ApplicationDbContext dbContext)
            {
                this.dbContext = dbContext;
            }
            public async Task<Activity> Handle(Query request, CancellationToken cancellationToken)
            {
                return await dbContext.Activities.FindAsync(request.Id);
            }
        }
    }
}