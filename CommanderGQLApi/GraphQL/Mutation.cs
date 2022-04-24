using CommanderGQLApi.Data;
using CommanderGQLApi.GraphQL.Commands;
using CommanderGQLApi.GraphQL.Platforms;
using CommanderGQLApi.Models;
using HotChocolate;
using HotChocolate.Data;
using System.Threading.Tasks;

namespace CommanderGQLApi.GraphQL
{
    [GraphQLDescription("Represents the mutations available.")]
    public class Mutation
    {
        [UseDbContext(typeof(AppDbContext))]
        public async Task<AddPlatformPayload> AddPlatformAsync(AddPlatformInput input, [ScopedService] AppDbContext context)
        {
            var platform = new Platform
            {
                Name = input.Name
            };

            context.Platforms.Add(platform);
            await context.SaveChangesAsync();

            return new AddPlatformPayload(platform)
;
        }

        [UseDbContext(typeof(AppDbContext))]
        [GraphQLDescription("Adds a command.")]
        public async Task<AddCommandPayload> AddCommandAsync(AddCommandInput input, [ScopedService] AppDbContext context)
        {
            var command = new Command
            {
                HowTo = input.HowTo,
                CommandLine = input.CommandLine,
                PlatformId = input.PlatformId
            };

            context.Commands.Add(command);
            await context.SaveChangesAsync();

            return new AddCommandPayload(command);
        }
    }
}