using System;
using Activities.Model;
using DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Activities.Application {
	public class ActivityList {

		public class Query : IRequest<List<Activity>> { }

		public class Handler : IRequestHandler<Query, List<Activity>> {
			private readonly ApplicationDbContext dbContext;

			public Handler(ApplicationDbContext dbContext) {
				this.dbContext = dbContext;
			}
			public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken) {
				return await dbContext.Activities.ToListAsync();
			}
		}
	}
}
