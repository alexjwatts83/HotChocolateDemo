using CommanderGQLApi.Data;
using CommanderGQLApi.Models;
using HotChocolate;
using HotChocolate.Data;
using System.Linq;

namespace CommanderGQLApi.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        public IQueryable<Platform> GetPlatform([ScopedService] AppDbContext context)
        {
            return context.Platforms;
        }
    }
}
