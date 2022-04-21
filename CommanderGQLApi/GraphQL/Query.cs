using CommanderGQLApi.Data;
using CommanderGQLApi.Models;
using HotChocolate;
using System.Linq;

namespace CommanderGQLApi.GraphQL
{
    public class Query
    {
        public IQueryable<Platform> GetPlatform([Service] AppDbContext context)
        {
            return context.Platforms;
        }
    }
}
